using System;
using System.Collections.Generic;
using AgglomerativeClustering.Linkage;



namespace AgglomerativeClustering
{
    public class AgglomerativeClustering
    {
        #region private members

        private int _clustersCount;

        private int _currentClustersCount;
        
        private List<Cluster> _clusters;

        private float[,] _data;

        #endregion

        #region public members

        public List<int> Labels { get; private set; }
        
        public ILinkageLanceWilliams Linkage { get; set; }

        #endregion

        #region constructors

        public AgglomerativeClustering(int clustersCount, ILinkageLanceWilliams linkage)
        {
            _clustersCount = clustersCount;
            Linkage = linkage;
        }

        #endregion

        #region public methods

        public AgglomerativeClustering Fit(float[,] data)
        {
            _data = data;
            InitClusters(data);
            InitDistances();
            InitLabels();

            /*
             * while clusters_count > expected
             *      find min
             *      recalculate
             */
            int iteration = 1;
            while(_currentClustersCount > _clustersCount)
            {
                float min;
                Cluster first;
                Cluster second;
                (min, first, second) = GetMinDistance();
                Console.WriteLine($"[{iteration++}] Minimal distance: {min}");

                Cluster newCluster = Cluster.Merge(first, second);
                _clusters.Remove(first);
                _clusters.Remove(second);
                
                foreach (var cluster in _clusters)
                {
                    //float distanceToNewCluster = Linkage is WardLinkage ? 
                    //    WardDistance(newCluster, cluster) : Linkage.CalculateDistanceByLanceWilliams(first, second, cluster);
                    float distanceToNewCluster = Linkage.CalculateDistanceByLanceWilliams(first, second, cluster);
                    cluster.Distances.Remove(first);
                    cluster.Distances.Remove(second);
                    cluster.Distances.Add(newCluster, distanceToNewCluster);
                    newCluster.Distances.Add(cluster, distanceToNewCluster);
                }
                _clusters.Add(newCluster);

                _currentClustersCount--;
            }

            //setting labels
            int currentLabel = 0;
            foreach (var cluster in _clusters)
            {
                foreach (var index in cluster.Indexes)
                {
                    Labels[index] = currentLabel;
                }
                currentLabel++;
            }

            return this;
        }

        public List<int> FitPredict(float[,] data)
        {
            Fit(data);
            return Labels;
        }


        #endregion

        #region private methods

        private void InitClusters(float[,] data)
        {
            int rows = data.GetLength(0);
            int cols = data.GetLength(1);
            _clusters = new List<Cluster>(rows);

            for (int i = 0; i < rows; i++)
            {
                _clusters.Add(new Cluster() { Indexes = { i } });
            }

            _currentClustersCount = _clusters.Count;
        }

        private void InitDistances()
        {
            int nClusters = _clusters.Count;
            for (int i = 0; i < nClusters; i++)
            {
                for (int j = i + 1; j < nClusters; j++)
                {
                    float distance;
                    if (Linkage is WardLinkage)
                    {
                        distance = WardDistance(_clusters[i], _clusters[j]);
                    }
                    else
                    {
                        int dimensions = _data.GetLength(1);
                        float sum = 0;
                        for (int k = 0; k < dimensions; k++)
                        {
                            var first = _clusters[i].Indexes[0];
                            var second = _clusters[j].Indexes[0];

                            sum += (_data[first, k] - _data[second, k]) * (_data[first, k] - _data[second, k]);
                        }
                        distance = (float) Math.Sqrt(sum);
                    }

                    _clusters[i].Distances.Add(_clusters[j], distance);
                    _clusters[j].Distances.Add(_clusters[i], distance);
                }
            }
        }

        private void InitLabels()
        {
            int count = _clusters.Count;
            Labels = new List<int>(count);
            for (int i = 0; i < count; i++)
            {
                Labels.Add(-1);
            }
        }

        private (float min, Cluster row, Cluster col) GetMinDistance()
        {
            float min = float.MaxValue;

            Cluster first = null;
            Cluster second = null;
            foreach (var cluster in _clusters)
            {
                foreach (var clusterDistance in cluster.Distances)
                {
                    if(clusterDistance.Value < min)
                    {
                        min = clusterDistance.Value;
                        first = cluster;
                        second = clusterDistance.Key;
                    }
                }
            }

            return (min, first, second);
        }

        private float WardDistance(Cluster c1, Cluster c2)
        {
            var c1Center = new float[_data.GetLength(1)];
            var c2Center = new float[_data.GetLength(1)];
            foreach (var c1Index in c1.Indexes)
            {
                for (int j = 0; j < _data.GetLength(1); j++)
                {
                    c1Center[j] += _data[c1Index, j];
                }
            }

            for (int i = 0; i < _data.GetLength(1); i++)
            {
                c1Center[i] /= c1.Count;
            }

            foreach (var c2Index in c2.Indexes)
            {
                for (int j = 0; j < _data.GetLength(1); j++)
                {
                    c2Center[j] += _data[c2Index, j];
                }
            }

            for (int i = 0; i < _data.GetLength(1); i++)
            {
                c2Center[i] /= c2.Count;
            }

            float centerDist = Distance.Euclidean(new Vector(c1Center), new Vector(c2Center));
            float wardDist = centerDist * centerDist;
            wardDist *= (c1.Count * c2.Count) / (float)(c1.Count + c2.Count);
            return wardDist;
        }
        #endregion
    }   
}

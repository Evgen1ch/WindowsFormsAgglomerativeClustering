using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;


namespace AgglomerativeClustering
{
    public class Cluster
    {
        public Dictionary<Cluster, float> Distances { get; set; } = new Dictionary<Cluster, float>();

        //TODO change to List<Vector<float>>
        //public List<List<float>> Elements { get; set; }

        public List<int> Indexes { get; set; } = new List<int>();

        //public Cluster Parent1 { get; set; }

        //public Cluster Parent2 { get; set; }

        public Cluster()
        {
            //Elements = new List<List<float>>();
            Indexes = new List<int>();
        }

        public Cluster(params List<float>[] elements)
        {
            //Elements = new List<List<float>>(elements);
            Indexes = new List<int>();
        }

        public Cluster(Cluster parent1, Cluster parent2 ,params List<float>[] elements)
        {
            //Parent1 = parent1;
            //Parent2 = parent2;
            //Elements = new List<List<float>>(elements);
            Indexes.AddRange(parent1.Indexes);
            Indexes.AddRange(parent2.Indexes);
        }

        public float DistanceTo(Cluster target)
        {
            return Distances[target];
        }

        public int Count => Indexes.Count;

        

        public static Cluster Merge(Cluster first, Cluster second)
        {
            return new Cluster(first, second);
        }

        public override string ToString()
        {
            return $"Cluster(Count = {Count})";
        }
    }
}

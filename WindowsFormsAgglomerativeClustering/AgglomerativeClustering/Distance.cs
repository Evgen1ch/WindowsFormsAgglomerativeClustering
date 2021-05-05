using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgglomerativeClustering
{
    public class Vector
    {
        private float[] _coordinates;

        public int Dimensionality => _coordinates.Length;

        
        public Vector(IEnumerable<float> coordinates)
        {
            _coordinates = coordinates.ToArray();
        }

        public Vector(params float[] coordinates)
        {
            _coordinates = coordinates;
        }

        public Vector(int dimensionality)
        {
            _coordinates = new float[dimensionality];
        }
        public float this[int index]
        {
            get => _coordinates[index];
            set => _coordinates[index] = value;
        }
    }

    public class Distance
    {
        public static float Euclidean(Vector first, Vector second)
        {
            int firstLength = first.Dimensionality;
            int secondLength = second.Dimensionality;

            if (firstLength != secondLength)
                throw new InvalidOperationException("Points must have the same dimensionality");

            float sum = 0f;

            for (int i = 0; i < firstLength; i++)
            {
                sum += (first[i] - second[i]) * (first[i] - second[i]);
            }

            return (float)Math.Sqrt(sum);
        }

        public static float Ward(Vector firstCenter, Vector secondCenter)
        {
            int firstLength = firstCenter.Dimensionality;
            int secondLength = secondCenter.Dimensionality;

            if (firstLength != secondLength)
                throw new InvalidOperationException("Points must have the same dimensionality");

            float centerDistance = Euclidean(firstCenter, secondCenter);
            centerDistance *= centerDistance;
            return 0.5f * centerDistance;
        }
    }
}

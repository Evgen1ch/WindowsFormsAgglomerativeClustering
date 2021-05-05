using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgglomerativeClustering.DataScaling
{
    public static class Standardization
    {
        public static float[,] Standardize(float[,] data)
        {
            int rows = data.GetLength(0);
            int cols = data.GetLength(1);
            float[,] newData = new float[rows, cols];

            for (int i = 0; i < cols; i++)
            {
                double featureAverage = 0f;
                double sum = 0f;
                double std = 0f;
                for (int j = 0; j < rows; j++)
                {
                    sum += data[j, i];
                }

                featureAverage = sum / rows;

                sum = 0.0f;
                for (int j = 0; j < rows; j++)
                {
                    sum += Math.Pow(data[j, i] - featureAverage, 2) / (rows - 1.0d);
                }

                std = Math.Sqrt(sum);

                for (int j = 0; j < rows; j++)
                {
                    newData[j, i] = (float) (((double)(data[j, i]) - featureAverage) / std);
                }
            }

            return newData;
        }
    }
}

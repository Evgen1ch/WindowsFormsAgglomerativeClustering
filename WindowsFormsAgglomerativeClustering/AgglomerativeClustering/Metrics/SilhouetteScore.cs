using System;
using System.Collections.Generic;
using System.Linq;

namespace AgglomerativeClustering.Metrics
{
    public class SilhouetteScore: IMetric
    {
        public float Calculate(float[,] X, int[] y)
        {
            int rows = X.GetLength(0);
            int cols = X.GetLength(1);
            int count = y.Distinct().Count();

            if (rows != y.Length) 
                throw new ArgumentException("Must be the same size");
            

            /*
             * проходим по объектам
             *      для каждого обьекта рассчитываем расстояния проходя по всем кроме данного
             *      добавляем в общую сумму индекс силуета данного обьекта
             * берем следующий объект
             * делим сумму на кол-во элементов
             */
            float silhouetteSum = 0;
            float[] sums = new float[count];
            
            for (int i = 0; i < rows; i++)
            {
                int currentLabel = y[i];

                int currentCount = y.Count((label) => label == currentLabel);
                if (currentCount == 1) continue;

                Array.Clear(sums, 0, sums.Length);
                
                for (int j = 0; j < rows; j++)
                {
                    if(i == j) continue;

                    var currentPoint = ArrayUtility.GetRow(i, X);
                    var targetPoint = ArrayUtility.GetRow(j, X);
                    if (y[j] == currentLabel)
                    {
                        //calculate for parent cluster
                        sums[currentLabel] += Distance.Euclidean(new Vector(currentPoint), new Vector(targetPoint));
                    }
                    else
                    {
                        //calculate for another clusters
                        sums[y[j]] += Distance.Euclidean(new Vector(currentPoint), new Vector(targetPoint));
                    }
                }

                //calculate a
                //calculate b
                //calculate silhouette for element
                //add silhouette for element to silhouetteSum
                float a = sums[currentLabel] / ((float)currentCount - 1.0f);             //a

                for (int j = 0; j < sums.Length; j++)
                {
                    if(j == y[i]) continue;
                    sums[j] /= y.Count((label) => label == j);
                }
                float b = float.MaxValue; //b
                for (int j = 0; j < sums.Length; j++)
                {
                    if (j == y[i]) continue;
                    if (sums[j] < b)
                    {
                        b = sums[j];
                    }
                } 

                float silhouette = (b - a) / Math.Max(a, b);

                silhouetteSum += silhouette;
            }
            
            return silhouetteSum / rows;
        }
    }
}

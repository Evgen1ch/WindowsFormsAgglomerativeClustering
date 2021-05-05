using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgglomerativeClustering.Metrics
{
    public interface IMetric
    {
        float Calculate(float[,] X, int[] y);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgglomerativeClustering.Linkage
{
    public static class LanceWilliams
    {
        public static float Calculate(float al, float ah, float beta, float gamma, Cluster firstPart, Cluster secondPart, Cluster target)
        {
            return al * firstPart.DistanceTo(target) +
                   ah * secondPart.DistanceTo(target) +
                   beta * firstPart.DistanceTo(secondPart) +
                   gamma * Math.Abs(firstPart.DistanceTo(target) - secondPart.DistanceTo(target));
        }
    }
}

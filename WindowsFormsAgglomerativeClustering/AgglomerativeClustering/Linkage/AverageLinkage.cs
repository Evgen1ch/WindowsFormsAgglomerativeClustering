using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgglomerativeClustering.Linkage
{
    public class AverageLinkage: ILinkageLanceWilliams
    {
        public float CalculateDistanceByLanceWilliams(Cluster firstPart, Cluster secondPart, Cluster target)
        {
            float al = (float) firstPart.Count / (firstPart.Count + secondPart.Count);
            float ah = (float)secondPart.Count / (firstPart.Count + secondPart.Count);
            float beta = 0f;
            float gamma = 0f;

            return LanceWilliams.Calculate(al, ah, beta, gamma, firstPart, secondPart, target);
        }
    }
}

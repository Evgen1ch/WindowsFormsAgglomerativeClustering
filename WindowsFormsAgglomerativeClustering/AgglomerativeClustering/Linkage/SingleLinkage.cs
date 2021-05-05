using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgglomerativeClustering.Linkage
{
    public class SingleLinkage: ILinkageLanceWilliams
    {
        public float CalculateDistanceByLanceWilliams(Cluster firstPart, Cluster secondPart, Cluster target)
        {
            float al = 0.5f;
            float ah = 0.5f;
            float beta = 0f;
            float gamma = -0.5f;

            return LanceWilliams.Calculate(al, ah, beta, gamma, firstPart, secondPart, target);
        }
    }
}

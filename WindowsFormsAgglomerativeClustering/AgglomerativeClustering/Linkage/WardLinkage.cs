using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgglomerativeClustering.Linkage
{
    public class WardLinkage: ILinkageLanceWilliams
    {
        public float CalculateDistanceByLanceWilliams(Cluster firstPart, Cluster secondPart, Cluster target)
        {
            float al = ((float)firstPart.Count + target.Count) / (float)(firstPart.Count + secondPart.Count + target.Count);
            float ah = ((float)secondPart.Count + target.Count) / (float)(firstPart.Count + secondPart.Count + target.Count);
            float beta = -((target.Count) / (float)(firstPart.Count + secondPart.Count + target.Count));
            float gamma = 0f;


            //float result = (float)Math.Sqrt(
            //    al * Math.Pow(firstPart.DistanceTo(target), 2)
            //    + ah * Math.Pow(secondPart.DistanceTo(target), 2)
            //    + beta * Math.Pow(firstPart.DistanceTo(secondPart), 2)
            //    );
            return LanceWilliams.Calculate(al, ah, beta, gamma, firstPart, secondPart, target); //result;
        }
    }
}

namespace AgglomerativeClustering.Linkage
{
    public interface ILinkageLanceWilliams
    {
        float CalculateDistanceByLanceWilliams(Cluster firstPart, Cluster secondPart, Cluster target);
    }
}

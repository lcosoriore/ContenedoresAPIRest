namespace Containers.Interfaces
{
    using Containers.Models;
    internal interface IContainersData
    {
        void CreateStatistics(StatsModel statsModel);
        List<StatsModel> GetStats();

    }
}

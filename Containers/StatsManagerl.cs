namespace Containers
{
    using Containers.Models;
    public class StatsManagerl
    {
        public static async Task<List<StatsModel>> GetStats()
        {
            return DAL.ContainersDataController.Instance.GetStats();
        }

    }
}

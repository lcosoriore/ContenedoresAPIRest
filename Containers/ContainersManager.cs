namespace Containers
{
    using Containers.Models;
    public class ContainersManager
    {
        private double containers_dispatched = 0;
        private double containers_not_dispatched = 0;
        private double budget_used = 0;
        public List<string> selectContainers(double budget, List<ContainersModel> lstContainers)
        {
            double sumatoria = 0;

            List<string> containers = new List<string>();
            foreach (var item in lstContainers)
            {
                if (Math.Round(sumatoria + (item.transportCost), 2) <= budget)
                {
                    containers_dispatched = Math.Round(containers_dispatched + item.containerPrice,2);
                    sumatoria = Math.Round(sumatoria + (item.transportCost),2);
                    budget_used = sumatoria;
                    containers.Add(item.name);
                }
                else
                {
                    containers_not_dispatched= Math.Round(containers_not_dispatched + item.containerPrice,2);
                }
            }
            StatsModel statsModel = new StatsModel();
            statsModel.containers_dispatched= containers_dispatched;
            statsModel.containers_not_dispatched= containers_not_dispatched;
            statsModel.budget_used = budget_used;
            if (statsModel != null)
            {
                DAL.ContainersDataController.Instance.CreateStatistics(statsModel);
            }
            return containers;
        }

        public List<StatsModel> GetStats()
        {
            List<StatsModel> lstStats = new List<StatsModel>();
            lstStats=DAL.ContainersDataController.Instance.GetStats();
            return lstStats;
        }

    }
}
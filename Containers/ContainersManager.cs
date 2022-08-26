namespace Containers
{
    using Containers.Models;
    public class ContainersManager
    {
        public async Task<List<string>> selectContainers(double budget, List<ContainersModel> lstContainers)
        {
            double budgetFlag = budget;

            var dispatchedContainers = new List<ContainersModel>();
            var notDispatchedContainers = new List<ContainersModel>();

            lstContainers.ForEach(item =>
            {
                if (budgetFlag - item.transportCost > 0)
                {
                    dispatchedContainers.Add(item);
                    budgetFlag -= item.transportCost;
                }
                else
                {
                    notDispatchedContainers.Add(item);
                }
            });

            var statsModel = new StatsModel
            {
                containers_dispatched = dispatchedContainers.Sum(x => x.containerPrice),
                containers_not_dispatched = notDispatchedContainers.Sum(x => x.containerPrice),
                budget_used = dispatchedContainers.Sum(x => x.transportCost)
            };
            if (statsModel != null)
            {
                DAL.ContainersDataController.Instance.CreateStatistics(statsModel);
            }
             return dispatchedContainers.Select(x => x.name).ToList();
        }

       

    }
}
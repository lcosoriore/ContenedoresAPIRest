namespace Containers.DAL
{
    using Containers.Models;
    using System.Collections.Generic;

    internal class ContainersDataController : Interfaces.IContainersData
    {
        #region Singleton instance

        private static Interfaces.IContainersData oInstance;
        public static Interfaces.IContainersData Instance
        {
            get
            {
                if (oInstance == null)
                    oInstance = new ContainersDataController();
                return oInstance;
            }
        }
        private Interfaces.IContainersData DataFactoryMySql;
        #endregion
        public ContainersDataController()
        {
            DataFactoryMySql = ContainersDataFactory.GetDataInstance(true);
        }

        public void CreateStatistics(StatsModel statsModel)
        {
            DataFactoryMySql.CreateStatistics(statsModel);
        }

        public List<StatsModel> GetStats()
        {
            List<StatsModel> lstStats = new List<StatsModel>();
            return lstStats=DataFactoryMySql.GetStats();
        }
    }
}

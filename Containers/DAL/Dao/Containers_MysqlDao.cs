namespace Containers.DAL.Dao
{
    using Containers.Interfaces;
    using Containers.Models;
    using System.Data;

    internal class Containers_MysqlDao : IContainersData
    {
        private ADO.Rest.Interfaces.IADO DataInstance;
        public Containers_MysqlDao()
        {
            DataInstance = ADO.Rest.ADOFactory.GetADOInstance(Models.Constants.C_ConnectionName);
        }
        public void CreateStatistics(StatsModel statsModel)
        {
            List<System.Data.IDbDataParameter> lstParams = new List<System.Data.IDbDataParameter>();
            if (statsModel != null)
            {
                lstParams.Add(DataInstance.CreateTypedParameter("Vbudgetused", statsModel.budget_used));
                lstParams.Add(DataInstance.CreateTypedParameter("Vcontainersdispatched", statsModel.containers_dispatched));
                lstParams.Add(DataInstance.CreateTypedParameter("Vcontainersnotdispatched", statsModel.containers_not_dispatched));

                ADO.Rest.Models.ADOModelResponse response = DataInstance.ExecuteQuery(new ADO.Rest.Models.ADOModelRequest()
                {
                    CommandExecutionType = ADO.Rest.Models.enumCommandExecutionType.NonQuery,
                    CommandText = "InsertStatistics",
                    CommandType = System.Data.CommandType.StoredProcedure,
                    Parameters = lstParams
                });
            }
        }
        public List<StatsModel> GetStats()
        {
            List<System.Data.IDbDataParameter> lstParams = new List<System.Data.IDbDataParameter>();

            ADO.Rest.Models.ADOModelResponse response = DataInstance.ExecuteQuery(new ADO.Rest.Models.ADOModelRequest()
            {
                CommandExecutionType = ADO.Rest.Models.enumCommandExecutionType.DataTable,
                CommandText = "GetStatistics",
                CommandType = System.Data.CommandType.StoredProcedure

            });
            List<StatsModel>? oReturn = null;
            if (response.DataTableResult != null)
            {
                oReturn =
                     (from mk in response.DataTableResult.AsEnumerable()
                      select new StatsModel()
                      {
                          budget_used = (double)mk.Field<decimal>("budgetused"),
                          containers_dispatched = (double)mk.Field<decimal>("containersdispatched"),
                          containers_not_dispatched = (double)mk.Field<decimal>("containersnotdispatched"),

                      }).ToList();
            }
            return oReturn;
        }
    }
}

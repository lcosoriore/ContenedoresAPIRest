namespace ADO.Rest
{
    public class ADOFactory
    {
        public static ADO.Rest.Interfaces.IADO GetADOInstance(string ConnectionName)
        {
            ADO.Rest.Interfaces.IADO oReturn = null;

            //switch (System.Configuration.ConfigurationManager.ConnectionStrings[ConnectionName].ProviderName)
            //{
            //    case "MySql.Data.MySqlClient":
                    //my sql
                    oReturn = new ADO.Rest.MYSQL.MySqlImplement(ConnectionName);
            //        break;
            //}

            return oReturn;
        }
    }
}
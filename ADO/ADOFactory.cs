namespace ADO
{
    public class ADOFactory
    {
        public static ADO.Interfaces.IADO GetADOInstance(string ConnectionName)
        {
            ADO.Interfaces.IADO oReturn = null;

            switch (System.Configuration.ConfigurationManager.ConnectionStrings[ConnectionName].ProviderName)
            {
                case "MySql.Data.MySqlClient":
                    //my sql
                    oReturn = new ADO.MYSQL.MySqlImplement(ConnectionName);
                    break;
            }

            return oReturn;
        }
    }
}

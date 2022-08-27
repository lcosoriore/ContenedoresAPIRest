namespace ADO.Rest
{
    public class ADOFactory
    {
        public static ADO.Rest.Interfaces.IADO GetADOInstance(string ConnectionName)
        {
            ADO.Rest.Interfaces.IADO oReturn = null;
                    oReturn = new ADO.Rest.MYSQL.MySqlImplement(ConnectionName);
            return oReturn;
        }
    }
}
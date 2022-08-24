namespace Containers.DAL
{
    internal class ContainersDataFactory
    {
        public static Interfaces.IContainersData GetDataInstance(bool IsMySql)
        {

            Type typetoreturn = Type.GetType("Containers.DAL.Dao.Containers_MysqlDao,Containers");
            Interfaces.IContainersData oRetorno = (Interfaces.IContainersData)Activator.CreateInstance(typetoreturn);
            return oRetorno;
        }
    }
}

using Containers;
using Containers.Models;

namespace xUnit.ContenedoresRest
{
    public class ContainersTest
    {
        [Fact]
        public void Containers_selectContainers_ContainersDespachados()
        {
            double budget = 1508.65;
            List<ContainersModel> objModel = new List<ContainersModel>();
            objModel.Add(new ContainersModel
            {
                name="c1",
                containerPrice= 4744.03,
                transportCost= 571.4

            });
            objModel.Add(new ContainersModel
            {
                name = "c2",
                containerPrice = 3579.07,
                transportCost = 537.33

            });
            objModel.Add(new ContainersModel
            {
                name = "c3",
                containerPrice = 3579.07,
                transportCost = 537.33

            });
            objModel.Add(new ContainersModel
            {
                name = "c4",
                containerPrice = 1700.12,
                transportCost = 247.28

            });
            objModel.Add(new ContainersModel
            {
                name = "c5",
                containerPrice = 1434.80,
                transportCost = 264.54

            });
            ContainersManager objContainer = new ContainersManager();
            List<string> lstContainers= objContainer.selectContainers(budget, objModel);
            Assert.Equal(new string[] { "c1", "c2", "c4" }, lstContainers);
        }

        [Fact]
        public void Containers_GetStats()
        {
           
            ContainersManager objContainer = new ContainersManager();
            List<StatsModel> lstContainers = objContainer.GetStats();
            //Assert.Equal(new double[] { 1356, 10023, 5014, lstContainers);
        }
    }
}
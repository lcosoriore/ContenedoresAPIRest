namespace ContenedoresRest.Controllers
{
    using Containers;
    using Containers.Models;
    using Microsoft.AspNetCore.Mvc;
    [ApiController]
    [Route("[controller]")]
    public class StatsController : ControllerBase
    {
        [HttpPost(Name = "stats")]
        public List<StatsModel> Get()
        {
            ContainersManager objContainer = new ContainersManager();
            try
            {
                List < StatsModel > stats = new List<StatsModel>();
                stats = objContainer.GetStats();
                return stats;
            }
            catch (Exception ex)
            {
                throw new Exception("Errores en la peticion: " + ex.Message);
            }

        }
    }
}

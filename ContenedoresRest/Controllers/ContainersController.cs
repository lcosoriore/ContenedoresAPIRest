namespace ContenedoresRest.Controllers
{
    using Containers;
    using Containers.Models;
    using Microsoft.AspNetCore.Mvc;
    using System.Net;
    [ApiController]
    [Route("[controller]")]
    public class ContainersController : ControllerBase
    {
       
        [HttpPost(Name = "selectContainers")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IEnumerable<string> Get(double budget,List<ContainersModel> lstContainers)
        {
            ContainersManager objContainer = new ContainersManager();
            List<string> lstContainersDispa = new List<string>();
            try
            {
                if (budget != 0 && (lstContainers.Count > 0 || lstContainers==null))
                {
                    return lstContainersDispa = objContainer.selectContainers(budget,lstContainers);
                }
                else
                {
                    throw new Exception("Errores en el request enviado");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Errores en la peticion: "+ex.Message);
            }
        }
    }
}

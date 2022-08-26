namespace ContenedoresRest.Controllers
{
    using Containers;
    using Containers.Models;
    using Microsoft.AspNetCore.Mvc;
    using System.Net;
    [ApiController]
    [Route("api/[controller]")]
    public class ContainersController : ControllerBase
    {

        [HttpPost(Name = "selectContainers")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
       
            public async Task<ActionResult> Get(double budget, List<ContainersModel> lstContainers)
            {
            var objContainer = new ContainersManager();

            if (budget == 0 && !lstContainers.Any())
            {
                return new BadRequestObjectResult("Errores en el request enviado");
            }
            return new OkObjectResult(objContainer.selectContainers(budget, lstContainers));
        }
    }
}

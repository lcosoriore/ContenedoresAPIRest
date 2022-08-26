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
        /// <summary>
        /// Metodo para obtener contenedores que se ajustan al presupuesto enviado para ser despachado
        /// </summary>
        /// <param name="budget">parametro de tipo double para enviar el presupuesto</param>
        /// <param name="lstContainers">parametro de tipo lista para enviar la informacion de los contenedores</param>
        /// <returns>Se retorna el listado de los contenedores que se ajustan al presupuesto</returns>
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

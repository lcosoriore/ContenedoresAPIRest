namespace ContenedoresRest.Controllers
{
    using Containers;
    using Containers.Models;
    using Microsoft.AspNetCore.Mvc;
    using System.Net;
    [ApiController]
    [Route("api/[controller]")]
    public class StatsController : ControllerBase
    {
        /// <summary>
        /// Metodo para obtener las estadisticas de los procesos de despacho
        /// </summary>
        /// <returns>Se retorna el listado con las estadisticas de los despachos procesados</returns>
        [HttpGet("stats")]

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(string))]
        public async Task<IActionResult> Get()
        {
            var result =  StatsManagerl.GetStats();
            if (result!=null)
                return new OkObjectResult(result);
            else
            {
                return new NotFoundResult();
            }
        }
    }
}

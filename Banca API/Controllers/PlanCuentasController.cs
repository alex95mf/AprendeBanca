using Banca_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using Swashbuckle.AspNetCore.Annotations;

namespace Banca_API.Controllers
{    
    [ApiController]
    [Route("api/[controller]")]
    public class PlanCuentasController : ControllerBase
    {
        private readonly ILogger<PlanCuentasController> _logger;
        private readonly ApplicationDbContext _dbContext;

        public PlanCuentasController(ILogger<PlanCuentasController> logger, ApplicationDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        [HttpGet("ObtenerPlanesDeCuenta")]
        [SwaggerOperation(Summary = "Obtiene los planes de cuenta")]
        [SwaggerResponse(StatusCodes.Status200OK, "Éxito", typeof(List<ConCuentaPlan>))]
        public List<ConCuentaPlan> ObtenerPlanesDeCuenta()
        {
            List<ConCuentaPlan> planesCuenta =  _dbContext.ConCuentaPlans.ToList();
            return planesCuenta;
        }

        [HttpPost("RegistrarPlanesDeCuenta")]
        [SwaggerOperation(Summary = "Registra planes de cuenta")]
        [SwaggerResponse(StatusCodes.Status200OK, "Éxito")]
        public IActionResult  RegistrarPlanesDeCuenta(string dato)
        {            
            return Ok("Se registró correctamente");
        }
    }
}

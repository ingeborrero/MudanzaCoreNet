using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mudanzas.Core.Interfaces;

namespace Mudanzas.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RegistroTrazaController : ControllerBase
    {
        private readonly ILogTrazaService _logTrazaService;

        public RegistroTrazaController(ILogTrazaService logTrazaService)
        {
            _logTrazaService = logTrazaService;
        }

        [HttpGet]
        [Route("ObtenerDataProcesada")]
        public IActionResult ObtenerDataProcesada()
        {
            try
            {
                var response = _logTrazaService.ObtenerLogTraza();

                return Ok(response); 
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Message {ex.Message}");
                return StatusCode(500, ex.Message);
            }
        }
    }
}

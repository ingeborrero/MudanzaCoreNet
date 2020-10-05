using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Mudanzas.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RegistroTrazaController : ControllerBase
    {
        [HttpGet]
        [Route("ObtenerDataProcesada")]
        public IActionResult ObtenerDataProcesada()
        {
            try
            {
                return Ok(); 
            }
            catch (Exception ex)
            {
               
                Console.WriteLine($"Error Message {ex.Message}");
                return null;
            }
        }
    }
}

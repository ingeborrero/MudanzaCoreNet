using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mudanzas.Core.Interfaces;
using Mudanzas.Web.Dto;

namespace Mudanzas.Web.Controllers
{
    [ApiController]
    [Route("api/procesomudanza")]
    public class ProcesoMudanzaController : ControllerBase
    {
        private readonly IProcesoMudanzaService _procesoMudanzasService;

        public ProcesoMudanzaController(IProcesoMudanzaService procesoMudanzaService)
        {
            _procesoMudanzasService = procesoMudanzaService;
        }


        [HttpPost]
        [Route("Procesar")]
        public IActionResult ProcesarArchivo(ProcesoRequest request)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest("Modelo no Valido");

                var response = _procesoMudanzasService.ProcesarDatos(request.File, request.Cedula);
                return Ok(response);
            }
            catch (Exception ex)
            {
                var uuid = Guid.NewGuid();
                Console.WriteLine($" --- Error uuid: {uuid} ---");
                Console.WriteLine($"Error Message {ex.Message}");
                Console.WriteLine($"Error StackTrace {ex.StackTrace}");
                return StatusCode(500, $"Error id: {uuid}");
            }
        }


    }
}

using DatatonAPI.Models;
using DatatonAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace DatatonAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeclaracionesController : ControllerBase
    {
        private readonly ICosmosDbService _cosmosDbService;

        public DeclaracionesController(ICosmosDbService cosmosDbService)
        {
            _cosmosDbService = cosmosDbService ?? throw new ArgumentNullException(nameof(cosmosDbService));
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            return Ok(await _cosmosDbService.GetMultipleAsync("SELECT * FROM c"));
        }

        //[HttpGet("declaracion")]
        //public async Task<IActionResult> GetDeclaracion(string curp)
        //{
        //    return Ok(await _cosmosDbService.GetMultipleAsync($"SELECT * FROM c WHERE c.declaracion.situacionPatrimonial.datosGenerales.curp = \"{curp}\""));
        //}

        [HttpGet("declaracion")]
        public async Task<IActionResult> GetDeclaracion(string id)
        {
            return Ok(await _cosmosDbService.GetMultipleAsync($"SELECT * FROM c WHERE c.id = \"{id}\""));
        }

        [HttpGet("lista")]
        public async Task<IActionResult> GetListaDeclaracion(string curp)
        {
            return Ok(await _cosmosDbService.GetMultipleAsync($"SELECT c.id FROM c WHERE c.declaracion.situacionPatrimonial.datosGenerales.curp = \"{curp}\""));
        }

        [HttpGet("datosgenerales")]
        public async Task<IActionResult> GetGenerales(string id)
        {
            return Ok(await _cosmosDbService.GetMultipleAsync($"SELECT c.declaracion.situacionPatrimonial.datosGenerales FROM c WHERE c.id = \"{id}\""));
        }

        [HttpGet("ingresosindustrial")]
        public async Task<IActionResult> GetIIndustial(string id)
        {
            return Ok(await _cosmosDbService.GetMultipleAsync($"SELECT c.declaracion.situacionPatrimonial.ingresos.actividadIndustrialComercialEmpresarial FROM c WHERE c.id = \"{id}\""));
        }

        [HttpGet("ingresosfinanciera")]
        public async Task<IActionResult> GetIFinanciera(string id)
        {
            return Ok(await _cosmosDbService.GetMultipleAsync($"SELECT c.declaracion.situacionPatrimonial.ingresos.actividadFinanciera FROM c WHERE c.id = \"{id}\""));
        }

        [HttpGet("serviciosProfesionales")]
        public async Task<IActionResult> GetIProfesionales(string id)
        {
            return Ok(await _cosmosDbService.GetMultipleAsync($"SELECT c.declaracion.situacionPatrimonial.ingresos.serviciosProfesionales FROM c WHERE c.id = \"{id}\""));
        }

        [HttpGet("otrosingresos")]
        public async Task<IActionResult> GetIOtros(string id)
        {
            return Ok(await _cosmosDbService.GetMultipleAsync($"SELECT c.declaracion.situacionPatrimonial.ingresos.otrosIngresos FROM c WHERE c.id = \"{id}\""));
        }

        [HttpGet("ingresosanuales")]
        public async Task<IActionResult> GetIAnuales(string id)
        {
            string declaracion = "MODIFICACIÓN";
            return Ok(await _cosmosDbService.GetMultipleAsync($"SELECT  c.declaracion.situacionPatrimonial.ingresos FROM c WHERE c.id = \"{id}\""));
        }

        [HttpGet("inmuebles")]
        public async Task<IActionResult> GetInmuebles(string id)
        {
            return Ok(await _cosmosDbService.GetMultipleAsync($"SELECT c.declaracion.situacionPatrimonial.bienesInmuebles FROM c WHERE c.id = \"{id}\""));
        }
    }
}

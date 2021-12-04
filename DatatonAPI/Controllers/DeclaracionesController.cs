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

        [HttpGet("declaracion")]
        public async Task<IActionResult> GetDeclaracion(string curp)
        {
            return Ok(await _cosmosDbService.GetMultipleAsync($"SELECT * FROM c WHERE c.declaracion.situacionPatrimonial.datosGenerales.curp = \"{curp}\""));
        }
    }
}

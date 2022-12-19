using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MinimalJwt.Models;
using MinimalJwt.Repositories;
using MinimalJwt.Repositories.Contracts;
using MinimalJwt.Services;

namespace MinimalJwt.Controllers
{
    [ApiController]
    [Route("api/[controller]/")]
    public class AssociadoController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IAssociadoRepository _associados;
        

        public AssociadoController(IConfiguration configuration, IAssociadoRepository associados) 
        {
            _configuration = configuration;
            _associados = associados;
        }

        [HttpGet]       
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]       
        public IActionResult Get() 
        {
            IEnumerable<Associado> associados = _associados as IEnumerable<Associado>;
            try
            {
                return Ok("Funciona");
            }
            catch (Exception ex) 
            {
                return BadRequest(ex.Message);
            }
        }


    }
}

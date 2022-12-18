using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MinimalJwt.Models;
using MinimalJwt.Repositories;
using MinimalJwt.Services;

namespace MinimalJwt.Controllers
{
    [ApiController]
    [Route("api/[controller]/")]
    public class AssociadoController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly AssociadoRepository _associados;

        public AssociadoController(IConfiguration configuration, AssociadoRepository associados) 
        {
            _configuration = configuration;
            _associados = associados;
        }

        [HttpGet]
        //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public IActionResult Get() 
        {
            try
            {
                return Ok(_associados);
            }
            catch (Exception ex) 
            {
                return BadRequest(_associados);
            }
        }


    }
}

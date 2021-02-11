using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("/")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() => Ok("OK");


        [HttpPost]
        public IActionResult Post(UsuarioDTO usuario)
        {
            //TODO:Processar usuário
            return Ok();
        }

        [HttpPut("{codigoUsuario}")]
        public IActionResult Put([FromRoute]int codigoUsuario, [FromBody]UsuarioDTO usuario)
        {
            if (codigoUsuario <= 0)
                return BadRequest();

            return Ok();
        }

        [HttpDelete("{codigoUsuario}")]
        public IActionResult Delete(int codigoUsuario)
        {
            if (codigoUsuario <= 0)
                return BadRequest(new { messagem = "Código de usuário inválido" });

            return Ok(new { messagem = "Deletado com sucesso" });
        }
    }
}

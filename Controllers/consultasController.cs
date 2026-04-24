using DocMais.DATA;
using DocMais.MODEL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DocMais.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class consultasController : ControllerBase
    {
        private CLINICACONTEX _Context;
        public consultasController(CLINICACONTEX contex)
        {
            contex = contex;
        }
        [HttpPost("cadastrar consultas")]
        public async Task<IActionResult> consultasmedicas(string crm)
        {
            try
            {
                MedicoModel? medicoentrado = await _Context.medicos.FindAsync(crm);
                return Created();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("listaconsultas")]
        public async Task<IActionResult> listaconsultas(string crm)
        {
            return Ok(crm);
        }
        [HttpPut("editarconsultas")]
        public async Task<IActionResult> editarconsultas(string crm)
        {
            foreach (var medico in _Context.medicos)
            {
                if (medico.crm == crm)
                {
                    medico.crm = crm;
                    medico.nome = medico.nome;
                    medico.telefone = medico.telefone;
                    medico.email = medico.email;
                    medico.datanascimento = medico.datanascimento;
                    medico.crm = crm;
                    return Created();
                }
            }
            return Ok();
        }
    }
}





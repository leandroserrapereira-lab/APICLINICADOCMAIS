using DocMais.DATA;
using DocMais.MODEL;
using DocMais.SERVICES;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace DocMais.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MedicoController : Controller

    {
        private CLINICACONTEX _Context;


        public MedicoController(CLINICACONTEX contex)
        {
            _Context = contex;
        }

        [HttpPost("cadastrarmedico/{crm}")]
        public async Task<IActionResult> buscarmedico(string crm)
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
        
        [HttpPut(" editarmedico")]
        public async Task<IActionResult> editarmedico(string crm)
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



















using DocMais.DATA;
using DocMais.MODEL;
using DocMais.SERVICES;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
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
        [HttpGet(("deletarmedico"))]
        public async Task<IActionResult> deletarmedico(string cpf)
        {
            try
            {
                MedicoModel? Medicoencontrado = await _Context.medicos.FindAsync(cpf);
                if (Medicoencontrado != null)
                {
                    _Context.medicos.Remove(Medicoencontrado);
                    await _Context.SaveChangesAsync();
                    return NoContent();
                }
                else
                {
                }
                throw new Exception($"médico de cpf: {cpf} não existe");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("listamedicos")]
        public async Task<IActionResult> listarmedicos(string crm)
        {
            try
            {
                var listamedico = await _Context.medicos.ToListAsync();

            }
            catch (Exception ex)
            {
                return BadRequest("erro." + ex.Message);
            }
            return Ok();

        }

    }
}



































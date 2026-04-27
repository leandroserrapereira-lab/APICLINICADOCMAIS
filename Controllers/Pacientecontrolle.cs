using DocMais.DATA;
using DocMais.MODEL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace DocMais.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class Pacientecontrolle : ControllerBase
    {
        public static List<PacienteModel> listaPaciente = new List<PacienteModel>();


        private CLINICACONTEX _Context;

        public Pacientecontrolle(CLINICACONTEX context)
        {
            _Context = context;
        }

        //cadastrarPaciente
        [HttpPost("cadastrarpaciente")]
        public async Task<IActionResult> CadastrarPaciente([FromBody] PacienteModel pacienteCadastrado)
        {
            try
            {
                _Context.Add(pacienteCadastrado);
                await _Context.SaveChangesAsync();
                return Created();
            }
            catch (Exception ex)
            {
                return BadRequest("Erro Inesperado: " + ex.Message);
            }
        }

        [HttpGet("listarpacientes")]
        public List<PacienteModel> listarPaciente()
        {
            return listaPaciente;
        }

        [HttpGet("buscaPaciente/{nome}")]

        public async Task<IActionResult> buscarPaciente(string nome)
        {
            try
            {
                _Context.pacientes.Where(p => p.nome == nome).ToList();
                await _Context.SaveChangesAsync();
                return Created();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }

        [HttpPut("editarPaciente/{cpf}")]
        public async Task<IActionResult> editarPaciente([FromBody] PacienteModel pacienteEditado, string cpf)
        {
            try
            {
                _Context.pacientes.Update(pacienteEditado);
                await _Context.SaveChangesAsync();
                return Ok(pacienteEditado);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);


            }
        }

        [HttpDelete("deletarPaciente/{cpf}")]
        public async Task<IActionResult> deletarPaciente(string cpf)

        {
            try
            {
                PacienteModel? pacienteEncontrado = await _Context.pacientes.FindAsync(cpf);


                if (pacienteEncontrado != null)
                {
                    _Context.pacientes.Remove(pacienteEncontrado);
                    await _Context.SaveChangesAsync();
                    return NoContent();
                }
                else
                {
                }
                throw new Exception($"paciente de cpf: {cpf} não existe");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}















        
            
              
            


          

      




       

       
    











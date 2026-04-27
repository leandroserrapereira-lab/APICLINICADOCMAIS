using DocMais.DATA;
using DocMais.DTO;
using DocMais.Model;
using DocMais.MODEL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Crmf;

namespace DocMais.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AGENDAMENTOCONTROLLER : ControllerBase

    {
        private CLINICACONTEX _context;

        public static List<AGENDAMENTOMODEL> listaagendamento = new List<AGENDAMENTOMODEL>();
        [HttpPost("agendarconsulta")]
        public async Task<IActionResult> AgendarConsulta([FromBody] AGENDAMENTODTO dadosagendamento)
        {
            try
            {
                AGENDAMENTOMODEL agendamento = new AGENDAMENTOMODEL();
                agendamento.datahoraagendada = dadosagendamento.datahoraagendada;
                agendamento.crmmedico = dadosagendamento.crmMedico;
                agendamento.cpfpaciente = dadosagendamento.cpfpaciente;

                _context.aGENDAMENto.Add(agendamento);


                listaagendamento.Add(agendamento);
                return Created();


                return Created();
            
            }
            catch (Exception ex)
            {
                return BadRequest("Erro: "+  ex.Message);
            }

           
        }
            
    }
}























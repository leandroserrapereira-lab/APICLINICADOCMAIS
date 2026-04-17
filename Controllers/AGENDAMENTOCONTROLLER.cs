using DocMais.DTO;
using DocMais.Model;
using DocMais.MODEL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DocMais.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AGENDAMENTOCONTROLLER : ControllerBase

    {
        public static List<AGENDAMENTOMODEL> listaagendamento = new List<AGENDAMENTOMODEL>();
        [HttpPost("agendarconsulta")]
        public async Task<IActionResult> AgendarConsulta([FromBody] AGENDAMENTODTO dadosagendamento)
        {
            try
            {
                AGENDAMENTOMODEL agendamento = new AGENDAMENTOMODEL();
                agendamento.nomepaciente = dadosagendamento.paciente?.nome;
                agendamento.telefonepaciente = dadosagendamento.paciente?.telefone;
                agendamento.cpfpaciente = dadosagendamento.paciente?.cpf;
                agendamento.nomemedico = dadosagendamento.Medico?.nome;
                agendamento.crmmedico = dadosagendamento.Medico?.crm;
                agendamento.especialidademedico = dadosagendamento.Medico?.especialidade;
                agendamento.datahoraagendamento = dadosagendamento.datahoraagendada;

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























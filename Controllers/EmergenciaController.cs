using DocMais.MODEL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace DocMais.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmergenciaController : ControllerBase
    {
        public static List<PacienteModel> listaPaciente = new List<PacienteModel>();



        [HttpGet("retornoCasa")]
        public string casa()
        {
            return "casa";
        }
        [HttpGet("nomepaciente")]
        public string paciente()
        {
            string nome = "leandro";
            return "Paciente: " + nome;
        }



        [HttpGet("listapaciente")]
        public List<string> listaNome()
        {
            List<string> listaPacientes = new List<string>();
            listaPacientes = ["LEANDRO", "Carlos", "Pedro"];
            return listaPacientes;
        }
        [HttpGet("pacientes")]
        public List<PacienteModel> listarPaciente()
        {
            PacienteModel novoPaciente = new PacienteModel("1019210", "LEANDRO", "10/04/1999", "Vermelha");

            listaPaciente.Add(novoPaciente);
            novoPaciente = new PacienteModel("1020220", "Renan", "15/03/1990", "Verde");
            listaPaciente.Add(novoPaciente);
            return listaPaciente;
        }

        [HttpGet("buscapaciente/{id}")]
        public PacienteModel? buscarpacientes()
        {
            foreach (var paciente in listaPaciente)
            {
                if (paciente.nome == paciente.nome)
                {
                    return paciente;

                }

            }
            return null;
        }

        [HttpPut("editarpaciente/{id}")]
        public string editarpaciente([FromBody] PacienteModel pacienteeditado, string id)
        {
            foreach (var paciente in listaPaciente)
            {
                if (paciente.cpf == id)
                {
                    paciente.cpf = pacienteeditado.cpf;
                    paciente.nome = pacienteeditado.nome;
                    paciente.telefone = pacienteeditado.telefone;
                    paciente.email = pacienteeditado.email;
                    paciente.prioridade = pacienteeditado.prioridade;
                    paciente.datanascimento = pacienteeditado.datanascimento;

                    paciente.endereco = pacienteeditado.endereco;
                    return $"paciente{paciente.nome}, cpf anteiro: {id} editado com sucesso";
                }
            }
            return "Paciente não encontrado";
        }

        [HttpDelete("deletarpaciente/{id}")]
        public string deletarpaciente(string id)
        {
            foreach (var paciente in listaPaciente)
            {
                if (paciente.cpf == id)
                {
                    listaPaciente.Remove(paciente);
                    return $"paciente com cpf: {id} deletado com sucesso";
                }
            }
            return "paciente não encontrado";
            

        }
    }
} 










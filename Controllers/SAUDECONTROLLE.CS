using DocMais.MODEL;
using Microsoft.AspNetCore.Mvc;

namespace DocMais.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SAUDECONTROLLE
    {
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
        public List<PACIENTE> listaPaciente()
        {
            PACIENTE novoPaciente = new PACIENTE("1019210", "LEANDRO", "10/04/1999", "Vermelha");
            List<PACIENTE> listaPaciente = new List<PACIENTE>();
            listaPaciente.Add(novoPaciente);
            novoPaciente = new PACIENTE("1020220", "Renan", "15/03/1990", "Verde");
            listaPaciente.Add(novoPaciente);
            return listaPaciente;
        }
    }

}









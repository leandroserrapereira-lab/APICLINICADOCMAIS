using DocMais.MODEL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DocMais.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class consultasController : ControllerBase
    {
        [HttpGet("consulta")]
        public string consulta()
        {
            return "consulta";
        }

        [HttpGet("atendidoshoje")]
        public List<string> pacienteatendidoshoje()
        {
            List<string> pacienteatendidoshoje = new List<string>();
            pacienteatendidoshoje = ["leandro", "renan", "ricardo"];
            return pacienteatendidoshoje;


        }
        [HttpGet("nomepaciente")]
        public string nome()
        {
            string nome = "leandro";
            return nome;
        }
        [HttpGet("nomedico")]
        public string medico()
        {
            string medico = "giovani";
            return medico;
        }
        [HttpGet("consulta")]
        public int consultas()
        {
            int consultas = 0;
            return consultas;
            if (consultas == 0)
            {
                consultas = 1;
            }
            else
            {
                consultas = 2;
            }
            return consultas;
               
        }
        [HttpGet("precoconsulta")]
        public int precoconsulta()
        {
            int precoconsulta = 0;
            return precoconsulta;
            if (precoconsulta >= 0)
            {
                precoconsulta = 1;
            }
            else if (precoconsulta < 0)
            {
                precoconsulta = 2;
                return precoconsulta;
            }
         
          

       
        







        }





        }
}

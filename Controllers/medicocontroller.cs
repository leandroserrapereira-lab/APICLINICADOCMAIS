using DocMais.MODEL;
using Microsoft.AspNetCore.Mvc;

namespace DocMais.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MedicoController : Controller

    {
        public static List<MedicoModel> listamedicos = new List<MedicoModel>();


        [HttpPost("cadastromédico")]
        public string cadastromedico([FromBody] MedicoModel cadastromedico)
        {
            listamedicos.Add(cadastromedico);
            return $" Dr.{cadastromedico.nome} cadastro com sucesso";

        }
        [HttpGet("listamedicos")]
        public List<MedicoModel> listarmedico()
        {
            return listamedicos;

        }

        [HttpPut("editarmedico/{id}")]
        public string editamedico([FromBody] MedicoModel medicoeditado, string id)
        {
            foreach (var medicomodel in listamedicos)
            {
                if (medicomodel.nome == id)
                {
                    medicomodel.crm = medicoeditado.crm;
                    medicomodel.nome = medicoeditado.nome;
                    medicomodel.telefone = medicoeditado.telefone;
                    medicomodel.email = medicoeditado.email;
                    medicomodel.endereco = medicoeditado.endereco;
                    medicomodel.datanascimento = medicoeditado.datanascimento;
                    medicomodel.prioridade = medicoeditado.prioridade;
                    medicomodel.endereco = medicoeditado.endereco;
                    return $"medicoeditado{medicoeditado.nome}";
                }
            }
            return "médico não editado";
        }

        [HttpDelete("deletarmedico/{id}")]
        public string deletarmedico(string id)
        {
            foreach (var medicomodel in listamedicos)
            {
                if (medicomodel.crm == id)
                {
                    listamedicos.Remove(medicomodel);
                    return $" deletarmedic: {id} deletado com sucesso";
                }
            }
            return "medico não econtrado";

        }
       
               
            
          





    }
}    
using Microsoft.AspNetCore.Mvc;

namespace DocMais.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class medicocontroller : Controller

    {

       public static List<medicocontroller> List { get; set; }
       {
        public static List<medicocontroller>listamedicos = new List<medicocontroller>();
        [HttpPost("cadastromédico")]
        public string cadastromedico([FromBody] string cadastromedico)
        {
            medicocontroller medicocadastro = new medicocontroller();
            
            listamedicos.Add(medicocadastro);
            return "DR {nomemedico} cadastrado  com sucesso");
        }
       
    }
}

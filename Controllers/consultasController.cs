using DocMais.MODEL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DocMais.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class consultasController : ControllerBase
    {
        [HttpGet("atendidoshoje")]
        public List<string> pacienteatendidoshoje()
        {
            List<string> pacienteatendidoshoje = new List<string>();
            pacienteatendidoshoje = ["leandro", "renan", "ricardo"];
            return pacienteatendidoshoje;


        }
    }
}

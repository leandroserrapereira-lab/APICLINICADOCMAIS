using DocMais.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DocMais.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ViaCepController : ControllerBase
    {
        [HttpGet("{cep}")]
        public async Task<IActionResult> BuscarEndereco(string cep)
        {
            var client = new HttpClient();
            var response = await client.GetAsync($"https://viacep.com.br/ws/{cep}/json/");
            try
            {
                var endereco = await client.GetFromJsonAsync<viaCepmodel>("url");
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"erro inseperado: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("tenataiva de busca finalizada");
            }
            if (response.IsSuccessStatusCode)

            {
                var content = await response.Content.ReadFromJsonAsync<viaCepmodel>();
                if (content.cep == null)
                {
                    return NotFound(" cep não encontrado");
                }
                return Ok(content);
            }
            else return NotFound(" cep não encontrado");
            {
                return BadRequest();
            }





        }
    }
}

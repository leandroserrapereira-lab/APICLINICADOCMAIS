using System.ComponentModel.DataAnnotations;

namespace DocMais.MODEL
{
    public class PacienteModel
    {
        public string? nome { get; set; }
        [Key] public string? cpf { get; set; }
        public string? telefone { get; set; }
        public string? datanascimento { get; set; }
        
        public string? prioridade { get; set; }
        public string? email { get; set; }
      
      

    }
}

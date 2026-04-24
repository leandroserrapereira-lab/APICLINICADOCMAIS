using System.Security.Policy;

namespace DocMais.Model
{
    public class AGENDAMENTOMODEL
    {
        public string? id {  get; set; }
        public string? nomepaciente {  get; set; }
        public string? nomemedico { get; set; }
        public string? cpfpaciente { get; set; }
        public string? crmmedico { get; set; }
        public string? datanaciementopaciente { get; set; }
        public string? especialidademedico { get; set; }
        public string? telefonepaciente { get; set; }
        public DateTime? datahoraagendamento { get; set; }
   
        


        public  string? horaatendimento { get; set; }
        public string? dataatendimento { get; set; }
       
        public List<string>? dataatendimentos { get; set; }
        public List<string>? paaciente { get; set; }

        
    }
      
}


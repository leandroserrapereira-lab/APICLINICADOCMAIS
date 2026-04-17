using DocMais.MODEL;

namespace DocMais.DTO
{
    public class AGENDAMENTODTO
    {
        public PacienteModel? paciente { get; set; }
        public MedicoModel? Medico { get; set; }
        public DateTime? datahoraagendada { get; set; }
    }
    
}

using DocMais.MODEL;
using Microsoft.EntityFrameworkCore;
using DocMais.DATA;
using DocMais.Model;

namespace DocMais.DATA
{
    public class CLINICACONTEX : DbContext
    {

        public CLINICACONTEX(DbContextOptions<CLINICACONTEX> options) : base (options)
        {
        }

        public DbSet<PacienteModel> pacientes { get; set; }
        public DbSet<MedicoModel> medicos { get; set; }
        public DbSet<AGENDAMENTOMODEL> aGENDAMENto { get; set; }
       
    }
}
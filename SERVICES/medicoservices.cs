using DocMais.MODEL;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace DocMais.SERVICES
{
    public class MedicoServices
    {

        public static List<MedicoModel> listamedicos = new List<MedicoModel>();


        public MedicoModel editarmedico(MedicoModel mdicoeditado, string crm)
        {
            foreach (var medicomodel in listamedicos)
            {
                if (medicomodel.nome == crm)
                {
                    medicomodel.crm = mdicoeditado.crm;
                    medicomodel.nome = medicomodel.nome;
                    medicomodel.telefone = mdicoeditado.telefone;
                    medicomodel.email = mdicoeditado.email;
                    medicomodel.endereco = mdicoeditado.endereco;
                    medicomodel.datanascimento = mdicoeditado.datanascimento;
                    medicomodel.prioridade = mdicoeditado.prioridade;
                    medicomodel.endereco = mdicoeditado.endereco;
                    return medicomodel;

                }
            }
            return null;
        }
    }
}
        

        

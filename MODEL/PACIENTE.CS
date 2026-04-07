namespace DocMais.MODEL
{
    public class PACIENTE
    {
       public string ?  nome {  get; set; }
        public string? cpf { get; set; }
        public string ? telefone { get; set; }
        public string? datanascimento { get; set; }
        public string ? endereco {  get; set; }
        public  string ? prioridade { get; set; }
        public string ? email { get; set; }
        public PACIENTE(string? cpf, string? nome, string? dataNascimento, string? prioridade)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.telefone = telefone;
            this.datanascimento = datanascimento;
            this.endereco = endereco;
            this.prioridade = prioridade;
        }
        }
}

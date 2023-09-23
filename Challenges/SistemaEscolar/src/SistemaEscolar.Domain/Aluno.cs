namespace SistemaEscolar.Domain
{
    public class Aluno
    {
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public int idade { get; init; }

        public Aluno(string nome, DateTime nascimento)
        {
            Nome = nome;
            Nascimento = nascimento;
            idade = DateTime.Now.Year - nascimento.Year;
        }
    }
}

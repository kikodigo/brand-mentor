namespace Livros.Domain.Data
{
    public sealed class Autor
    {
        public string Nome { get; set; }

        public string Email { get; set; }

        public Autor(string nome)
        {
            Nome = nome;
        }
    }
}

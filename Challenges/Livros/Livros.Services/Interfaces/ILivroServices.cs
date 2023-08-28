using Livros.Domain.Data;

namespace Livros.Services.Interfaces
{
    public interface ILivroServices
    {
        public void Cadastrar(Livro livro);
        public void Alterar(long id, Livro livro);
        public List<Livro> ObterTudo();
        public Livro ObterPorNome(string nome);
        public Livro ObterPorId(long id);
    }
}

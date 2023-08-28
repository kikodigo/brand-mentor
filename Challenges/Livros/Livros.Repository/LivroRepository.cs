using Livros.Domain.Data;

namespace Livros.Repository
{
    public sealed class LivroRepository
    {
        private List<Livro> _livros;

        public LivroRepository()
        {
            _livros = new List<Livro>();
        }

        public void Adicionar(Livro livro)
        {
            _livros.Add(livro);
        }

        public List<Livro> ObterTudo()
        {
            return _livros;
        }

        public void Atualizar(long id, Livro livro)
        {
            var livroAtual = ObterPorId(id);

            if (livroAtual != null)
            {
                livroAtual.Autor = livro.Autor;
                livroAtual.Descricao = livro.Descricao;
                livroAtual.Isbn = livro.Isbn;
                livroAtual.Nome = livro.Nome;
            }
        }

        public Livro ObterPorId(long id)
        {
            var livro = _livros.SingleOrDefault(s => s.Id == id); // Linq -> Single Where Firt Last Sum Min Max Average (AVG)

            return livro;
        }

        public Livro ObterPorNome(string nome)
        {
            var livro = _livros.SingleOrDefault(s => s.Nome == nome); // Linq -> Single Where Firt Last Sum Min Max Average (AVG)

            return livro;
        }
    }
}

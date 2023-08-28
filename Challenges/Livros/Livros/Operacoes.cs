using Livros.Domain.Data;
using Livros.Services;
using Livros.Services.Interfaces;

namespace Livros
{
    public sealed class Operacoes
    {
        private IAutorServices _autorServices;
        private ILivroServices _livroServices;

        public Operacoes()
        {
            _autorServices = new AutorServices();
            _livroServices = new LivroServices();
        }

        #region Autor]

        public void CadastraAutor(string nome, string email)
        {
            var autor = new Autor(nome)
            {
                Email = email
            };

            _autorServices.Cadastrar(autor);
        }

        public Autor? ConsultaAutor(string nome)
        {
            var autor = _autorServices.Obter(nome);

            if (autor == null)
                return null;

            return autor;

        }

        public string AlterarAutor(string autorIndex, Autor autor)
        {
            var autorExistente = _autorServices.Obter(autorIndex);

            if (autorExistente == null)
                return "Autor não localizado";

            _autorServices.Alterar(autorExistente.Nome, autor);

            return "Alteração efetuada com Sucesso";
        }

        public List<Autor> ObterTudoAutor()
        {
            return _autorServices.ObterTudo();
        }

        #endregion Autor

        #region Livro

        public void CadastrarLivro(long id, string nomeLivro, string descricao, string isbn, string nomeAutor, string email)
        {
            var autor = _autorServices.Obter(nomeAutor);

            if (autor == null)
            {
                autor = new Autor(nomeAutor)
                {
                    Email = email
                };
            }

            var livro = new Livro(id, nomeLivro, isbn, autor)
            {
                Descricao = descricao
            };

            _livroServices.Cadastrar(livro);
        }

        public string AlterarLivro(long id, Livro livro)
        {

            var livroExistente = _livroServices.ObterPorId(id);

            if (livroExistente == null)
                return "Autor não localizado";

            _livroServices.Alterar(livroExistente.Id, livro);

            return "Alteração efetuada com Sucesso";
        }

        public Livro? ConsultaLivro(long id)
        {
            var livro = _livroServices.ObterPorId(id);

            if (livro == null)
                return null;

            return livro;
        }

        public Livro? ConsultaLivro(string nome)
        {
            var livro = _livroServices.ObterPorNome(nome);

            if (livro == null)
                return null;

            return livro;
        }

        public List<Livro> ObterTudoLivros()
        {
            return _livroServices.ObterTudo();
        }

        #endregion Livros
    }
}

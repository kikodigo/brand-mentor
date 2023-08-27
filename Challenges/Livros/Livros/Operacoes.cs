using Livros.Domain.Data;
using Livros.Services;
using Livros.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        #region Autor
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

            _autorServices.Alterar(autor);

            return "Alteração efetuada com Sucesso";
        }

        public List<Autor> Listar() 
        {
            return _autorServices.Listar();
        }
        #endregion Autor

        #region Livro

        public void CadastrarLivro(long id, string nomeLivro, string Descricao, string isbn, string nomeAutor, string email)
        {
            var autor = _autorServices.Obter(nomeAutor);

            if (autor == null)
            {
                autor = new Autor(nomeAutor)
                {
                    Email = email
                };
            }

            var livro = new Livro(id, nomeLivro, isbn, autor);

            _livroServices.Cadastrar(livro);
        }

        public void AlterarLivro(Livro livro)
        {
            _livroServices.Alterar(livro);
        }

        #endregion Livros
    }
}

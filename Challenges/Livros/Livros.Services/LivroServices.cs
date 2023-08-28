using Livros.Domain.Data;
using Livros.Repository;
using Livros.Services.Interfaces;

namespace Livros.Services
{
    public class LivroServices : ILivroServices
    {
        private LivroRepository _livroRepository;

        public LivroServices()
        {
            _livroRepository = new LivroRepository();
        }

        public void Alterar(long id, Livro livro)
        {
            _livroRepository.Atualizar(id, livro);
        }

        public void Cadastrar(Livro livro)
        {
            _livroRepository.Adicionar(livro);
        }

        public List<Livro> ObterTudo()
        {
            return _livroRepository.ObterTudo();
        }

        public Livro ObterPorNome(string nome)
        {
            return _livroRepository.ObterPorNome(nome);
        }

        public Livro ObterPorId(long id)
        {
            return _livroRepository.ObterPorId(id);
        }
    }
}

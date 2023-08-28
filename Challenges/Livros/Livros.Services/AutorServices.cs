using Livros.Domain.Data;
using Livros.Repository;
using Livros.Services.Interfaces;

namespace Livros.Services
{
    public class AutorServices : IAutorServices
    {
        private AutorRepository _autorRepository;

        public AutorServices()
        {
            _autorRepository = new AutorRepository();
        }

        public void Alterar(string autorIndex, Autor autor)
        {
            _autorRepository.Atualiar(autorIndex, autor);
        }

        public void Cadastrar(Autor autor)
        {
            _autorRepository.Adicionar(autor);
        }

        public List<Autor> ObterTudo()
        {
            return _autorRepository.ObterTudo();
        }

        public Autor Obter(string nome)
        {
            return _autorRepository.Obter(nome);
        }
    }
}
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

        public void Alterar(Autor autor)
        {
            _autorRepository.Atualiar(autor);
        }

        public void Cadastrar(Autor autor)
        {
            _autorRepository.Adicionar(autor);
        }

        public List<Autor> Listar() 
        {
            return _autorRepository.Listar();
        }

        public Autor Obter(string nome)
        {
            return _autorRepository.Obter(nome);
        }
    }
}
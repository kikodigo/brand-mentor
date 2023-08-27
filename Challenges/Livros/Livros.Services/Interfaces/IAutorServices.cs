using Livros.Domain.Data;

namespace Livros.Services.Interfaces
{
    public interface IAutorServices
    {
        public void Cadastrar(Autor autor);
        public void Alterar(Autor autor);
        public Autor Obter(string nome);
        public List<Autor> Listar();
    }
}

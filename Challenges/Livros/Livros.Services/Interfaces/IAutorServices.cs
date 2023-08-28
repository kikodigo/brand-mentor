using Livros.Domain.Data;

namespace Livros.Services.Interfaces
{
    public interface IAutorServices
    {
        public void Cadastrar(Autor autor);
        public void Alterar(string autorIndex, Autor autor);
        public Autor Obter(string nome);
        public List<Autor> ObterTudo();
    }
}

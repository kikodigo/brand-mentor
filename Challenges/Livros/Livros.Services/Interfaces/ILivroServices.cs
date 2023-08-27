using Livros.Domain.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livros.Services.Interfaces
{
    public interface ILivroServices
    {
        public void Cadastrar(Livro livro);
        public void Alterar(Livro livro);
    }
}

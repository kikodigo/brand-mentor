using Livros.Domain.Data;
using Livros.Repository;
using Livros.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livros.Services
{
    public class LivroServices : ILivroServices
    {
        private LivroRepository _livroRepository;

        public LivroServices()
        {
            _livroRepository = new LivroRepository();   
        }

        public void Alterar(Livro livro)
        {
            _livroRepository.Atualizar(livro);
        }

        public void Cadastrar(Livro livro)
        {
            _livroRepository.Adicionar(livro);  
        }
    }
}

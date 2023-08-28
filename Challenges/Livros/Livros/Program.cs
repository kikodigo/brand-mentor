using Livros;
using Livros.Domain.Data;

var operacoes = new Operacoes();

/*
 *  1 - Cadastrar Autor
 *  2 - Alterar Autor
 *  3 - Cadastrar Livro
 *  4 - Alterar Livro   
 *  5 - Sair
 */


try
{
    int op;

    do
    {
        MenuConstruction("BEM VINDO AO SISTEMA DOS LIVROS!");
        Console.WriteLine("Informe a opção desejada\n" +
            "1 - Menu do Autor\n" +
            "2 - Menu do Livro\n" +
            "0 - Encerrar o sistema");
        op = int.Parse(Console.ReadLine());

        switch (op)
        {
            case 1:
                {
                    MenuAutor();
                    break;
                }
            case 2:
                {
                    MenuLivros();
                    break;
                }
            case 0:
                {
                    return;
                }
            default:
                Console.WriteLine("Opção Invalida!");

                Thread.Sleep(1000);
                break;
        }

    } while (op != 0);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message.ToString());
    throw;
}

void MenuAutor()
{
    int opMenu;
    do
    {
        MenuConstruction("Menu do Autor!");

        Console.WriteLine($"Informe a opção desejada \n" +
            $"1 - Cadastrar Autor\n" +
            $"2 - Consultar Autor\n" +
            $"3 - Alterar Autor\n" +
            $"0 - Menu Inicial");

        opMenu = int.Parse(Console.ReadLine());

        switch (opMenu)
        {
            case 1:
                CadastraAutor();
                break;

            case 2:
                ConsultarAutor();
                break;

            case 3:
                AlterarAutor();
                break;

            case 0:
                return;

            default:
                Console.WriteLine("Opção Invalida!");
                Thread.Sleep(1000);
                break;
        }
    } while (opMenu != 0);
}

void MenuLivros()
{
    int opMenu;
    do
    {
        MenuConstruction("Menu do Livro!");

        Console.WriteLine($"Informe a opção desejada \n" +
            $"1 - Cadastrar Livro\n" +
            $"2 - Alterar Livro\n" +
            $"3 - Consultar Livro por ID\n" +
            $"4 - Consultar Livro por Nome\n" +
            $"0 - Menu Inicial");
        opMenu = int.Parse(Console.ReadLine());

        switch (opMenu)
        {
            case 1:
                CadastraLivro();
                break;

            case 2:
                AlterarLivro();
                break;

            case 3:
                ConsultarLivroPorId();
                break;

            case 4:
                ConsultarLIvroPorNome();
                break;

            case 5:
                ListarLivros();
                break;

            default:
                Console.WriteLine("Opção Invalida!");
                break;
        }
    } while (opMenu != 0);
}

void CadastraAutor()
{
    MenuConstruction("Cadastro de Autor");

    Console.WriteLine("Informe o nome do autor:");
    var nome = Console.ReadLine();

    Console.WriteLine("Informe o e-mail do autor:");
    var email = Console.ReadLine();

    operacoes.CadastraAutor(nome, email);

    Loading();
}

void ConsultarAutor()
{
    MenuConstruction("Consulta de Autor");

    Console.WriteLine("Informe o nome do Autor que deseja consultar:");
    var nome = Console.ReadLine();
    var autor = operacoes.ConsultaAutor(nome);

    if (autor != null)
    {
        Console.WriteLine($"Nome: {autor.Nome}\n" +
                          $"E-mail: {autor.Email}\n");
    }
    else
    {
        Console.WriteLine("Autor não localizado!\n");
    }

    Pause();
}

void AlterarAutor()
{
    MenuConstruction("Alteração de Autor");

    var listaAutores = operacoes.ObterTudoAutor();
    foreach (var autor in listaAutores)
    {
        Console.WriteLine($"Nome: {autor.Nome}\n" +
            $"E-mail:{autor.Email}\n");
    }

    Console.WriteLine("Informe o nome do Autor acima que deseja alterar:");
    var nomeIndex = Console.ReadLine();

    Console.WriteLine("Agora informe o novo nome:");
    var novoNome = Console.ReadLine();

    Console.WriteLine("Informe o novo e-maio:");
    var novoEmail = Console.ReadLine();

    var novoAutor = new Autor(novoNome)
    {
        Email = novoEmail
    };

    var result = operacoes.AlterarAutor(nomeIndex, novoAutor);

    Console.WriteLine(result);
    Loading();

}

void CadastraLivro()
{
    MenuConstruction("Cadastro de Livro");

    Console.WriteLine("Informe o ID do Livro:");
    long id = long.Parse(Console.ReadLine());

    Console.WriteLine("Informe o Nome do Livro:");
    string nomeLivro = Console.ReadLine();

    Console.WriteLine("Informe a ISBN do Livro:");
    string isbn = Console.ReadLine();

    Console.WriteLine("Informe a Descrição do Livro:");
    string descricao = Console.ReadLine();

    Console.WriteLine("Informe Nome do Autor do Livro:");
    string nomeAutor = Console.ReadLine();

    Console.WriteLine("Informe o E-mail do Autor do Livro:");
    var emailAutor = Console.ReadLine();

    operacoes.CadastrarLivro(id, nomeLivro, descricao, isbn, nomeAutor, emailAutor);
    Loading();

}
void AlterarLivro()
{
    MenuConstruction("Alteração de Livro");

    var livros = operacoes.ObterTudoLivros();

    foreach (var livro in livros)
    {
        Console.WriteLine($"Nome do Livro: {livro.Nome}\n" +
            $"Id: {livro.Id}\n");
    }

    Console.WriteLine("Informe o ID do livro que deseja alterar:");
    long id = long.Parse(Console.ReadLine());

    var livroAtual = operacoes.ConsultaLivro(id);
    if (livroAtual != null)
    {
        Console.WriteLine($"Dados Atuais do livro!\n" +
       $"Id: {livroAtual.Id}\n" +
       $"Nome: {livroAtual.Nome}\n" +
       $"Descrição: {livroAtual.Descricao}\n" +
       $"ISBN: {livroAtual.Isbn}\n" +
       $"Autor: {livroAtual.Autor.Nome}\n" +
       $"E-mail Autor: {livroAtual.Autor.Email}");
    }
    else
    {
        Console.WriteLine($"Id {id} informado não corresponde a nenhum livro");
        Pause();
        return;
    }


    Console.WriteLine("Deseja alterar alguma informação, 1 - Sim | Qualquer tecla para cancelar");
    int op = int.Parse(Console.ReadLine());
    if (op == 1)
    {
        Console.WriteLine("Informe os novos dados a serem alterados. Mantenha em branco as informações que não serão alteradas.");

        Console.WriteLine("Informe o Nome do Livro:");
        string nomeLivro = Console.ReadLine();

        Console.WriteLine("Informe a ISBN do Livro:");
        string isbn = Console.ReadLine();

        Console.WriteLine("Informe a Descrição do Livro:");
        string descricao = Console.ReadLine();

        Console.WriteLine("Informe Nome do Autor do Livro:");
        string nomeAutor = Console.ReadLine();

        Console.WriteLine("Informe o E-mail do Autor do Livro:");
        var emailAutor = Console.ReadLine();


        var livroAlteracao = new Livro
            (
                livroAtual.Id,
                !string.IsNullOrWhiteSpace(nomeLivro) ? nomeLivro : livroAtual.Nome,
                !string.IsNullOrWhiteSpace(isbn) ? isbn : livroAtual.Isbn,
                new Autor(!string.IsNullOrWhiteSpace(nomeAutor) ? nomeAutor : livroAtual.Autor.Nome)
                {
                    Email = !string.IsNullOrWhiteSpace(emailAutor) ? emailAutor : livroAtual.Autor.Email
                }
            )
        {
            Descricao = !string.IsNullOrWhiteSpace(descricao) ? descricao : livroAtual.Descricao
        };

        operacoes.AlterarLivro(livroAtual.Id, livroAlteracao);

        Loading();
    }
    else
    {
        Console.WriteLine("Operação Cancelada");
        Pause();
    }
}

void ConsultarLivroPorId()
{
    MenuConstruction("Consulta de Livro Por ID");

    Console.WriteLine("Informe o ID do livro que deseja Consultar:");
    long id = long.Parse(Console.ReadLine());

    var livroAtual = operacoes.ConsultaLivro(id);
    if (livroAtual != null)
    {
        Console.WriteLine($"Dados Atuais do livro!\n" +
       $"Id: {livroAtual.Id}\n" +
       $"Nome: {livroAtual.Nome}\n" +
       $"Descrição: {livroAtual.Descricao}\n" +
       $"ISBN: {livroAtual.Isbn}\n" +
       $"Autor: {livroAtual.Autor.Nome}\n" +
       $"E-mail Autor: {livroAtual.Autor.Email}");

        Pause();
    }
    else
    {
        Console.WriteLine($"Id {id} informado não corresponde a nenhum livro");
        Pause();
        return;
    }
}

void ConsultarLIvroPorNome()
{
    MenuConstruction("Consulta de Livro Por Nome");


    Console.WriteLine("Informe o Nome do livro que deseja alterar:");
    var nome = Console.ReadLine();

    var livroAtual = operacoes.ConsultaLivro(nome);
    if (livroAtual != null)
    {
        Console.WriteLine($"Dados Atuais do livro!\n" +
       $"Id: {livroAtual.Id}\n" +
       $"Nome: {livroAtual.Nome}\n" +
       $"Descrição: {livroAtual.Descricao}\n" +
       $"ISBN: {livroAtual.Isbn}\n" +
       $"Autor: {livroAtual.Autor.Nome}\n" +
       $"E-mail Autor: {livroAtual.Autor.Email}");

        Pause();
    }
    else
    {
        Console.WriteLine($"Id {nome} informado não corresponde a nenhum livro");
        Pause();
        return;
    }
}

void ListarLivros()
{
    var livros = operacoes.ObterTudoLivros();

    foreach (var livro in livros)
    {
        Console.WriteLine($"Dados Atuais do livro!\n" +
      $"Id: {livro.Id}\n" +
      $"Nome: {livro.Nome}\n" +
      $"Descrição: {livro.Descricao}\n" +
      $"ISBN: {livro.Isbn}\n" +
      $"Autor: {livro.Autor.Nome}\n" +
      $"E-mail Autor: {livro.Autor.Email}");
    }

    Pause();
}

void MenuConstruction(string menuName)
{
    var countLengthMenuName = menuName.Length;

    var asterisk = string.Empty.PadLeft(countLengthMenuName, '*');
    Console.Clear();

    Console.WriteLine(asterisk);
    Console.WriteLine(menuName);
    Console.WriteLine(asterisk + "\n");
}

void Pause()
{
    Console.WriteLine("Pressione qualquer tecla para seguir...");
    Console.ReadLine();
}

void Loading()
{
    Console.WriteLine("Processando... Aguarde!");
    Thread.Sleep(2000);
    Console.WriteLine("Processo Concluido");
    Thread.Sleep(1000);
    Pause();
}

using Livros;
using Livros.Domain.Data;
using System.IO.Pipes;

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
                //listar Livro
                break;

            default:
                Console.WriteLine("Opção Invalida!");
                break;
        }
    } while (opMenu != 0);
}

void CadastraAutor()
{
    Console.WriteLine("Informe o nome do autor");
    var nome = Console.ReadLine();
    Console.WriteLine("Informe o e-mail do autor");
    var email = Console.ReadLine();
    operacoes.CadastraAutor(nome, email);
}

void ConsultarAutor()
{
    Console.WriteLine("Informe o nome do Autor que deseja alterar.");
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

    Console.WriteLine("Pressione qualquer tecla para seguir");
    Console.ReadLine();
}
void AlterarAutor()
{
    var listaAutores = operacoes.Listar();
    foreach (var autor in listaAutores)
    {
        Console.WriteLine($"Nome: {autor.Nome}\n" +
            $"E-mail:{autor.Email}\n");
    }

    Console.WriteLine("Informe o nome do Autor acima que deseja alterar.");
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
}

void CadastraLivro()
{

}
void AlterarLivro()
{

}
// Autor At
// Livro Cad 
// Livro At

// Depois da Operação Efetuada -> volto para o menu inicial

void MenuConstruction(string menuName)
{
    var countLengthMenuName = menuName.Length;

    var asterisk = string.Empty.PadLeft(countLengthMenuName, '*');
    Console.Clear();

    Console.WriteLine(asterisk);
    Console.WriteLine(menuName);
    Console.WriteLine(asterisk + "\n");
}
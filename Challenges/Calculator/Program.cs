try
{
    Console.WriteLine("Bem vindo ao Calculator Challenges!");
    var repeat = 0;

    do
    {
        Console.WriteLine("Informe uma operação Desejada \n" +
                          "1 - Somar \n" +
                          "2 - Subtrair \n" +
                          "3 - Multiplicar \n" +
                          "4 - Dividir \n" +
                          "5 - Resto de uma Divisão \n" +
                          "6 - Potenciação \n" +
                          $"0 - Sair de Calculator");

        int.TryParse(Console.ReadLine(), out int option);

        Console.Clear();

        if (option == 0)
            return;

        Console.WriteLine("Digite o primeiro valor: ");
        int.TryParse(Console.ReadLine(), out int n1);

        Console.WriteLine("Digite o segundo valor: ");
        int.TryParse(Console.ReadLine(), out int n2);

        double result = 0;

        switch (option)
        {
            case 1:
                result = Sum(n1, n2);
                break;

            case 2:
                result = Subtract(n1, n2);
                break;

            case 3:
                result = Multiply(n1, n2);
                break;

            case 4:
                result = Division(n1, n2);
                break;

            case 5:
                result = RestOfDivision(n1, n2);
                break;

            case 6:
                result = Potentiation(n1, n2);
                break;

            case 0:
                return;
                break;

            default:
                Console.WriteLine("Opção invalida");
                break;
        }

        Console.WriteLine($"Resultado igual a {result}");

        Console.WriteLine("Informe 1 caso queira efetuar outra operação.");

        int.TryParse(Console.ReadLine(), out repeat);

        Console.Clear();

    } while (repeat == 1);

}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
    Console.WriteLine(ex.Message);
    Thread.Sleep(1000);

    throw;
}
int Sum(int n1, int n2)
{
    return n1 + n2;
}

int Subtract(int n1, int n2)
{
    return n1 - n2;
}

int Multiply(int n1, int n2)
{
    return n1 * n2;
}

double Division(int n1, int n2)
{
    return n1 / n2;
}

int RestOfDivision(int n1, int n2)
{
    return n1 % n2;
}

double Potentiation(double n1, double n2)
{
    return Math.Pow(n1, n2);
}
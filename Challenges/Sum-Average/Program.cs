try
{
    Console.WriteLine("Olá, bem vindo ao sistema de média e somatório de lista de valores.");
    Thread.Sleep(1000);
    Console.Clear();

    Console.WriteLine("Inicialmente por favor me informe a quantidade de numeros que precisa calcular.");
    Console.WriteLine("Valor deve ser entre 3 e 10.");

    var sizeList = ReadSizeList();
    double[] numberList = new double[sizeList];

    for (int i = 0; i < sizeList; i++)
    {
        Console.WriteLine($"Digite o número {i + 1}:");
        numberList[i] = ReadNumber();
    }

    var sumResult = Calculator.Bla(numberList);

}
catch (Exception ex)
{
    Console.WriteLine("Infelizmente o sisteme encontrou um erro, analise as mensagens abaixo.");
    Console.WriteLine(ex.ToString());
    Console.WriteLine(ex.Message);
    Thread.Sleep(1000);
    throw;
}

static int ReadSizeList()
{
    int size;
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out size) && size >= 3 && size <= 10)
        {
            return size;
        }
        else
        {
            Console.WriteLine("Quantidade inválida. Digite um número entre 3 e 10.");
        }
    }
}

static double ReadNumber()
{
    double number;
    while (true)
    {
        if (double.TryParse(Console.ReadLine(), out number))
        {
            return number;
        }
        else
        {
            Console.WriteLine("Número inválido. Digite um valor numérico válido.");
        }
    }
}

public sealed class Calculator
{

    public double Bla(double[] numeros)
    {
        return numeros.Sum();
    }

    public double Average(double[] numeros)
    {
        return numeros.Average();
    }
}

using Exercicio4;

try
{
    DateTime temp;
    DateTime data = new DateTime(2012, 07, 4, 10, 15, 30);

    if (DateTime.TryParse(data.ToString(), out temp))
    {
        var valor = MetodoExtensao.FormatoAnoMes(data);
        Console.WriteLine(valor);
    }
    else
    {
        Console.WriteLine("Data inválida");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

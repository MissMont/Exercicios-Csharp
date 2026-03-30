using System;
using System.Globalization;

enum Moeda{
    Real = 1,
    Dolar = 2,
    Euro = 3,
    Iene = 4,
    Libra = 5
}

class Program{
    static decimal TaxaParaReal(Moeda moeda){
        return moeda switch{
            Moeda.Real => 1m,
            Moeda.Dolar => 4.50m,
            Moeda.Euro => 6.20m,
            Moeda.Iene => 0.052m,
            Moeda.Libra => 6.95m,
            _ => 1m
        };
    }

    static decimal Converter(decimal valor, Moeda origem, Moeda destino){
        decimal valorEmReal = valor * TaxaParaReal(origem);
        decimal valorConvertido = valorEmReal / TaxaParaReal(destino);
        return Math.Round(valorConvertido, 2);
    }

    static CultureInfo ObterCultura(Moeda moeda){
        return moeda switch{
            Moeda.Real => new CultureInfo("pt-BR"),
            Moeda.Dolar => new CultureInfo("en-US"),
            Moeda.Euro => new CultureInfo("fr-FR"),
            Moeda.Iene => new CultureInfo("ja-JP"),
            Moeda.Libra => new CultureInfo("en-GB"),
            _ => new CultureInfo("pt-BR")
        };
    }

    static void Main(){
        Console.WriteLine(" ====== Conversor de Moedas =====\n");

        Console.Write("Digite o valor: ");
        decimal valor = decimal.Parse(Console.ReadLine());

        Console.WriteLine("\nMoeda de origem:");
        foreach (Moeda m in Enum.GetValues(typeof(Moeda))){
            Console.WriteLine($"{(int)m} - {m}");
        }

        Console.Write("Escolha: ");
        Moeda origem = (Moeda)int.Parse(Console.ReadLine());

        Console.WriteLine("\nMoeda de destino:");
        foreach (Moeda m in Enum.GetValues(typeof(Moeda))){
            Console.WriteLine($"{(int)m} - {m}");
        }

        Console.Write("Escolha: ");
        Moeda destino = (Moeda)int.Parse(Console.ReadLine());

        decimal resultado = Converter(valor, origem, destino);
        CultureInfo cultura = ObterCultura(destino);

        Console.WriteLine("\nResultado:");
        Console.WriteLine(resultado.ToString("C", cultura));
    }
}
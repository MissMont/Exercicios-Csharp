/*using System.Linq;
using System.Collections.Generic;
using System.Globalization;
 
class SomaMedia{
    static void Main(){
       
        Console.WriteLine("Quantos números deseja informar (3 a 10)?: ");
        int quantidade = int.Parse(Console.ReadLine());
 
        while (quantidade < 3 || quantidade > 10){
            Console.WriteLine("Valor inválido! Digite entre 3 e 10: ");
            quantidade = int.Parse(Console.ReadLine());
        }
 
        List<double> numeros = new List<double>();
 
        for (int i = 0; i < quantidade; i++){
            Console.Write($"Digite o número {i + 1}: ");
            {
                double numero;
                while(!double.TryParse(Console.ReadLine(), out numero))
                {
                    Console.Write("Valor inválido, digite novamente: ");
                }
               
                numeros.Add(numero);
            }
        }
 
        double soma = numeros.Sum();
        double media = numeros.Average();
 
        Console.WriteLine($"Soma: {soma}");
        Console.WriteLine($"Média: {media}");
 
    }
 
    static double CalcularSoma(List<double> lista)
    {
        double soma = 0;
        foreach (double num in lista){
 
            soma += num;
        }
        return soma;
    }
 
    static double CalcularMedia (List<double> lista){
        double soma = CalcularSoma(lista);
        return soma / lista.Count;
    }
} */
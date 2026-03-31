/*using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

enum Categoria
{
    Filme = 0,
    Jogo = 1,
    Pais = 2
}

class Palavra
{
    public string Nome { get; set; }
    public Categoria Categoria { get; set; }
}

class JogoForca
{
    private List<Palavra> palavras;
    private Palavra palavraSorteada;
    private HashSet<char> letrasUsadas = new HashSet<char>();
    private int tentativasRestantes;

    public JogoForca(int tentativas)
    {
        tentativasRestantes = tentativas;
        palavras = CarregarPalavras();
        SortearPalavra();
    }

    private List<Palavra> CarregarPalavras()
    {
        var lista = new List<Palavra>();

        var linhas = File.ReadAllLines("palavras.csv");

        foreach (var linha in linhas)
        {
            var partes = linha.Split(';');

            lista.Add(new Palavra
            {
                Nome = partes[0],
                Categoria = (Categoria)int.Parse(partes[1])
            });
        }

        return lista;
    }

    private void SortearPalavra()
    {
        Random rand = new Random();
        palavraSorteada = palavras[rand.Next(palavras.Count)];
    }

    private string RemoverAcentos(string texto)
    {
        var bytes = Encoding.GetEncoding("ISO-8859-8").GetBytes(texto);
        return Encoding.UTF8.GetString(bytes);
    }

    private string ObterPalavraOculta()
    {
        string resultado = "";

        foreach (char c in palavraSorteada.Nome)
        {
            if (char.IsWhiteSpace(c))
            {
                resultado += " ";
            }
            else if (letrasUsadas.Contains(char.ToLower(c)))
            {
                resultado += c;
            }
            else
            {
                resultado += "_";
            }
        }

        return resultado;
    }

    private bool Ganhou()
    {
        return !ObterPalavraOculta().Contains("_");
    }

    public void Iniciar()
    {
        while (tentativasRestantes > 0)
        {
            Console.Clear();

            Console.WriteLine("===== JOGO DA FORCA =====\n");
            Console.WriteLine($"Categoria: {palavraSorteada.Categoria}");
            Console.WriteLine($"Palavra: {ObterPalavraOculta()}");
            Console.WriteLine($"Tentativas restantes: {tentativasRestantes}");
            Console.WriteLine($"Letras usadas: {string.Join(", ", letrasUsadas)}");

            Console.Write("\nDigite uma letra: ");
            string entrada = Console.ReadLine().ToLower();

            if (string.IsNullOrWhiteSpace(entrada))
                continue;

            char letra = entrada[0];

            if (letrasUsadas.Contains(letra))
                continue;

            letrasUsadas.Add(letra);

            string palavraNormalizada = RemoverAcentos(palavraSorteada.Nome.ToLower());

            if (!palavraNormalizada.Contains(letra))
            {
                tentativasRestantes--;
            }

            if (Ganhou())
            {
                Console.Clear();
                Console.WriteLine("Fim de jogo, você venceu!");
                Console.WriteLine($"Palavra: {palavraSorteada.Nome}");
                return;
            }
        }

        Console.Clear();
        Console.WriteLine("Fim de jogo, você perdeu!");
        Console.WriteLine($"Palavra: {palavraSorteada.Nome}");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("===== ESCOLHA A DIFICULDADE =====");
        Console.WriteLine("1 - Fácil (7 tentativas)");
        Console.WriteLine("2 - Normal (6 tentativas)");
        Console.WriteLine("3 - Difícil (5 tentativas)");

        int opcao = int.Parse(Console.ReadLine());

        int tentativas = opcao switch
        {
            1 => 7,
            2 => 6,
            3 => 5,
            _ => 6
        };

        var jogo = new JogoForca(tentativas);
        jogo.Iniciar();
    }
}*/
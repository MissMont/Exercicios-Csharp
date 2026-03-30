/*using System;
using System.Globalization;
using static System.Console;

class DataConfiguracao
{
    public int OpcaoFormato { get; set; }

    public DataConfiguracao(int opcao)
    {
        OpcaoFormato = opcao;
    }

    public string FormatarData(DateTime data)
    {
        switch (OpcaoFormato)
        {
            case 1:
                return data.ToString();

            case 2:
                return data.ToString("dd-MM-yy");

            case 3:
                return data.ToString("dddd, d 'de' MMMM 'de' yyyy", new CultureInfo("pt-BR"));

            case 4:
                return data.ToString("dd-MM-yyyy HH:mm:ss");

            case 5:
                return data.ToString("R"); 

            case 6:
                return data.ToString("yyyy/MM/dd"); 

            case 7:
                return data.ToString("MMMM dd, yyyy", new CultureInfo("en-US"));

            case 8:
                return data.ToString("dddd, dd MMMM yyyy", new CultureInfo("fr-FR"));

            case 9:
                return data.ToString("dd 'de' MMMM yyyy HH:mm", new CultureInfo("pt-BR"));

            default:
                return data.ToString();
        }
    }

    public void ExibirCabecalho(DateTime data)
    {
        WriteLine("\n==============================");
        WriteLine($"Data do evento: {FormatarData(data)}");
        WriteLine("==============================");
    }
}

class Program{
    static void Main(){
        int opcaoFormato;

        while (true){
            WriteLine("Escolha o formato de data:");
            WriteLine("1 - Padrão do sistema");
            WriteLine("2 - Simples (08-01-21)");
            WriteLine("3 - Longo pt-BR");
            WriteLine("4 - Personalizado completo");
            WriteLine("5 - RFC1123");
            WriteLine("6 - ISO (yyyy/MM/dd)");
            WriteLine("7 - Inglês (en-US)");
            WriteLine("8 - Francês (fr-FR)");
            WriteLine("9 - PT-BR com hora");

            if (int.TryParse(ReadLine(), out opcaoFormato) && opcaoFormato >= 1 && opcaoFormato <= 9)
                break;

            WriteLine("Opção inválida. Tente novamente.\n");
        }

        DataConfiguracao config = new DataConfiguracao(opcaoFormato);

        while (true){
            WriteLine("\nEscolha um evento:");
            WriteLine("1 - ENIAC");
            WriteLine("2 - RFC1");
            WriteLine("3 - Alan Turing");
            WriteLine("0 - Sair");

            if (!int.TryParse(ReadLine(), out int opcaoEvento))
            {
                WriteLine("Entrada inválida.");
                continue;
            }

            if (opcaoEvento == 0)
                break;

            switch (opcaoEvento)
            {
                case 1:
                    MostrarEvento(
                        config,
                        new DateTime(1946, 8, 15),
                        "ENIAC",
                        "No dia 15 de agosto de 1946 foi apresentado o primeiro computador eletrônico do mundo."
                    );
                    break;

                case 2:
                    MostrarEvento(
                        config,
                        new DateTime(1969, 4, 17),
                        "RFC1",
                        "Publicação da RFC1, considerada o marco inicial da internet."
                    );
                    break;

                case 3:
                    MostrarEvento(
                        config,
                        new DateTime(1912, 6, 23),
                        "Alan Turing",
                        "Nascimento de Alan Turing, considerado o pai da computação."
                    );
                    break;

                default:
                    WriteLine("Evento inválido.");
                    break;
            }
        }

        WriteLine("\nPrograma encerrado");
    }

    static void MostrarEvento(DataConfiguracao config, DateTime data, string titulo, string descricao)
    {
        config.ExibirCabecalho(data);
        WriteLine($"Evento: {titulo}");
        WriteLine(descricao);
    }
}*/
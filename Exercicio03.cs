/*using static System.Console;

class Program
{
    static Random random = new Random();

    static void Main(){

        string jogador1 = LerNome("Insira o nome do Jogador 1: ");
        string jogador2 = LerNome("Insira o nome do Jogador 2: ");

        while (jogador1 == jogador2){
            WriteLine("Os jogadores não podem ter o mesmo nome.");
            jogador2 = LerNome("Insira outro nome para o Jogador 2: ");
        }

        int pontosJogador1 = 0;
        int pontosJogador2 = 0;
        int totalRodadas = EscolherRodada();
        int rodada = 1;

        while (rodada <= totalRodadas){
            WriteLine($"\n--- Rodada {rodada} ---");

            int dado1 = JogarDados();
            int dado2 = JogarDados();

            WriteLine($"{jogador1} tirou {dado1}");
            WriteLine($"{jogador2} tirou {dado2}");

            if (dado1 > dado2){
                WriteLine($"{jogador1} venceu a rodada {rodada}");
                pontosJogador1++;
            }else if (dado2 > dado1){
                WriteLine($"{jogador2} venceu a rodada {rodada}");
                pontosJogador2++;
            }else{
                WriteLine("Empate!");
            }

            MostrarPlacar(jogador1, jogador2, pontosJogador1, pontosJogador2);
            rodada++;
            ReadLine();
        }

        while (pontosJogador1 == pontosJogador2){
            WriteLine("\n=== Desempate! ===");

            int dado1 = JogarDados();
            int dado2 = JogarDados();

            WriteLine($"{jogador1} tirou {dado1}");
            WriteLine($"{jogador2} tirou {dado2}");

            if (dado1 > dado2){
                WriteLine($"{jogador1} venceu o desempate!");
                pontosJogador1++;
            }else if (dado2 > dado1){
                WriteLine($"{jogador2} venceu o desempate!");
                pontosJogador2++;
            }else{
                WriteLine("Empate no desempate! Jogando novamente...");
            }

            MostrarPlacar(jogador1, jogador2, pontosJogador1, pontosJogador2);
        }

        WriteLine("\n=== Resultado Final ===");

        if (pontosJogador1 > pontosJogador2){
            WriteLine($"{jogador1} venceu o jogo!");
        }else{
            WriteLine($"{jogador2} venceu o jogo!");
        }
    }

    static int JogarDados(){
        return random.Next(1, 7);
    }

    static string LerNome(string mensagem){
        WriteLine(mensagem);
        return ReadLine().ToLower();
    }

    static void MostrarPlacar(string j1, string j2, int p1, int p2){
        WriteLine($"Placar: {j1}: {p1} | {j2}: {p2}");
    }

    static int EscolherRodada(){
        int rodadas;

        do{
            WriteLine("Escolha a quantidade de rodadas (1 a 5): ");
            rodadas = int.Parse(ReadLine());
        }
        while (rodadas < 1 || rodadas > 5);

        return rodadas;
    }
}*/
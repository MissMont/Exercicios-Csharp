using static System.Console;

int valor1;
int valor2;
int operacao;

do{
    WriteLine("1 - Somar");
    WriteLine("2 - Subtrair");
    WriteLine("3 - Multiplicar");
    WriteLine("4 - Dividir");
    WriteLine("5 - Resto da Divisão");
    WriteLine("6 - Potenciação");
    WriteLine("0 - Sair");

    WriteLine("Escolha a operação desejada");
    operacao = int.Parse(ReadLine());

    if (operacao > 6 || operacao < 0)
    {
        WriteLine("Opção inválida, tente novamente.\n");
    }

} while (operacao > 6 || operacao < 0);

if (operacao == 0)
{
    WriteLine("Você saiu");
    return; 
}

WriteLine("Digite o primeiro valor: ");
valor1 = int.Parse(ReadLine());

WriteLine("Digite o segundo valor: ");
valor2 = int.Parse(ReadLine());

switch(operacao)
{
    case 1:
        WriteLine("Resultado: " + (valor1 + valor2));
        break;
    case 2:
        WriteLine("Resultado: " + (valor1 - valor2));
        break;
    case 3:
        WriteLine("Resultado: " + (valor1 * valor2));
        break;
    case 4:
        if (valor2 == 0){
        WriteLine("Não é possível dividir por zero.");
        }else{
        WriteLine("Resultado: " + (valor1 / valor2));    }
        break;
    case 5:
        WriteLine("Resto da Divisão: " + (valor1 % valor2));
        break;
    case 6:
        double resultado = Math.Pow(valor1, valor2);
        WriteLine("Resultado: " + resultado);
        break;
    default:
        WriteLine("Opção inválida");
        break;
}
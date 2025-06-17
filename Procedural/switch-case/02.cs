// 02 - Faça uma calculadora com as seguintes operações:
// 1 - Soma
// 2 - Subtração
// 3 - MulƟplicação
// 4 - Divisão
// 5 - Resto da divisão(extra)
// 6 - Potenciação(desafio)
// 7 - Radiciação(desafio)

Console.WriteLine("Escolha uma operação:");
Console.WriteLine("1 - Soma");
Console.WriteLine("2 - Subtração");
Console.WriteLine("3 - Multiplicação");
Console.WriteLine("4 - Divisão");
Console.WriteLine("5 - Resto da divisão");

int operacao = int.Parse(Console.ReadLine());   

Console.WriteLine("Digite o primeiro número: ");
double num1 = double.Parse(Console.ReadLine());  

Console.WriteLine("Digite o segundo número: ");
double num2 = double.Parse(Console.ReadLine());  

double resultado = 0;

switch (operacao) {
    case 1:
        resultado = num1 + num2;
        Console.WriteLine($"Resultado: {num1} + {num2} = {resultado}");
        break;
    case 2:
        resultado = num1 - num2;
        Console.WriteLine($"Resultado: {num1} - {num2} = {resultado}");
        break;
    case 3:
        resultado = num1 * num2;
        Console.WriteLine($"Resultado: {num1} * {num2} = {resultado}");
        break;
    case 4:
        resultado = num1 / num2;
        Console.WriteLine($"Resultado: {num1} ÷ {num2} = {resultado}");
        break;
    case 5:
        resultado = num1 % num2;
        Console.WriteLine($"Resultado: {num1} % {num2} = {resultado}");
        break;
    default:
        Console.WriteLine("Opção inválida. Por favor, escolha uma operação válida.");
        break;
}

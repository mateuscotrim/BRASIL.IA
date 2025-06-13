// 02 - Faça um algoritmo para receber um número qualquer e imprimir na tela se o número é par ou ímpar,
// posiƟvo ou negaƟvo

Console.WriteLine("Digite um número: ");
double numeroQualquer = double.Parse(Console.ReadLine());

if (numeroQualquer > 0) {
    Console.WriteLine("O número é positivo.");
} else if (numeroQualquer < 0) {
    Console.WriteLine("O número é negativo.");
} else {
    Console.WriteLine("O número é zero.");
}

if (numeroQualquer % 2 == 0) {
    Console.WriteLine("O número é par.");
} else {
    Console.WriteLine("O número é ímpar.");
}

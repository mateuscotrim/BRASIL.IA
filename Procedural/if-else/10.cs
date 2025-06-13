//  10 - Faça um algoritmo que leia três valores que representam os três lados de um triângulo e
//  verifique se são válidos, determine se o triângulo é: equilátero, isósceles ou escaleno. 

Console.WriteLine("Digite o primeiro lado do triângulo: ");
double lado1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo lado do triângulo: ");
double lado2 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o terceiro lado do triângulo: ");
double lado3 = double.Parse(Console.ReadLine());

if (lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1) {
    if (lado1 == lado2 && lado2 == lado3) {
        Console.WriteLine("O triângulo é Equilátero.");
    } else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3) {
        Console.WriteLine("O triângulo é Isósceles.");
    } else {
        Console.WriteLine("O triângulo é Escaleno.");
    }
} else {
    Console.WriteLine("Os valores fornecidos não formam um triângulo válido.");
}

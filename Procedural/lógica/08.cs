// 08 - Faça um algoritmo que leia dois valores inteiros A e B, imprima na tela o quociente e o resto da divisão
// inteira entre eles. 

Console.WriteLine("Digite o valor de A: ");
int A = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor de B: ");
int B = int.Parse(Console.ReadLine());

int quociente = A / B;
int resto = A % B;

Console.WriteLine($"O quociente de {A} dividido por {B} é: {quociente}");
Console.WriteLine($"O resto da divisão de {A} por {B} é: {resto}");

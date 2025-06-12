// 01 - Faça um algoritmo que leia os valores de A, B, C e em seguida imprima na tela a soma entre A e B é
// mostre se a soma é menor que C. 

Console.WriteLine("Digite o valor de A: ");
int A = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor de B: ");
int B = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor de C: ");
int C = int.Parse(Console.ReadLine());

int soma = A + B;

Console.WriteLine($"A soma entre A e B é: {soma}");

if (soma < C) {
    Console.WriteLine("A soma é menor que C.");
} else {
    Console.WriteLine("A soma NÃO é menor que C.");
}
 

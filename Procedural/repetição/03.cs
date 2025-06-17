// 03 - Faça um algoritmo que receba um valor inteiro e imprima na tela a sua tabuada 

Console.Write("Digite um número para ver a tabuada: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine($"Tabuada do {n}:");

for (int i = 1; i <= 10; i++) {
    Console.WriteLine($"{n} x {i} = {n * i}");
}

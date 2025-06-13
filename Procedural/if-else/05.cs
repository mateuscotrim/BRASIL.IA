// 05 - Faça um algoritmo que leia três valores inteiros diferentes e imprima na tela os valores em ordem decrescente.

Console.WriteLine("Digite o primeiro valor: ");
int A = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo valor: ");
int B = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o terceiro valor: ");
int C = int.Parse(Console.ReadLine());

if (A >= B && A >= C) {
    if (B >= C) {
        Console.WriteLine($"{A}, {B}, {C}");
    } else {
        Console.WriteLine($"{A}, {C}, {B}");
    }
} else if (B >= A && B >= C) {
    if (A >= C) {
        Console.WriteLine($"{B}, {A}, {C}");
    } else {
        Console.WriteLine($"{B}, {C}, {A}");
    }
} else {
    if (A >= B) {
        Console.WriteLine($"{C}, {A}, {B}");
    } else {
        Console.WriteLine($"{C}, {B}, {A}");
    }
}

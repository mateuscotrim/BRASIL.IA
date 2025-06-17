// 02 - Faça um algoritmo que imprima na tela a tabuada de 1 até 10. 

for (int i = 1; i <= 10; i++) {
    Console.WriteLine($"Tabuada do {i}:");
    for (int n = 1; n <= 10; n++) {
        Console.WriteLine($"{n} x {i} = {i * n}");
    }
    Console.WriteLine();
}

// 02 - Faça um algoritmo que imprima na tela a tabuada de 1 até 10. 

for (int n = 1; n <= 10; n++) {
    Console.WriteLine($"Tabuada do {n}:");
    for (int t = 1; t <= 10; t++) {
        Console.WriteLine($"{t} x {n} = {n * t}");
    }
    Console.WriteLine(); 
}

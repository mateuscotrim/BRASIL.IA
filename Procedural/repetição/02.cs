// 02 - Faça um algoritmo que imprima na tela a tabuada de 1 até 10. 

for (int i = 1; i <= 10; i++) {
    Console.WriteLine($"Tabuada do {i}:");
    for (int t = 1; t <= 10; t++) {
        Console.WriteLine($"{t} x {i} = {i * t}");
    }
    Console.WriteLine(); 
}

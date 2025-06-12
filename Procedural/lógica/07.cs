// 07 - Faça um algoritmo que mostre um valor aleatório entre 0 e 100. 

Random random = new Random();

int valorAleatorio = random.Next(0, 101);

Console.WriteLine($"Valor aleatório gerado: {valorAleatorio}");

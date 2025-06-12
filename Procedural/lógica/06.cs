// 06 - Faça um algoritmo que leia uma temperatura em Fahrenheit e calcule a temperatura correspondente
// em grau Celsius. Imprima na tela as duas temperaturas.
// Fórmula: C = (5 * (F - 32) / 9)

Console.WriteLine("Digite a temperatura em Fahrenheit: ");
double tempFahrenheit = double.Parse(Console.ReadLine());

double tempCelsius = (5 * (tempFahrenheit - 32) / 9);

Console.WriteLine($"A temperatura em Fahrenheit: {tempFahrenheit}°F");
Console.WriteLine($"A temperatura em Celsius: {tempCelsius:F2}°C");

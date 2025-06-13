// 07 - Faça um algoritmo que leia três notas obƟdas por um aluno, e imprima na tela a média das notas

Console.WriteLine("Digite a primeira nota: ");
double nota1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a segunda nota: ");
double nota2 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a terceira nota: ");
double nota3 = double.Parse(Console.ReadLine());

double media = (nota1 + nota2 + nota3) / 3;

Console.WriteLine($"A média das notas é: {media:F2}");

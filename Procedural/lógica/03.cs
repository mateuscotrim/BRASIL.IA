// 03 - Faça um algoritmo que leia um valor qualquer e imprima na tela com um reajuste de 5%. 

Console.Write("Digite um número qualquer: ");
double valor = double.Parse(Console.ReadLine());

double valorReajustado = valor + (valor * 0.05);

Console.WriteLine("O valor digitado + um reajuste de 5%: " + valorReajustado);

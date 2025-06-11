// 03 - Faça um algoritmo que leia um valor qualquer e imprima na tela com um reajuste de 5%. 

Console.Write("Digite um número qualquer: ");
double numero = double.Parse(Console.ReadLine());

double calculo = numero + (numero * 0.05);

Console.WriteLine("O valor digitado + um reajuste de 5%: " + calculo);

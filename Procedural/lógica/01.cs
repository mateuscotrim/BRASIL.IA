// 01 - Faça um algoritmo que receba um número inteiro e imprima na tela o seu antecessor e o seu sucessor. 

Console.Write("Digite um número inteiro: ");
int numero = int.Parse(Console.ReadLine());

   
int antecessor = numero - 1;
int sucessor = numero + 1;

     
Console.WriteLine($"O antecessor de {numero} é {antecessor}.");
Console.WriteLine($"O sucessor de {numero} é {sucessor}.");

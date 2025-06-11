// 04 - Faça um algoritmo que receba um valor A e B, e troque o valor de A por B e o valor de B por A e
// imprima na tela os valores. 

Console.WriteLine("Digite o valor A: ");
double vA = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor B: ");
double vB = double.Parse(Console.ReadLine());

double temp = vA;

vA = vB;
vB = temp;

Console.WriteLine("Valor A: " +  vA);
Console.WriteLine("Valor B: " + vB);

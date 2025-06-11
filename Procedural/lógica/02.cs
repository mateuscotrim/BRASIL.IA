// 02 - Faça um algoritmo que leia o valor do salário de um usuário,
// calcule quantos salários mínimos esse usuário ganha e imprima na tela o resultado.
// (Base para o Salário mínimo R$ 1.293,20). 

double salarioMinimo = 1293.20;

Console.Write("Digite o valor do seu salário: R$ ");
double salarioUsuario = Convert.ToDouble(Console.ReadLine());

double quantidadeSalariosMinimos = salarioUsuario / salarioMinimo;

Console.WriteLine($"Você ganha aproximadamente {quantidadeSalariosMinimos:F2} salários mínimos.");

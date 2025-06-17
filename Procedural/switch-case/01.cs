//  01 - Faça um algoritmo que leia o valor de um produto e determine o valor que deve ser pago, conforme a
// escolha da forma de pagamento pelo comprador e imprima na tela o valor final do produto a ser pago.
// Utlize os códigos da tabela de condições de pagamento para efetuar o cálculo adequado.
// Tabela de Código de Condições de Pagamento
// 1 - À Vista em Dinheiro ou Pix, recebe 15% de desconto
// 2 - À Vista no cartão de crédito, recebe 10% de desconto
// 3 - Parcelado no cartão em duas vezes, preço normal do produto sem juros
// 4 - Parcelado no cartão em três vezes ou mais, preço normal do produto mais juros de 10% 

Console.WriteLine("Digite o valor do produto: ");
double valor = double.Parse(Console.ReadLine());

Console.WriteLine("Escolha a forma de pagamento (1, 2, 3, 4): ");
Console.WriteLine("1 - À Vista em Dinheiro ou Pix");
Console.WriteLine("2 - À Vista no cartão de crédito");
Console.WriteLine("3 - Parcelado no cartão em duas vezes");
Console.WriteLine("4 - Parcelado no cartão em três vezes ou mais");
int formaPagamento = int.Parse(Console.ReadLine());

double calculo;

switch (formaPagamento) {
    case 1:
        calculo = valor - (valor * 0.15);
        Console.WriteLine($"Valor final a ser pago: R$ {calculo:F2}");
        break;

    case 2:
        calculo = valor - (valor * 0.10);
        Console.WriteLine($"Valor final a ser pago: R$ {calculo:F2}");
        break;

    case 3:
        Console.WriteLine($"Valor final a ser pago: R$ {valor:F2} (sem juros)");
        break;

    case 4:
        calculo = valor + (valor * 0.10);
        Console.WriteLine($"Valor final a ser pago: R$ {calculo:F2} (com 10% de juros)");
        break;

    default:
        Console.WriteLine("Opção de pagamento inválida.");
        break;
}

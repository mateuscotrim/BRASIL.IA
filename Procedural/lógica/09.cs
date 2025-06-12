// 09 - Faça um algoritmo que efetue o cálculo do salário líquido de um professor. As informações fornecidas
// serão: valor da hora aula, número de aulas lecionadas no mês e percentual de desconto do INSS. Imprima
// na tela o salário líquido final. 

Console.WriteLine("Digite o valor da hora aula: ");
double valorAula = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o número de aulas lecionadas no mês: ");
int aulasLecionadas = int.Parse(Console.ReadLine());

double salarioBruto = aulasLecionadas * valorAula;
double inssDesconto = 0;

if (salarioBruto <= 1518.00) {
    inssDesconto = salarioBruto * 0.075;
} else if (salarioBruto <= 2793.88) {
    inssDesconto = salarioBruto * 0.09; 
} else if (salarioBruto <= 4190.83) {
    inssDesconto = salarioBruto * 0.12; 
} else if (salarioBruto <= 8157.41) {
    inssDesconto = salarioBruto * 0.14; 
}

double salarioLiquido = salarioBruto - inssDesconto;

Console.WriteLine($"Salário bruto: R$ {salarioBruto:F2}");
Console.WriteLine($"Desconto do INSS: R$ {inssDesconto:F2}");
Console.WriteLine($"Salário líquido: R$ {salarioLiquido:F2}");

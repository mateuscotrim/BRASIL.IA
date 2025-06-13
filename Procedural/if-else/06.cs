// 06 - Faça um algoritmo que calcule o IMC (Índice de Massa Corporal) de uma pessoa, leia o seu peso e sua
// altura e imprima na tela sua condição de acordo com a tabela abaixo

Console.WriteLine("Digite o peso (em kg): ");
double peso = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a altura (em metros): ");
double altura = double.Parse(Console.ReadLine());

double imc = peso / (altura * altura);

Console.WriteLine($"Seu IMC é: {imc:F2}");

if (imc < 18.5) {
    Console.WriteLine("Abaixo do peso");
} else if (imc >= 18.5 && imc <= 24.9) {
    Console.WriteLine("Peso ideal (parabéns)");
} else if (imc >= 25.0 && imc <= 29.9) {
    Console.WriteLine("Levemente acima do peso");
} else if (imc >= 30.0 && imc <= 34.9) {
    Console.WriteLine("Obesidade grau I");
} else if (imc >= 35.0 && imc <= 39.9) {
    Console.WriteLine("Obesidade grau II (severa)");
} else {
    Console.WriteLine("Obesidade grau III (mórbida)");
}

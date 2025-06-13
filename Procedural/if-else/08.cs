// 08 - Faça um algoritmo que leia quatro notas obƟdas por um aluno, calcule a média das nota obƟdas,
// imprima na tela o nome do aluno e se o aluno foi aprovado ou reprovado. Para o aluno ser considerado
// aprovado sua média final deve ser maior ou igual a 7. 

Console.WriteLine("Digite o nome do aluno: ");
string nomeAluno = Console.ReadLine();

Console.WriteLine("Digite a primeira nota: ");
double nota1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a segunda nota: ");
double nota2 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a terceira nota: ");
double nota3 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a quarta nota: ");
double nota4 = double.Parse(Console.ReadLine());

double media = (nota1 + nota2 + nota3 + nota4) / 4;

Console.WriteLine($"Média do aluno {nomeAluno}: {media:F2}");

if (media >= 7) {
    Console.WriteLine("Aluno aprovado!");
} else {
    Console.WriteLine("Aluno reprovado.");
}

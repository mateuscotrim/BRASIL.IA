// 09 - Faça algoritmo que leia o nome e a idade de uma peso e imprima na tela o nome da pessoa e se ela é maior ou menor de idade.

Console.WriteLine("Digite o nome da pessoa: ");
string nome = Console.ReadLine();

Console.WriteLine("Digite a idade da pessoa: ");
int idade = int.Parse(Console.ReadLine());

if (idade >= 18) {
    Console.WriteLine($"{nome} é maior de idade.");
} else {
    Console.WriteLine($"{nome} é menor de idade.");
}

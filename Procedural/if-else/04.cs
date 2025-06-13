// 04 - Faça um algoritmo que leia dois valores booleanos (lógicos) e determine se ambos são VERDADEIRO ou FALSO. 

Console.WriteLine("Digite TRUE ou FALSE: ");

bool A = bool.Parse(Console.ReadLine());

Console.WriteLine("Digite TRUE ou FALSE: ");
bool B = bool.Parse(Console.ReadLine());

if (A == true && B == true) {
    Console.WriteLine("Ambos são VERDADEIROS");
} else if (A == false && B == false) {
    Console.WriteLine("Ambos são FALSOS");
} else {
    Console.WriteLine("Um é VERDADEIRO e o outro é FALSO");
}

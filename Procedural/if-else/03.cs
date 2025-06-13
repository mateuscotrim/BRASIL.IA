// 03 - Faça um algoritmo que leia dois valores inteiros A e B, se os valores de A e B forem iguais, deverá
// somar os dois valores, caso contrário devera mulƟplicar A por B. 
// Ao final de qualquer um dos cálculos devese atribuir o resultado a uma variável C e imprimir seu valor na tela. 

Console.WriteLine("Digite o valor de A: ");
int A = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor de B: ");
int B = int.Parse(Console.ReadLine());

int C; 

if (A == B) {
    C = A + B;
} else {
    C = A * B;
}

Console.WriteLine("O resultado é: " + C);

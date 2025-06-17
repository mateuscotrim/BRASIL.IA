// 01 - Sara tem 1,50m e cresce 2 cenơmetros por ano, enquanto Francisco tem 1,10m e cresce 3 cenơmetros
// por ano. Faça um algoritmo que calcule e imprima na tela em quantos anos serão necessários para que
// Francisco seja maior que Sara.

double sara = 1.50;
double francisco = 1.10;
int anos = 0;

while (sara >= francisco) {
    sara += 0.02;
    francisco += 0.03;
    anos++;
}

Console.WriteLine($"É necessario {anos} anos para Francisco ser maior que a Sara.");


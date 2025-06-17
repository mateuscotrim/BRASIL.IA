// 05 - Faça um algoritmo que leia o ano em que uma pessoa nasceu, imprima na tela quantos anos, meses e
// dias essa pessoa ja viveu. Leve em consideração o ano com 365 dias e o mês com 30 dias. 
// (Ex: 5 anos, 2 meses e 15 dias de vida) 

Console.Write("Digite o dia de nascimento: ");
int diaNascimento = int.Parse(Console.ReadLine());

Console.Write("Digite o mês de nascimento: ");
int mesNascimento = int.Parse(Console.ReadLine());

Console.Write("Digite o ano de nascimento: ");
int anoNascimento = int.Parse(Console.ReadLine());

int diaAtual = DateTime.Now.Day;
int mesAtual = DateTime.Now.Month;
int anoAtual = DateTime.Now.Year;

int idadeAnos = anoAtual - anoNascimento;

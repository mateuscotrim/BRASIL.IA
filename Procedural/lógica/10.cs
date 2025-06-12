// 10 - Faça um algoritmo que calcule a quanƟdade de litros de combusơvel gastos em uma viagem, sabendo
// que o carro faz 12km com um litro. Deve-se fornecer ao usuário o tempo que será gasto na viagem a sua
// velocidade média, distância percorrida e a quanƟdade de litros uƟlizados para fazer a viagem.

Console.WriteLine("Digite a velocidade média (em km/h): ");
double velocidadeMedia = double.Parse(Console.ReadLine());

Console.WriteLine("Digite quanto tempo durou a viagem (em horas): ");
double tempoViagem = double.Parse(Console.ReadLine());

double distancia = velocidadeMedia * tempoViagem;

double litrosUsados = distancia / 12;

Console.WriteLine($"Distância percorrida: {distancia} km");
Console.WriteLine($"Quantidade de litros utilizados: {litrosUsados} litros");

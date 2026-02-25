using static System.Console;
//Declaração de variaveis
double largura, comprimento, valor, area, preco;
//-------------Entrada de dados-----------------------------
Write("Digite a largura do terreno: ");
largura = double.Parse(ReadLine());
Write("Digite o comprimento do terreno: ");
Comprimento = double.Parse(ReadLine());
Write("Digite o valor do m2 do terreno: ");
valor = double.Parse(ReadLine());
//-------------Processamento de dados----------------------
area = largura * comprimento;
preco = area * valor;
//-------------Saida de dados-----------------------------
WriteLine($"A area do terreno é de {area} e o preço do terreno é de R${preco}");
using static System.Console;
using System;
double baseR, altura, perimetro, area, diagonal;
//-------------Entrada de dados-----------------------------
Write("Digite a base do retangulo: ");
baseR = double.Parse(ReadLine());
Write("Digite a altura do retangulo: ");
altura = double.Parse(ReadLine());
//-------------Processamento de dados----------------------
area = baseR * altura;
perimetro = 2 * (baseR + altura);
diagonal = Math.Sqrt(baseR * baseR + altura * altura);
//-------------Saida de dados-----------------------------
WriteLine($"A area do retângulo é de {area}, o perímetro é de {perimetro} e a diagonal é {diagonal}");
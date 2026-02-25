using static System.Console;
using System;
using System.IO.Pipes;
double dia, mes, ano, totaldias;
//-------------Entrada de dados-----------------------------
Write("Digite o dia: ");
dia = double.Parse(ReadLine());
ano = dia / 365;
mes = (dia % 365) / 30;
totaldias = (dia % 365) % 30;
WriteLine($"{ano} ano(s), {mes} mes(es) {dia} dia(s)");
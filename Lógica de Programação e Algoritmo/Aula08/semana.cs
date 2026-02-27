// o usuario vai digitar um valor de 1 a 7 e esse código é para mostrar o dia da semana correspondente a esse número digitado pelo usuário
using static System.Console;
using System;
//----------Declaração de variaveis--------
int valor;
//----------Entrada de dados---------------
Write("Digite um número de 1 a 7: ");
valor = int.Parse(Console.ReadLine());
if (valor == 1)
{
    WriteLine("Domingo");
}
else if (valor == 2)
{
    WriteLine("Segunda");
}
else if (valor == 3)
{
    WriteLine("Terça");
}
else if (valor == 4)
{
    WriteLine("Quarta");
}
else if (valor == 5)
{
    WriteLine("Quinta");
}

else if (valor == 6)
{
    WriteLine("Sexta");
}

else if (valor == 7)
{
    WriteLine("Sábado");
}
else
{
    WriteLine("Número fora do intervalo");
}
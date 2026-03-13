using System;
using static System.Console;
//Declaração de uma matrix 3x3
int [,] matriz = new int [3, 3];

//Entrada de dados, inserir valor na matriz
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Write($"Digite o valor p/ a posição [{i}, {j}]: ");
        matriz[i, j] = int.Parse(ReadLine());
    }
}
WriteLine("Matriz preenchida: ");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Write(matriz[i, j] + "\t");
    }
    WriteLine();
}
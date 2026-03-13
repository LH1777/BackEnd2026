using System;
using static System.Console;

//Declaração de variaveis
int n = 0;
int negativos = 0;

//Entrada de dados
try{
    WriteLine("Qual a ordem da matriz? (máximo 10): ");
    n = int.Parse(ReadLine());
    if (n > 10)
    {
        WriteLine("A matriz não pode ser maior que 10");
        return;
    }
}
catch
{
    WriteLine("Digite apenas números");
}


int [,] matriz = new int [n, n];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Write($"Digite o valor p/ a posição [{i}, {j}]: ");
        matriz[i, j] = int.Parse(ReadLine());

        if (matriz [i, j] < 0)
        {
            negativos++;
        }
    }
}
WriteLine("Matriz preenchida: ");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Write(matriz[i, j] + "\t");
    }
    WriteLine();
}
WriteLine("Diagonal principal:");
for (int i = 0; i < n; i++)
{
    Write(matriz[i, i] + "\t");
}

WriteLine();
WriteLine("Quantidade de negativos: " + negativos);
using static System.Console;
using static System.Linq.Enumerable;

int n;

Write("Quantos números você vai digitar? ");
n = int.Parse(ReadLine());
if (n < 0)
{
    WriteLine("Valor inválido! O número de elementos deve ser positivo.");
}
else if (n > 10)
{
    WriteLine("Maximo de valores para digitar igual a 10");
    WriteLine("Tente novamente!");
}   
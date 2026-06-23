using static System.Console;
using static System.Linq.Enumerable;

int visitantes = 0, contagem = 0;
double altura_max = 0, altura_min = 0, alturas = 0;

try
{
    Write("Digite o numero de visitantes: ");
    visitantes = int.Parse(ReadLine());

    Write("Digite a altura maxima: ");
    altura_max = double.Parse(ReadLine());

    Write("Digite a altura minima: ");
    altura_min = double.Parse(ReadLine());

    foreach(int i in Range(0, visitantes))
    {
        Write($"Digite a altura da pessoa nº {i + 1}: ");
        alturas = double.Parse(ReadLine());

        if ((alturas >= altura_min) && (alturas <= altura_max))
        {
            contagem++;
            WriteLine("Pessoa pode andar na montanha-russa");
        }
    }

    WriteLine($"O número de pessoas que podem andar é {contagem}");
}
catch (Exception ex)
{
    WriteLine($"Valor invalido, erro = {ex.Message}");
}

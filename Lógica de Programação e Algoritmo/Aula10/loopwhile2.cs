using static System.Console;
using System.Media;

int registros = 0;
int turistas;
int totalTuristas = 0;
int turistasNoParque = 0;
string movimento;

while (registros < 3)
{
    Write("Digite o movimento do carro (entrando/saindo): ");
    movimento = ReadLine().ToLower();

    // valida o movimento
    if (movimento != "entrando" && movimento != "saindo")
    {
        WriteLine("Movimento inválido! Digite apenas 'entrando' ou 'saindo'.");
        Beep(1000, 500);
        continue;
    }

    Write("Digite a quantidade de turistas (0 a 4): ");
    turistas = int.Parse(ReadLine());

    // valida quantidade de turistas
    if (turistas < 0 || turistas > 4)
    {
        WriteLine("Número de turistas inválido! Máximo permitido é 4.");
        Beep(1000, 1000);
        continue;
    }

    if (movimento == "entrando")
    {
        totalTuristas += turistas;
        turistasNoParque += turistas;
        WriteLine("O Fiat Uno está entrando no parque.");
    }
    else if (movimento == "saindo")
    {
        if (turistas <= turistasNoParque)
        {
            turistasNoParque -= turistas;
            WriteLine("O Fiat Uno está saindo do parque.");
        }
        else
        {
            WriteLine("Erro: não há turistas suficientes no parque.");
            continue;
        }
    }

    registros++;
}

WriteLine("\nControle finalizado.");
WriteLine($"Total de turistas registrados: {totalTuristas}");
WriteLine($"Turistas que ainda estão no parque: {turistasNoParque}");
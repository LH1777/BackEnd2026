using static System.Console;

int registros = 0;
int turistas;
int totalTuristas = 0;
int turistasNoParque = 0;
string movimento;

while (registros < 3)
{
    Write("Digite o movimento do carro (entrando/saida): ");
    movimento = ReadLine().ToLower();

    // valida o movimento
    if (movimento != "entrando" && movimento != "saida")
    {
        WriteLine("Movimento inválido! Digite apenas 'entrando' ou 'voltando'.");
        continue;
    }

    Write("Digite a quantidade de turistas (0 a 4): ");
    turistas = int.Parse(ReadLine());

    // valida quantidade de turistas
    if (turistas < 0 || turistas > 4)
    {
        WriteLine("Número de turistas inválido! Máximo permitido é 4.");
        continue;
    }

    if (movimento == "entrando")
    {
        totalTuristas += turistas;
        turistasNoParque += turistas;
        WriteLine("O Fiat Uno está entrando no parque.");
    }
    else if (movimento == "saida")
    {
        if (turistas <= turistasNoParque)
        {
            turistasNoParque -= turistas;
            WriteLine("O Fiat Uno está voltando do parque.");
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
using static System.Console;
//Problema N rainhas
bool PodeColocar(int[] tabuleiro, int linha, int coluna)
{
    for (int i = 0; i < linha; i++)
    {
        if (tabuleiro[i] == coluna ||
            (tabuleiro[i] - i) == (coluna - linha) ||
            (tabuleiro[i] + i) == (coluna + linha))
        {
            return false;
        }
    }

    return true;
}

void ImprimirTabuleiro(int[] tabuleiro, int n)
{
    WriteLine("\nSolução encontrada:\n");

    for (int linha = 0; linha < n; linha++)
    {
        for (int coluna = 0; coluna < n; coluna++)
        {
            if (tabuleiro[linha] == coluna)
            {
                Write(" Q ");
            }
            else
            {
                Write(" . ");
            }
        }

        WriteLine();
    }
}

bool ResolverNRainhas(int[] tabuleiro, int linha, int n)
{
    if (linha == n)
    {
        ImprimirTabuleiro(tabuleiro, n);
        return true;
    }

    for (int coluna = 0; coluna < n; coluna++)
    {
        if (PodeColocar(tabuleiro, linha, coluna))
        {
            tabuleiro[linha] = coluna;

            if (ResolverNRainhas(tabuleiro, linha + 1, n))
            {
                return true;
            }

            tabuleiro[linha] = -1;
        }
    }

    return false;
}
//----Declaração de variavies
int n;

try
{
    //----Entrada de dados
    Write("Digite o número de rainhas: ");
    n = int.Parse(ReadLine());

    if (n < 1)
    {
        WriteLine("Digite um valor maior que zero.");
        return;
    }

    int[] tabuleiro = new int[n];
    for (int i = 0; i < n; i++)
    {
        tabuleiro[i] = -1;
    }

    //-----Processamento de dados
    bool encontrouSolucao = ResolverNRainhas(tabuleiro, 0, n);

    if (!encontrouSolucao)
    {
        WriteLine("Não existe solução para esse valor de N.");
    }
}
catch (Exception ex)
{
    WriteLine("Valor inválido. Erro: " + ex.Message);
}
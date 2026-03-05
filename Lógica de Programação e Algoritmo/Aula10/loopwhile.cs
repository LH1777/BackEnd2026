using static System.Console;

//Declaração de variaveis
const string ENTRADA = "entrada";
const string SAIDA = "saida";
string entrada, saida;
double turistas = 0;
//Eentrada de dados
try{
    Write("Digite o fluxo de carro (entrada/saida):  ");
    entrada = (ReadLine());
    saida = (ReadLine());
    if (entrada == ENTRADA)
    {
        WriteLine("O Fiat Uno está entrando no parque ");
    }
    else if (saida == SAIDA);
    {
        WriteLine("O Fiat Uno está saido do parque");
    }
}
catch(Exception ex)
{
    WriteLine("Valores incorretos")
}
Write("Agora digite o número de turistas no carro: ")
turistas = double.Parse(ReadLine());
Write($"O fiat uno está indo pela {SAIDA} carregando {turistas} turistas.");


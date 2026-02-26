using static System.Console;
//------Declaração de variaveis------
try{
    double nota1, nota2, resultado;
    //------Entrada de dados-------------
    Write("Digite a 1 nota: ");
    nota1 = double.Parse(Console.ReadLine());
    Write("Digite a 2 nota: ");
    nota2 = double.Parse(Console.ReadLine());
    //------Processamento de dados-------
    resultado = nota1 + nota2;
    if (resultado < 60)
    {
        WriteLine($"Nota final = {resultado}");
        WriteLine("Reprovado");
    }
    else
    {
        WriteLine($"Nota final = {resultado}");
        WriteLine("Aprovado");
    }
}
catch(Exception)
{
    WriteLine("Valor invalido, tente novamente.");
}
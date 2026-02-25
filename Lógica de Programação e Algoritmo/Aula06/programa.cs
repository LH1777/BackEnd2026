using static System.Console;
try{
    int a;
    int b;
    int c;
    WriteLine("Qual o valor de A? ");
    a = int.Parse(ReadLine());
    WriteLine("Qual o valor de B? ");   
    b = int.Parse(ReadLine());
    WriteLine("Qual o valor de C? ");
    c = int.Parse(ReadLine());
    //-------------Processamento de dados-----------------------------
    string resultado1 = a == c ? "Verdadeiro" : "Falso";
    string resultado2 = b != a ? "Verdadeiro" : "Falso";
    string resultado3 = b > c ? "Verdadeiro" : "Falso";
    string resultado4 = a <= c ? "Verdadeiro" : "Falso";
    //-------------Saida de dados--------------------------------------
    WriteLine($"O resultado da comparação 1 é: {resultado1}");
    WriteLine($"O resultado da comparação 2 é: {resultado2}");
    WriteLine($"O resultado da comparação 3 é: {resultado3}");
    WriteLine($"O resultado da comparação 4 é: {resultado4}");
}
catch (Exception)
{
    WriteLine("Valores invalidos, tente novamente. ");
}
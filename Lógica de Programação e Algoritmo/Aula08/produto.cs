using static System.Console;

//------------------Declaração de variáveis------------
int codigo, quantidade;
//------------------Entrada de dados-------------------
Write("Digite o código do produto: ");
codigo = int.Parse(ReadLine());
Write("Digite a quantidade de produto: ");
quantidade = int.Parse(ReadLine());
switch (codigo)
{
    case 1:
        WriteLine($"O valor total é de: {quantidade * 5.0}");
        break;
    case 2:
        WriteLine($"O valor total é de: {quantidade * 4.0}");
        break;
    case 3:
        WriteLine($"O valor total é de: {quantidade * 3.75}");
        break;
    case 4:
        WriteLine($"O valor total é de: {quantidade * 8.99}");
        break;
    case 5:
        WriteLine($"O valor total é de: {quantidade * 11.33}");
        break;
}
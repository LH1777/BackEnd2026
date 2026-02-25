//Entrada de dados
/*----------------------------------------------------*/
Console.WriteLine("Digite o seu nome: ");
string nome = Console.ReadLine();//Entrada de dados
System.Console.WriteLine($"O valor digitado é de {nome}");
Console.WriteLine("Digite o 1º numero: ");
double x = double.Parse((Console.ReadLine()));
System.Console.WriteLine("Digite o 2º numero: ");
double y = double.Parse(Console.ReadLine());
/*----------------------------------------------------*/
//Processamento de dados
/*----------------------------------------------------*/
double soma = x + y;
/*----------------------------------------------------*/
//Saida de dados
/*----------------------------------------------------*/
System.Console.WriteLine($"A soma dos dois valores é de {soma}");
/*----------------------------------------------------*/
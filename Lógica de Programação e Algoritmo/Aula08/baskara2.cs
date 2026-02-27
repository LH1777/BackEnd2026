using static System.Console;
//----------Funções------------------------
static double delta(double a, double b, double c)
{
    return (b * b) - (4 * a * c);
}

static void saida(double x1, double x2)
{
    WriteLine($"X1 ={x1}\nX2 = {x2}");
}

static void raizes(double a, double b, double delta)
{
    double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
    double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
    saida(x1, x2);
}
//----------Declaração de variaveis--------
double a, b, c, delta1;
const string TEXTO = "Digite o valor de {0}: ";
//----------Entrada de dados---------------
Write(TEXTO + "a");
a = double.Parse(ReadLine());
Write(TEXTO + "b");
b = double.Parse(ReadLine());
Write(TEXTO + "c");
c = double.Parse(ReadLine());
//----------Processamento de dados----------
delta1 = delta(a, b, c);
//----------Estrutura de controle de decisão - IF
if (delta1 < 0)
{
    WriteLine("Raizes impossiveis");
}
else if (delta1 == 0)
{
    raizes(a, b, delta1);
}
else
{
    raizes(a, b, delta1);
}
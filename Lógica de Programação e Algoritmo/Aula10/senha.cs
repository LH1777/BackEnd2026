using static System.Console;
//Declaração de variaveis
const int SENHAFIXA = 1945;
int senha, contagem = 0;
//Entrada de dados
Write("Digite a senha: ");
senha = int.Parse(ReadLine());
//Processamento de dados
while (senha != SENHAFIXA)
{
    Write("Senha inconrreta, digite novamente: ");
    senha = int.Parse(ReadLine());
    Beep(1000, 30);
}
if (contagem < 3)
{
    WriteLine("Acesso permitido!");
}
else
{
    WriteLine("a");
}
    using static System.Console;
    using System;
    try{
    //-------------Declaração de variaveis----------------------------
    double a, b, c, areaQuadrado, areaTriangulo, areaTrapezio;
    //-------------Entrada de dados-----------------------------------
    Write("Digite a medida A: ");
    a = double.Parse(ReadLine());
    Write("Digite a medida B: ");
    b = double.Parse(ReadLine());
    Write("Digite a medida C: ");
    c = double.Parse(ReadLine());
    //-------------Processamento de dados------------------------------
    areaQuadrado = a * a;
    areaTriangulo = (a * b) / 2;
    areaTrapezio = ((a + b) * c) / 2;
    //-------------Saida de dados--------------------------------------
    WriteLine($"Area do quadrado = {areaQuadrado:F4}");
    WriteLine($"Area do triangulo = {areaTriangulo:F4}");
    WriteLine($"Area do trapezio = {areaTrapezio:F4}");
    }
    catch (Exception)
{
    WriteLine("Valores invalidos, tente novamente. ");
}
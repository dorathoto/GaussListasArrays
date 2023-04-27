using System.ComponentModel.DataAnnotations;

int valor1 = 10;
int valor2 = 3;

//Operadores aritméticos
int atribuicao = valor1 + valor2;
int subtracao = valor1 - valor2;
int multiplicacao = valor1 * valor2;
int divisao = valor1 / valor2;
int resto = valor1 % valor2;

Console.WriteLine($"Atribuição de valor1 + valor2 =  {atribuicao}");
Console.WriteLine($"Subtração de valor1 - valor2 =  {subtracao}");
Console.WriteLine($"Multiplicação de valor1 * valor2 =  {multiplicacao}");
Console.WriteLine($"Divisão de valor1 / valor2 =  {divisao}");
Console.WriteLine($"Resto de valor1 % valor2 =  {resto}");


Console.WriteLine("==========================================");
///Operadores de Atribuição reduzida +=, -=, *=, /=, %=
int valor3 = valor1;
int valor4 = valor2;

int atribuicao2 = valor3 += valor4;
int subtracao2 = valor3 -= valor4;
int multiplicacao2 = valor3 *= valor4;
int divisao2 = valor3 /= valor4;
int resto2 = valor3 %= valor4;


Console.WriteLine($"Atribuição de valor3 += valor4 =  {atribuicao2}");
Console.WriteLine($"Subtração de valor3 -= valor4 =  {subtracao2}");
Console.WriteLine($"Multiplicação de valor3 *= valor4 =  {multiplicacao2}");
Console.WriteLine($"Divisão de valor3 /= valor4 =  {divisao2}");
Console.WriteLine($"Resto de valor3 %= valor4 =  {resto2}");

Console.WriteLine("==========================================");
///Operadores de Incremento e Decremento e pré-incremento, pré-decremento
int valor5 = valor1++;
int valor6 = valor1--;
int valor7 = ++valor1;
int valor8 = --valor1;
Console.WriteLine($" valor1++ =  {valor5}");
Console.WriteLine($" valor1-- =  {valor6}");
Console.WriteLine($" ++valor1 =  {valor7}");
Console.WriteLine($" --valor1 =  {valor8}");

Console.WriteLine("==========================================");
///Operadores de Comparação ==, !=, >, <, >=, <=
bool comparacao1 = valor1 == valor2;
bool comparacao2 = valor1 != valor2;
bool comparacao3 = valor1 > valor2;
bool comparacao4 = valor1 < valor2;
bool comparacao5 = valor1 >= valor2;
bool comparacao6 = valor1 <= valor2;
Console.WriteLine($"valor1 == valor2 =  {comparacao1}");
Console.WriteLine($"valor1 != valor2 =  {comparacao2}");
Console.WriteLine($"valor1 > valor2 =  {comparacao3}");
Console.WriteLine($"valor1 < valor2 =  {comparacao4}");
Console.WriteLine($"valor1 >= valor2 =  {comparacao5}");
Console.WriteLine($"valor1 <= valor2 =  {comparacao6}");


Console.WriteLine("==========================================");
//Operadores Lógicos &&, ||, !

bool logico1 = valor1 == valor2 && valor1 > valor2;
bool logico2 = valor1 == valor2 || valor1 > valor2;
bool logico3 = !(valor1 == valor2);
Console.WriteLine($"valor1 == valor2 && valor1 > valor2 =  {logico1}");
Console.WriteLine($"valor1 == valor2 || valor1 > valor2 =  {logico2}");
Console.WriteLine($"!(valor1 == valor2) =  {logico3}");


Console.WriteLine("==========================================");


//Operador ternário
var ternario = true;


int logico4;
if (ternario)
{
    logico4 = valor1;
}
else
{
    logico4 = valor2;
}


//refatorando
int logico4b = valor2;
if (ternario)
{
    logico4b = valor1;
}


//refatorando
var logico5 = ternario ? valor1 : valor2;



Console.ReadKey();
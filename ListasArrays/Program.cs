using leoonardo = System.Int32;
//exemplo de var

using Exemplos;
using System.Runtime.Serialization;

var valor1 = 10;
var valor2 = 20m;
var valor3 = 30.0;
var valor4 = 40.0f;

//variaves menos comuns
var valor5 = 50L;
var valor6 = 60u;
var valor7 = 70ul;
var valor8 = 80uL;


//++++++++++++++++++++++++++++++++++++++++++++
bool valor9 = true;

if(valor9 == true)
{
    ///Codigo muito feio
}

if(valor9 == false)
{
    //codigo muito feio
}

if(valor9 != true)
{
    //codigo feio
}

if (valor9)
{
    //Código Bonitinho :)
}

if (!valor9)
{
    //Código Bonitinho :)
}

//Lembrar operador ternário
//+++++++++++++++++++++++++++++++++++++++++++++
//verificar string e null
string nome = null;
if (string.IsNullOrEmpty(nome))
{
    //Código Bonitinho :)
}



///*****************************************************************
///funções e classes
var soma = Calculadora.Soma(10, 20);


var soma2 = Soma(10, 20);

int Soma(int a, int b)
{
    return a + b;
}


///*****************************************************************
///Explicar a função main(String[] //array


//Tipos nulllable

int? variavel = null; //não valido var? variavel2 = 10;
variavel = 12;

leoonardo tipoEstranho = 10;//uso do using para alias;

//ambos permitido mas mais feio que bater na mãe
int @int = 20;
int nomçãoéIncrivel = 10; 
Console.ReadKey();
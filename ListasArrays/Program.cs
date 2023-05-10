//Ex: fazendo um for com 1mil e adicionando uma list<Cadastro> com valores aleatorios (random)
using Exemplos.Models;
using Exemplos.Models.Enums;

var lista = new List<Cadastro>();   

Random rnd = new Random();
for (int i = 0; i < 4; i++)
{
    var num = rnd.Next(0, 10);
    var salario = num * 1000.35m;
    var cadastro = new Cadastro();
    cadastro.Nome = $"Nome {i}";
    cadastro.Salario = salario ==0 ? 1000 : salario;
    cadastro.Funcao = (TipoFuncao)num;
    lista.Add(cadastro);

    Console.WriteLine($"[{i}] - Nome: {cadastro.Nome} - Salario: {cadastro.Salario} - Funcao: {cadastro.Funcao}");

}
Console.WriteLine("#####################################");
Console.WriteLine("######       STATS          #########");
Console.WriteLine($"Total de registros: {lista.Count()}");
Console.WriteLine($"Total de registros com salario maior que 1000: {lista.Where(x => x.Salario > 1000).Count()}");
Console.WriteLine($"Total de registros com salario menor que 1000: {lista.Where(x => x.Salario < 1000).Count()}");
Console.WriteLine($"Total de registros com salario igual a 1000: {lista.Where(x => x.Salario == 1000).Count()}");
//refatorar
Console.WriteLine($"Total de registros com funcao igual a 1: {lista.Where(x => x.Funcao == TipoFuncao.TI).Count()}");
Console.WriteLine($"Total de registros com funcao igual a 2: {lista.Where(x => x.Funcao == TipoFuncao.RH).Count()}");
Console.WriteLine($"Total de registros com funcao igual a 3: {lista.Where(x => x.Funcao == TipoFuncao.CLevel).Count()}");
Console.WriteLine($"Total de registros com funcao igual a 4: {lista.Where(x => x.Funcao == TipoFuncao.Financeiro).Count()}");
Console.WriteLine($"Total de registros com funcao igual a 5: {lista.Where(x => x.Funcao == TipoFuncao.Administrativo).Count()}");

foreach (var item in Enum.GetValues(typeof(TipoFuncao)))
{
    Console.WriteLine($"Total de registros com funcao igual a {(int)item}: {lista.Where(x => x.Funcao == (TipoFuncao)item).Count()}");
}
Console.WriteLine($"Média de salarios: {lista.Average(x => x.Salario)}");

Console.WriteLine("#####################################");



//ex:2
//fazer um do while para pedir o nome e o salario de 10 pessoas e mostrar a media de salario
//e mostrar o nome da pessoa com o maior salario
var lista2 = new List<Cadastro>();
bool continuarLoop = true;
do
{
    var cadastro = new Cadastro();
    Console.WriteLine("Digite o nome da pessoa:");
    cadastro.Nome = Console.ReadLine();
    Console.WriteLine("Digite o salario da pessoa:");
    cadastro.Salario = Convert.ToDecimal(Console.ReadLine());
    lista2.Add(cadastro);
    Console.WriteLine("Deseja cadastrar mais pessoas? (S/N)");
    var resposta = Console.ReadLine();
    if (resposta.ToUpper() == "N")
    {
        continuarLoop = false;
    }

} while (continuarLoop);

Console.WriteLine($"A pessoa com maior salario é: {lista2.OrderByDescending(x => x.Salario).First().Nome}");
Console.ReadLine();
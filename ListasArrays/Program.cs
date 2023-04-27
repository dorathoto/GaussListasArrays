var nomes = new List<string>();
nomes.Add("Barbara");
nomes.Add("Maria");
nomes.Add("Ana");


var alunasList = new List<(string nome, int idade)>();
alunasList.Add(("Barbara", 16));
alunasList.Add(("Maria", 20));
alunasList.Add(("Ana", 19));


var alunoList2 = new List<(string nome, int idade)>
{
    ("Barbara", 16),
    ("Maria", 20),
    ("Ana", 19)
};

//LINQ
//Orderby, OrderbyDesc, Find, lambda

var alunoNull = alunasList.Find(x => x.nome == "Leonardo");

var alunoAchou = alunasList.Find(x => x.nome == "João");
var idadeAlunoAchou = alunoAchou.idade;

var existe = alunasList.Any(w => w.idade == 18);


//.WHERE ToList(), First()
var t = alunasList.Where(w => w.idade != 20 && w.nome.Contains("a")).ToList();

//SUM - somar
var totalIdade = alunasList.Sum(w => w.idade);

//WHERE + SUM
var totalIdade2 = alunasList.Where(w => w.idade > 18).Sum(w => w.idade);

//Somente um campo
var listString = alunasList.Select(p => p.nome).ToList();

foreach (var aluno in alunasList.OrderBy(o => o.nome))
{
    Console.WriteLine(aluno.nome);

}

//escopo de variavel aluno já existe mas pertence somente ao foreach
foreach (var aluno in alunasList.OrderByDescending(o => o.idade))
{
    Console.WriteLine($"Idade {aluno.idade}");

}



Console.ReadKey();
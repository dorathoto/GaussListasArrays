namespace ListasArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //fazer uma lista que aceita uma string e um inteiro chamada receitas

            var receitas = new List<(string, int)>();

            //1 - bolo
            receitas.Add(("Bolo de Cenoura", 1));
            receitas.Add(("Bolo de Chocolate", 1));
            receitas.Add(("Bolo de Laranja", 1));

            //2 - torta salgada
            receitas.Add(("Torta salgada de uva passas! :S", 2));
            receitas.Add(("Torta salgada de pesto!", 2));
            receitas.Add(("Torta salgada de queijo!", 2));


            //3 - torta doce
            receitas.Add(("Torta holandesa", 3));
            receitas.Add(("Torta de maçã", 3));
            receitas.Add(("Torta de limão", 3));


            Console.WriteLine("Qual tipo de receita vc quer? [1 bolo, 2-torta salgada, 3- torta doce");
            int resposta = Int32.Parse(Console.ReadLine());

            //aqui estou usando o linq para filtrar a lista, que é algo mais avançado
            // .WHERE é um filtro
            // .Where(x => x.????  sempre tem esse formato n => n.?????, troque os pontos de interrogação pelo campo que vc quer filtrar
            foreach (var receita in receitas.Where(w => w.Item2 == resposta))
            {
                //foreach percorre uma lista
                Console.WriteLine(receita.Item1);
            }
        }
    }
}
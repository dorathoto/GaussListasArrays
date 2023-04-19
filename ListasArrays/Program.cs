namespace ListasArrays
{
    internal class Program
    {
        public class Livro
        {
            //construtor da classe já recebendo 2 parametros
            public Livro(string Receita, string Categoria)
            {
                this.Receita = Receita;
                this.Categoria = Categoria;
            }

            //aqui são propriedades da classe

            public string Receita { get; set; }
            public string Categoria { get; set; }
        }




        static void Main(string[] args)
        {
            //não tinha pq ser uma variavel fora da main e static, trouxe pra cá.
            var receitasBolo = new List<Livro>();


            Console.WriteLine("Receita de bolo? [para sim digite 1]");
            int digite = Int32.Parse(Console.ReadLine());
            if (digite == 1)
            {
                receitasBolo.Add(new Livro("brigadeiro", "bolo"));
                receitasBolo.Add(new Livro("morango", "bolo"));
                receitasBolo.Add(new Livro("Laranja", "bolo"));
                receitasBolo.Add(new Livro("Cenoura", "bolo"));

                //coloquei as chaves
                foreach (Livro l in receitasBolo)
                {
                    Console.WriteLine(l.Categoria + " de " + l.Receita);
                }
            }
            else
            {
                Console.WriteLine("Vamos para a próxima categoria!");
            }
            //removi umas chaves perdidas


            Console.WriteLine("\n");


            List<Livro> receitasTorta = new List<Livro>();
            Console.WriteLine("Receita de Torta? [para sim digite 1]");
            int escreva = Int32.Parse(Console.ReadLine());
            if (escreva == 1)
            {
                receitasTorta.Add(new Livro("frango", "Torta"));
                receitasTorta.Add(new Livro("carne", "Torta"));
                receitasTorta.Add(new Livro("morango", "Torta"));
                receitasTorta.Add(new Livro("banana", "Torta"));
                receitasTorta.Add(new Livro("batata", "Torta"));
                receitasTorta.Add(new Livro("doce", "Torta"));

                foreach (Livro t in receitasTorta)
                {
                    Console.WriteLine(t.Categoria + " de " + t.Receita);
                }
            }
            else
            {
                Console.WriteLine("sem mais receitas");
            }


        }
    }
}





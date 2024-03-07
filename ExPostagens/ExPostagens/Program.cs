using ExPostagens.Entities;

namespace ExPostagens
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Comentario c1 = new Comentario("Tenha uma otima viajem");
            Comentario c2 = new Comentario("Nossa que legal!!!");
            Post p1 = new Post(
                DateTime.Parse("21/06/2022 13:05:44"),
                "Viajando para EUA",
                "Estou indo visitar este pais",
                144);
            p1.AddComment(c1);
            p1.AddComment(c2);




            Comentario c3 = new Comentario("Parabens e muito sucesso");
            Comentario c4 = new Comentario("Nossa que legal! Espero que goste!");
            Post p2 = new Post(
                DateTime.Parse("18/01/2024 14:37:52"),
                "Desbravando novos conhecimentos",
                "Estudando C#",
                10000);
            p2.AddComment(c3);
            p2.AddComment(c4);


            Console.WriteLine(p1);
            Console.WriteLine(p2);


        }
    }
}

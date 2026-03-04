using System.ComponentModel;
using System.Data.Common;
using System.Security.Cryptography.X509Certificates;
using Portal.Content;
using Portal.Savesystem;

namespace Portal.Screens
{
    static class ReviewMenu
    {
        public static void Init()
        {
            Console.Clear();
            Console.WriteLine("Review Menu\n0 - Main menu\n1 - Escrever Resenha\n2 - Ler resenha");
            Console.Write("O que gostaria de fazer? ");
            short x = short.Parse(Console.ReadLine());

            switch(x)
            {
                case 0:
                    MainMenu.Init();
                    break;
                case 1:
                    WriteReview();
                    break;
                case 2:
                    ReadReview();
                    break;
                default: 
                    Init();
                    break;
            }
        }

        public static void WriteReview()
        {
            Console.Clear();
            Console.Write("Nome do jogo: ");
            string gameName = Console.ReadLine();
            Console.Write("Titulo para a resenha: ");
            string title = Console.ReadLine();
            Console.Write("Subtitulo: ");
            string subtitle = Console.ReadLine();
            string review = ReadMultilineInput();
            Review gameReview = new Review(title, subtitle, review, gameName);
            SaveReview.Save(gameReview);
            Console.WriteLine("Resenha salva!");
            Console.ReadKey();
            Init();
        }

        public static void ReadReview()
        {
            List<Review> reviews = SaveReview.GetReviews();
            Console.Clear();
            Console.WriteLine("Resenhas");
            PrintReviews(reviews);
            Console.Write("Escolha uma resenha pelo numero ou 0 para sair: ");
            int x = int.Parse(Console.ReadLine());

            if(x == 0)
                Init();
            x--;
            if(reviews[x] == null)
            {
                Console.WriteLine("Valor invalido");
                Console.ReadKey();
                ReadReview();
            }

            Console.WriteLine($"{reviews[x].Title}\n{reviews[x].Subtitle}\nGame: {reviews[x].GameTitle}\n{reviews[x].GameReview}");
            Console.ReadKey();
            ReadReview();
        }

        private static void PrintReviews(List<Review> reviews)
        {
            for(int x = 0; x < reviews.Count; x++)
            {
                Console.WriteLine($"{x + 1} - Titulo: {reviews[x].Title} - Jogo {reviews[x].GameTitle}");
            }
        }

        private static string ReadMultilineInput()
        {
            Console.WriteLine("Escreva a resenha (coloque FIM numa nova linha para finalizar):");

            var lines = new List<string>();

            while(true)
            {
                string? line = Console.ReadLine();

                if(line == null)
                    break;
                if(line.ToUpper() == "FIM")
                    break;
                lines.Add(line);
            }

            return string.Join(Environment.NewLine, lines);
        }
    }
}
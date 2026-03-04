using System.ComponentModel;
using Portal.Content;

namespace Portal.Screens
{
    static class ReviewMenu
    {
        public static void Init()
        {
            Console.Clear();
            Console.WriteLine("Review Menu\n0 - Main menu\n1 - Escrever Resenha\n2 - Ler resenha");
            short x = short.Parse(Console.ReadLine());

            switch(x)
            {
                case 0:
                    MainMenu.Init();
                    break;
                default: 
                    Init();
                    break;
            }
        }

        public static void WriteReview()
        {
            string title = Console.ReadLine();
            string subtitle = Console.ReadLine();
            string review = ReadMultilineInput();

            Review gameReview = new Review(title, subtitle, review);
        }

        public static string ReadMultilineInput()
        {
            Console.WriteLine("Write the review (type END on a new line to finish):");

            var lines = new List<string>();

            while(true)
            {
                string? line = Console.ReadLine();

                if(line == null)
                    break;
                if(line.ToUpper() == "END")
                    break;
                lines.Add(line);
            }

            return string.Join(Environment.NewLine, lines);
        }
    }
}
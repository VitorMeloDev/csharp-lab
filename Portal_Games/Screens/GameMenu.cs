using Portal.Content;
using Portal.Savesystem;

namespace Portal.Screens
{
    static class GameMenu
    {
        public static void Init()
        {
            Console.Clear();
            Console.WriteLine("Game Menu\n0 - Menu Principal\n1 - Adicionar Jogo\n 2 - Listar jogos");
            short x = short.Parse(Console.ReadLine());

            switch(x)
            {
                case 0:
                    MainMenu.Init();
                    break;
                case 1:
                    CreateGame();
                    break;
                case 2:
                    ListAll();
                    break;
                default:
                    Init();
                    break;
            }
        }

        private static void CreateGame()
        {
            Console.Clear();
            Console.Write("Nome do jogo: ");
            string name = Console.ReadLine();
            Console.Write("Resumo do jogo: ");
            string resume = Console.ReadLine();
            Console.Write("Dia de lançamento(dd/mm/aaaa): ");
            DateOnly date = DateOnly.Parse(Console.ReadLine());
            Console.Write("Desenvolvedora: ");
            string developer = Console.ReadLine();
            Console.Write("Publicadora: ");
            string publisher = Console.ReadLine();
            
            Game game = new Game(name, resume, date, developer, publisher);
            SaveGame.Save(game);
            Console.WriteLine("Arquivo salvo!");
            Console.ReadKey();
            Init();
        }

        public static void ListAll()
        {
            Console.Clear();

            List<Game> games = SaveGame.GetAllGames();
            foreach (var game in games)
            {
                Console.WriteLine($"Titulo: {game.Title}\nAno: {game.ReleaseDay.Year}");   
            }
            Console.ReadKey();
            Init();
        }
    }
}
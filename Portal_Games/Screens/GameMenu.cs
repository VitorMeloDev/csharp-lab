using Portal.Content;
using Portal.Savesystem;

namespace Portal.Screens
{
    class GameMenu
    {
        public void Init()
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
        }

        
    }
}
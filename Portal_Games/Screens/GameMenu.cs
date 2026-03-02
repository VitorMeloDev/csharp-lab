namespace Portal.Screens
{
    class GameMenu
    {
        public void Init()
        {
            Console.Clear();
            Console.Write("Nome do jogo: ");
            string name = Console.ReadLine();
            Console.Write("Dia de lançamento(dd/mm/aaaa): ");
            DateOnly date = DateOnly.Parse(Console.ReadLine());
            
        }
    }
}
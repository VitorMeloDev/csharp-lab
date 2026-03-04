namespace Portal.Screens
{
    static class MainMenu
    {
        public static void Init()
        {
            Console.Clear();
            Console.WriteLine("Sistema Portal Games");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("1 - Escrever uma Resenha");
            Console.WriteLine("2 - Adicionar um jogo ao banco");
            Console.Write("O que gostaria de fazer? ");
            short action = short.Parse(Console.ReadLine());
        
            switch(action)
            {
                case 0: 
                    Environment.Exit(0); 
                    break;
                case 1:
                    ReviewMenu.Init();
                    break;
                case 2:
                    GameMenu.Init();
                    break;
            }
        }
    }
}
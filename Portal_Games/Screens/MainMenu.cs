namespace Portal.Screens
{
    class MainMenu
    {
        public void Init()
        {
            Console.WriteLine("O que gostaria de fazer? ");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("1 - Escrever uma Resenha");
            Console.WriteLine("2 - Adicionar um jogo ao banco");
            Console.WriteLine("3 - Adicionar uma companhia ao banco");
            short action = short.Parse(Console.ReadLine());
        
            switch(action)
            {
                case 0: Environment.Exit(0); break;
            }
        }
    }
}
namespace Stopwatch
{
    class Program
    {
        static void Main()
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Menu");
            Console.WriteLine("1 - Time in seconds");
            Console.WriteLine("2 - Time in minutes");
            Console.WriteLine("0 - exit");
            Console.Write("Choose an option: ");
            int x = int.Parse(Console.ReadLine());
            
            Console.Clear();
            switch (x)
            {
                case 0: 
                    Environment.Exit(0); 
                    break;
                case 1:
                    Console.Write("Enter a time in seconds: ");
                    int s = int.Parse(Console.ReadLine());
                    Start(s);
                    break;
                case 2:
                    Console.Write("Enter a time in minutes: ");
                    int m = int.Parse(Console.ReadLine());
                    Start(m * 60);
                    break;
                default:
                    Menu();
                    break;
            }
        }
        
        static void Start(int time)
        {
            int currentTime = 0;

            while(currentTime <= time)
            {
                Console.Clear();
                Console.Write(currentTime);
                Thread.Sleep(1000);
                currentTime++;
            }
            Console.Clear();
            Console.WriteLine("Stopwatch finished!");
            Console.ReadKey();
            Menu();
        }
    }
}
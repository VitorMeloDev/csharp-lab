namespace TextEditor
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
            Console.WriteLine("0 - Exit program");
            Console.WriteLine("1 - Open file");
            Console.WriteLine("2 - Create/Edit file");
            short s = short.Parse(Console.ReadLine());

            switch(s)
            {
                case 0:
                    Environment.Exit(0);
                    break;
                case 1:
                    ReadFile();
                    break;
                case 2:
                    EditFile();
                    break;
                default:
                    Menu();
                    break;
            }
        }

        static void ReadFile()
        {
            Console.Clear();
            Console.WriteLine("Path of the file: ");
            string path = Console.ReadLine();

            using(var file = new StreamReader(path))
            {
                string text = file.ReadToEnd();
                Console.WriteLine(text);
            }
            Console.WriteLine();
            Console.ReadKey();
            Menu();
        }

        static void EditFile()
        {
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo (ESC para sair e salvar)");
            Console.WriteLine("==========");
            string text = "";

            while (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
            }

            Save(text);
        }

        static void Save(string text)
        {
            Console.Clear();
            Console.WriteLine("Which path to save the file?");
            var path = Console.ReadLine();

            using(var file = new StreamWriter(path))
            {
                file.Write(text);
            }

            Console.WriteLine("File Saved");
            Console.ReadKey();
            Menu();
        }
    }
}
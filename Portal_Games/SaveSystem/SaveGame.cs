using System.Text.Json;
using Portal.Content;

namespace Portal.Savesystem
{
    static class SaveGame
    {
        public static void Save(Game game)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string json = JsonSerializer.Serialize(game, options);

            string folder = "Games";

            Directory.CreateDirectory(folder);

            string path = Path.Combine(folder, game.Id + ".json");

            File.WriteAllText(path, json);
        }

        public static List<Game> LoadAll()
        {
            string folder = "Games";

            if (!Directory.Exists(folder))
                return new List<Game>();

            return Directory
                .GetFiles(folder, "*.json")
                .Select(file => JsonSerializer.Deserialize<Game>(File.ReadAllText(file)))
                .Where(game => game != null)
                .ToList()!;
        }
    }    
}
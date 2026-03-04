using System.Text.Json;
using System.Threading.Tasks.Dataflow;
using Portal.Content;

namespace Portal.Savesystem
{
    static class SaveReview
    {
        public static void Save(Review review)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string json = JsonSerializer.Serialize(review, options);

            string basePath = AppContext.BaseDirectory;
            string folder = Path.Combine(basePath, "Reviews");

            Directory.CreateDirectory(folder);

            string path = Path.Combine(folder, review.Id + ".json");
            File.WriteAllText(path, json);
        }

        public static List<Review> GetReviews()
        {
            string basePath = AppContext.BaseDirectory;
            string folder = Path.Combine(basePath, "Reviews");

            if(!Directory.Exists(folder))
                return new List<Review>();

            return Directory
                .GetFiles(folder, "*.json")
                .Select(file => JsonSerializer.Deserialize<Review>(File.ReadAllText(file)))
                .Where(review => review != null)
                .ToList()!;
        }

        public static Review? GetReviewByName(string title)
        {
            string basePath = AppContext.BaseDirectory;
            string folder = Path.Combine(basePath, "Reviews");

            if (!Directory.Exists(folder))
                return null;

            return Directory.GetFiles(folder, "*.json")
                .Select(file => JsonSerializer.Deserialize<Review>(File.ReadAllText(file)))
                .FirstOrDefault(review => review != null && review.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        }
    }
}
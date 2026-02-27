namespace Portal.ContentContext
{
    public class Career : Content
    {
        public Career(string title, string url) : base(title, url)
        {
            Itens = new List<CareerItem>();
        }
        public IList<CareerItem> Itens {get; set;}
        public int TotalCourses => Itens.Count;
    }
}
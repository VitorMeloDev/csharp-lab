namespace Portal.Content
{
    class Game
    {
        public Guid Id {get; set;}
        public string Title {get; set;}
        public string Resume {get; set;}
        public DateOnly ReleaseDay {get; set;}
        public string Developer {get; set;}
        public string Publisher {get; set;}

        public Game(){}
        public Game(string title, string resume, DateOnly date, string developer, string publisher)
        {
            Id = Guid.NewGuid();
            Title = title;
            Resume = resume;
            ReleaseDay = date;
            Developer = developer;
            Publisher = publisher;
        }
    }
}
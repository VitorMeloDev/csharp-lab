namespace Portal.Content
{
    class Review
    {
        public Guid Id {get; set;}
        public string Title {get; set;}
        public string Subtitle {get; set;}
        public string GameReview {get; set;}
        public DateOnly PublicationDate {get; set;}

        public Review(){}

        public Review(string title, string subtitle, string review)
        {
            Id = Guid.NewGuid();
            PublicationDate = DateOnly.FromDateTime(DateTime.Today);
            Title = title;
            Subtitle = subtitle;
            GameReview = review;
        }
    }
}
namespace Portal.Content
{
    class Company
    {
        public Guid Id {get; set;}
        public string Name {get; set;}

        public Company()
        {
            Id = Guid.NewGuid();
        }
    }
}
using Portal.ContentContext.Enums;

namespace Portal.ContentContext
{
    public class Lecture : Base
    {
        public int Order {get; set;}
        public string Title {get; set;}
        public int DurationInMinutes {get; set;}
        public EContentLevel level {get; set;}
    }
}
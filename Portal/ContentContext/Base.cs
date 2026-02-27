using Portal.NotificationContext;

namespace Portal.ContentContext
{
    public class Base : Notifiable
    {
        public Base()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id {get; set;}
    }
}
namespace MultithreadMailCourier.Models
{
    public class Mail
    {
        public string To { get; set; }
        public string From { get; set; }
        public MailProviderType MailProviderType { get; set; }
    }

    public enum MailProviderType
    {
        Smtp = 1,
        Gmail = 2,
    }
}

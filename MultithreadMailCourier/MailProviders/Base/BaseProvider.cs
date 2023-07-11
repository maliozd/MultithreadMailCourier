using MultithreadMailCourier.Models;

namespace MultithreadMailCourier.MailProviders.Base
{
    public abstract class BaseProvider
    {
        public int Port { get; set; } = 587;
        public string ServerHostName { get; set; } = "smtp.google.com";
        public abstract Task SendAsync(Mail mail);
    }
}

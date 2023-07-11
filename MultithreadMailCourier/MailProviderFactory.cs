using MultithreadMailCourier.MailProviders;
using MultithreadMailCourier.MailProviders.Base;
using MultithreadMailCourier.Models;

namespace MultithreadMailCourier
{
    public class MailProviderFactory
    {
        public static BaseProvider CreateProvider(MailProviderType mailProviderType)
        {
            return mailProviderType switch
            {
                MailProviderType.Smtp => new SmtpProvider(),
                MailProviderType.Gmail => new GoogleMailProvider(),
                _ => throw new NotSupportedException(),
            };
        }
    }
}

using MultithreadMailCourier.MailProviders.Base;
using MultithreadMailCourier.Models;

namespace MultithreadMailCourier.MailProviders
{
    public class GoogleMailProvider : BaseProvider
    {
        public override async Task SendAsync(Mail mail)
        {
            await Task.Delay(800);
            LogManager.Instance.Log($"Gmail sent to {mail.To}");
        }
    }
}

using MultithreadMailCourier.MailProviders.Base;
using MultithreadMailCourier.Models;

namespace MultithreadMailCourier.MailProviders
{
    public class SmtpProvider : BaseProvider
    {
        public override async Task SendAsync(Mail mail)
        {
            //Send email;
            await Task.Delay(400);
            LogManager.Instance.Log($"Smtp mail sent to {mail.To}");
        }
    }
}

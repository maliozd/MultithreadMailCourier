using MultithreadMailCourier.MailProviders.Base;
using MultithreadMailCourier.Models;
using System.Collections.Concurrent;

namespace MultithreadMailCourier.Managers
{
    public class MailManager
    {
        /*
         * concurrent ---> birden fazla thread tarafından erişilebilir / aynı anda birden fazla isteği/commandi vs işleyebilir 
         * her mail işlemi için ayrı ayrı providerlar üretmek yerine MailProviders dictionaryden alacağız.
         */

        //multithreading işlemlerde bir thread-safe FIFO / queue mekanizması işlevi görür.
        //Represents a thread-safe first-in, first-out collection of objects.
        private readonly ConcurrentQueue<Mail> mailQueue = new();


        //Represents a thread-safe collection of keys and values.
        private readonly ConcurrentDictionary<MailProviderType, BaseProvider> mailProviders = new();
        public void AddMails(IEnumerable<Mail> mails)
        {
            foreach (Mail mail in mails)
                mailQueue.Enqueue(mail);
        }
        public async Task SendAllMailsAsync()
        {
            LogManager.Instance.Log("Send all mails started!");
            LogManager.Instance.Log($"{mailQueue.Count} mail found");
            string providerType = string.Empty;
            while (mailQueue.Count > 0)
            {
                mailQueue.TryDequeue(out Mail mail);
                var provider = GetProvider(mail.MailProviderType);
                providerType = mail.MailProviderType.ToString();
                await provider.SendAsync(mail);
            }
            LogManager.Instance.Log($"Send {providerType} mails finished! ");


        }
        private BaseProvider GetProvider(MailProviderType mailProviderType)
        {
            //keye karşılık value varsa existing value dönecek. yoksa ekleyip yeni eklenen valueyi dönecek.
            return mailProviders.GetOrAdd(mailProviderType, (x) => MailProviderFactory.CreateProvider(mailProviderType));

        }
    }
}

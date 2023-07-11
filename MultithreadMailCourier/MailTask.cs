using MultithreadMailCourier.Managers;
using MultithreadMailCourier.Models;
using System.ComponentModel;

namespace MultithreadMailCourier
{
    public class MailTask : INotifyPropertyChanged
    {
        private bool isRunning;
        private bool isStarted;
        private DateTime? nextRunning;

        public MailTask(MailProviderType mailProviderType)
        {
            ProviderType = mailProviderType;
        }
        public MailProviderType ProviderType { get; set; }

        public Guid TaskId { get; set; } = Guid.NewGuid();
        public bool IsRunning
        {
            get => isRunning;
            set
            {
                isRunning = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsRunning)));
            }
        }
        public bool IsStarted
        {
            get => isStarted;
            set
            {
                isStarted = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsStarted)));
            }
        }
        public int Second { get; set; }
        public DateTime? NextRunning
        {
            get => nextRunning;
            set
            {
                nextRunning = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(NextRunning)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public async Task Run(int mailCount)
        {
            var manager = new MailManager();
            while (IsStarted)
            {
                IsRunning = true;

                IEnumerable<Mail> mails = Enumerable.Empty<Mail>();
                if (ProviderType == MailProviderType.Gmail)
                    mails = DummyDataHelper.GetGoogleMails(mailCount);

                else if (ProviderType == MailProviderType.Smtp)
                    mails = DummyDataHelper.GetSmtpMails(mailCount);

                else
                    mails = DummyDataHelper.GetMails(mailCount);


                manager.AddMails(mails);
                await manager.SendAllMailsAsync();

                IsRunning = false;
                NextRunning = DateTime.Now.AddSeconds(Second);

                await Task.Delay(1000 * Second);
            }
        }
        public void Start()
        {
            IsStarted = true;

            NextRunning = DateTime.Now.AddSeconds(Second);
        }
        public void Stop()
        {
            IsStarted = false;
            NextRunning = null;
        }
    }
}

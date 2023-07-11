using MultithreadMailCourier.Models;

namespace MultithreadMailCourier
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LogManager.Instance.OnLogAdded += Instance_OnLogAdded;
        }

        private void Instance_OnLogAdded(object? sender, string e)
        {
            AddLog(e);
        }
        private void AddLog(string logMessage)
        {
            if (lbLogs.InvokeRequired)
            {
                lbLogs.Invoke(new Action(() => AddLog(logMessage)));
                return;
            }
            logMessage = $"[{DateTime.Now:dd.MM.yyyy HH:mm:ss:fff}]-{logMessage} ";
            lbLogs.Items.Add(logMessage);
            lbLogs.SelectedIndex = lbLogs.Items.Count - 1;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonListMailTasks_Click(object sender, EventArgs e)
        {

            MailTask smtpMailTask = new(MailProviderType.Smtp)
            {
                Second = 1
            };
            MailTask googleMailTask = new(MailProviderType.Gmail)
            {
                Second = 5
            };
            mailTaskBindingSource.Add(smtpMailTask);
            mailTaskBindingSource.Add(googleMailTask);
        }

        private void mailTaskBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            MailTask mailTask = mailTaskBindingSource.Current as MailTask;
            if (mailTask == null) return;
            btnStartTask.Enabled = !mailTask.IsStarted;
            btnStopTask.Enabled = mailTask.IsStarted;
            btnRunTask.Enabled = mailTask.IsStarted && !mailTask.IsRunning;

        }

        private void btnStartTask_Click(object sender, EventArgs e)
        {
            var mailTask = mailTaskBindingSource.Current as MailTask;
            if (mailTask == null) return;

            mailTask.Start();
        }

        private void btnStopTask_Click(object sender, EventArgs e)
        {
            var mailTask = mailTaskBindingSource.Current as MailTask;
            if (mailTask == null) return;

            mailTask.Stop();
        }

        private async void btnRunTask_Click(object sender, EventArgs e)
        {
            var mailTask = mailTaskBindingSource.Current as MailTask;
            if (mailTask == null) return;


            IEnumerable<Mail> mails = Enumerable.Empty<Mail>();


            await mailTask.Run(20);
        }
    }
}
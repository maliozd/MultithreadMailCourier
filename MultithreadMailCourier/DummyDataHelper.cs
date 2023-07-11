using Bogus;
using MultithreadMailCourier.Models;

namespace MultithreadMailCourier
{
    public class DummyDataHelper
    {
        public static IEnumerable<Mail> GetGoogleMails(int number)
        {
            return GetMails(number, MailProviderType.Gmail);
        }
        public static IEnumerable<Mail> GetSmtpMails(int number)
        {
            return GetMails(number, MailProviderType.Smtp);
        }
        public static IEnumerable<Mail> GetMails(int number, MailProviderType? mailProviderType = null)
        {
            Faker<Mail> faker = new Faker<Mail>().
                RuleFor(x => x.To, y => y.Internet.Email()).
                RuleFor(x => x.MailProviderType,
                y => !mailProviderType.HasValue
                ? y.PickRandom<MailProviderType>()
                : mailProviderType);
            return faker.Generate(number);
        }
    }
}

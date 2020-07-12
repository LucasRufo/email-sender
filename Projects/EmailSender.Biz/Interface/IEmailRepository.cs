using EmailSender.Data.Models;

namespace EmailSender.Biz.Interface
{
    public interface IEmailRepository
    {
        void Save(Email email);
    }
}

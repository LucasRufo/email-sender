using EmailSender.Data.Models;
using System.Linq;

namespace EmailSender.Biz.Interface
{
    public interface IEmailRepository
    {
        IQueryable<Email> GetAll();

        void Save(Email email);
    }
}

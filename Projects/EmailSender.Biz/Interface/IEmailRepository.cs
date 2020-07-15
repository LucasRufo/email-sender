using EmailSender.Data.Models;
using System.Linq;

namespace EmailSender.Biz.Interface
{
    public interface IEmailRepository
    {
        IQueryable<Email> GetAll();

        IQueryable<Email> GetById(int id);

        void Save(Email email);
    }
}

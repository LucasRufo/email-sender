using EmailSender.Biz.Base;
using EmailSender.Biz.Interface;
using EmailSender.Data.Models;

namespace EmailSender.Biz.Repository
{
    public class EmailRepository : BaseContext, IEmailRepository
    {
        public void Save(Email email)
        {
            _context.Email.Add(email);
            Commit();
        }
    }
}

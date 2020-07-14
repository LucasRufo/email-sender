using EmailSender.Entities.Models;
using EmailSender.Entities.Shared;

namespace EmailSender.Biz.Interface
{
    public interface IEmailService
    {
        Return SendEmail(EmailDTO email);
    }
}

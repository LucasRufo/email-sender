using EmailSender.Entities.Models;
using EmailSender.Entities.Shared;
using System.Collections.Generic;

namespace EmailSender.Biz.Interface
{
    public interface IEmailService
    {
        IEnumerable<EmailDTO> GetAll();

        EmailDTO GetById(int id);

        Return SendEmail(EmailDTO email);
    }
}

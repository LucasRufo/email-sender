using EmailSender.Entities.Models;
using EmailSender.Entities.Shared;
using System.Collections.Generic;

namespace EmailSender.Biz.Interface
{
    public interface IEmailService
    {
        IEnumerable<EmailDTO> GetAll();

        Return SendEmail(EmailDTO email);
    }
}

using EmailSender.Biz.Base;
using EmailSender.Biz.Interface;
using EmailSender.Biz.Mapping;
using EmailSender.Biz.Validations;
using EmailSender.Entities.Models;
using EmailSender.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;

namespace EmailSender.Biz.Core
{
    public class EmailService : BaseService, IEmailService
    {
        public readonly IEmailRepository _emailRepository;

        public EmailService(IEmailRepository emailRepository)
        {
            _emailRepository = emailRepository;
        }

        public IEnumerable<EmailDTO> GetAll()
        {
            var emailList = _emailRepository.GetAll().ToList();

            return new EmailMapping().ToEmailDTOMap(emailList);
        }

        public Return SendEmail(EmailDTO emailDTO)
        {
            var ret = IsValid(emailDTO);
            if (!ret.Success) return ret;

            var smtpClient = CreateEmail();
            
            smtpClient.Send(CreteMailMessage(emailDTO));

            var email = new EmailMapping().ToEmailMap(emailDTO);
            _emailRepository.Save(email);

            return new Return();
        }

        private MailMessage CreteMailMessage(EmailDTO email)
        {
            var mailMessage = new MailMessage
            {
                From = new MailAddress("emailsenderGitHub@gmail.com"),
                Subject = email.Assunto,
                Body = email.Corpo
            };

            mailMessage.To.Add(email.To);

            return mailMessage;
        }

        private SmtpClient CreateEmail()
        {
            return new SmtpClient("smtp.gmail.com")
            {
                EnableSsl = true,
                Port = 587,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("emailsenderGitHub@gmail.com", "emailsender123")
            };
        }

        private Return IsValid(EmailDTO emailDTO)
        {
            var retorno = new Return();

            ExecutarValidacao(new EmailValidator(), emailDTO, retorno);

            return retorno;
        }
    }
}

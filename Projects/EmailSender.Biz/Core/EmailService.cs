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
                From = new MailAddress("rifelu25@gmail.com"),
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
                Port = 587,
                Credentials = new NetworkCredential("rifelu25@gmail.com", "rufo252105"),
                EnableSsl = true,
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

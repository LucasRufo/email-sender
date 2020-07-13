using EmailSender.Biz.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailSender.Biz.Core
{
    public class EmailService : IEmailService
    {
        public readonly IEmailRepository _emailRepository;

        public EmailService(IEmailRepository emailRepository)
        {
            _emailRepository = emailRepository;
        }


    }
}

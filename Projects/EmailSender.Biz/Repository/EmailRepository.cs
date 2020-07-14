using EmailSender.Biz.Base;
using EmailSender.Biz.Interface;
using EmailSender.Data.Models;
using System;

namespace EmailSender.Biz.Repository
{
    public class EmailRepository : BaseContext, IEmailRepository
    {
        public void Save(Email email)
        {
            email.Fl_Ativo = true;
            email.Dt_Criacao = DateTime.Now;

            _context.Email.Add(email);
            Commit();
        }
    }
}

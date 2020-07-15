using EmailSender.Biz.Base;
using EmailSender.Biz.Interface;
using EmailSender.Data.Models;
using System;
using System.Linq;

namespace EmailSender.Biz.Repository
{
    public class EmailRepository : BaseContext, IEmailRepository
    {
        public IQueryable<Email> GetAll() => _context.Email.AsNoTracking();
        
        public void Save(Email email)
        {
            email.Fl_Ativo = true;
            email.Dt_Criacao = DateTime.Now;

            _context.Email.Add(email);
            Commit();
        }
    }
}

using EmailSender.Data.Models;
using EmailSender.Entities.Models;
using System.Collections.Generic;

namespace EmailSender.Biz.Mapping
{
    public class EmailMapping
    {
        public Email ToEmailMap(EmailDTO emailDTO)
        {
            return new Email()
            {
                Ds_Assunto = emailDTO.Assunto,
                Ds_Corpo = emailDTO.Corpo,
                Ds_To = emailDTO.To,
            };
        }

        public IEnumerable<EmailDTO> ToEmailDTOMap(IEnumerable<Email> emailList)
        {
            var list = new List<EmailDTO>();

            foreach (var email in emailList)
                list.Add(ToEmailDTOMap(email));

            return list;
        }

        public EmailDTO ToEmailDTOMap(Email email)
        {
            return new EmailDTO()
            {
                Assunto = email.Ds_Assunto,
                Corpo = email.Ds_Corpo,
                ID = email.Id_Email,
                To = email.Ds_To,
                DataEnvio = email.Dt_Criacao
            };
        }
    }
}

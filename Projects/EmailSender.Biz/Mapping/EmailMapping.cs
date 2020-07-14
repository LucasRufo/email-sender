using EmailSender.Data.Models;
using EmailSender.Entities.Models;

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
                Anexo = new AnexoMapping().ToAnexoListMap(emailDTO.AnexoDTO) 
            };
        }
    }
}

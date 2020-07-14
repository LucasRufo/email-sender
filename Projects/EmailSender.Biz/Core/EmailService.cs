using EmailSender.Biz.Base;
using EmailSender.Biz.Interface;
using EmailSender.Biz.Mapping;
using EmailSender.Biz.Validations;
using EmailSender.Entities.Models;
using EmailSender.Entities.Shared;
using System.Linq;

namespace EmailSender.Biz.Core
{
    public class EmailService : BaseService, IEmailService
    {
        public readonly IEmailRepository _emailRepository;

        public readonly IAnexoService _anexoService;

        public EmailService(IEmailRepository emailRepository,
                            IAnexoService anexoService)
        {
            _emailRepository = emailRepository;
            _anexoService = anexoService;
        }

        public Return SendEmail(EmailDTO emailDTO)
        {
            var ret = IsValid(emailDTO);
            if (!ret.Success) return ret;

            CreateEmail(emailDTO);

            var email = new EmailMapping().ToEmailMap(emailDTO);
            _emailRepository.Save(email);

            return new Return();
        }

        private object CreateEmail(EmailDTO email)
        {
            if (email.AnexoDTO != null && email.AnexoDTO.Any())
                _anexoService.SaveFiles(email.AnexoDTO);

            return new { };
        }

        private Return IsValid(EmailDTO emailDTO)
        {
            var retorno = new Return();

            ExecutarValidacao(new EmailValidator(), emailDTO, retorno);

            foreach (var anexoDTO in emailDTO.AnexoDTO)
                ExecutarValidacao(new AnexoValidator(), anexoDTO, retorno);

            return retorno;
        }
    }
}

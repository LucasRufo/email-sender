using EmailSender.Biz.Interface;
using EmailSender.Entities.Models;
using System.Web.Http;

namespace EmailSender.WebApi.Controllers
{
    public class EmailController : BaseController
    {

        private readonly IEmailService _emailService;

        public EmailController(IEmailService emailService)
        {
            _emailService = emailService;
        }

        public IHttpActionResult Get()
        {
            return Ok(new string[] { "Batata", "Teste", "Yeah" });
        }

        public IHttpActionResult Post([FromBody] EmailDTO email)
        {
            var retorno = _emailService.SendEmail(email);

            if (!retorno.Success)
                return BadRequest(retorno.Errors);

            return Ok(retorno.Objeto);
        }

    }
}
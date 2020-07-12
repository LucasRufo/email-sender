using System.Collections.Generic;
using System.Web.Http;

namespace EmailSender.WebApi.Controllers
{
    public class EmailController : ApiController
    {
        public IHttpActionResult Get()
        {
            return Ok("Yeah boy");
        }

        public IHttpActionResult Post([FromBody] Email email)
    }
}
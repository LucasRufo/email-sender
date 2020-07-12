using System.Collections.Generic;
using System.Web.Http;

namespace EmailSender.WebApi.Controllers
{
    public class EmailController : ApiController
    {
        public IHttpActionResult Get()
        {
            return Ok();
        }
    }
}
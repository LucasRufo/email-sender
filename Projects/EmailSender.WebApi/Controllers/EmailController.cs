using EmailSender.WebApi.Models;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace EmailSender.WebApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class EmailController : ApiController
    {
        public IHttpActionResult Get()
        {
            return Ok(new string[] { "Batata", "Teste", "Yeah" });
        }

        public IHttpActionResult Post([FromBody] EmailDTO email)
        {


            return Ok();
        }
    }
}
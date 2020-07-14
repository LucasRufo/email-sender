using System.Net;
using System.Web.Http;

namespace EmailSender.WebApi.Controllers
{
    public class BaseController : ApiController
    {
        protected IHttpActionResult BadRequest<T>(T obj)
        {
            return Content(HttpStatusCode.BadRequest, obj);
        }
    }
}

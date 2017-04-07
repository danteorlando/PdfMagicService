using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;
using PdfMagic.Model;

namespace PdfMagicService.Controllers
{
    public class PdfMagicController : ApiController
    {
        public HttpResponseMessage GetHello()
        {
            return Request.CreateResponse("Hello pdf");
        }

        [HttpGet]
        public Form GetForm(int Id)
        {
            return new Form();
        }

        [HttpGet]
        public List<Form> GetForms()
        {
            return new List<Form>();
        }
    }
}

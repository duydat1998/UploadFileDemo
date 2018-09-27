using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace UploadFileDemo.Controllers
{
    public class HomeController : ApiController
    {
        // GET: Home

        public ActionResult fileupload()
        {
            return View();
        }
    }
}

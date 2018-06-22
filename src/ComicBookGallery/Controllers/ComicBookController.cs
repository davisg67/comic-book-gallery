using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBookController : Controller
    {
        public ActionResult Detail()
        {
            //ActionResult is the base class for ContentResult and RedirectResult.
            //return new RedirectResult("/"); root of website
            return Content("Hello from the comic books controller!");
            
            
        }
    }
}
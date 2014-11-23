using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Google.Auth.Mvc.Empty.Models;

namespace Google.Auth.Mvc.Empty.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //string provider = "GooglePlus";
            //string returnUrl = "";
            //return new AccountController.ChallengeResult(provider, Url.Action("ExternalLoginCallback", "Account", new { ReturnUrl = returnUrl }));
            //return View(new ExternalLoginListViewModel());
            return View();
        }
    }
}
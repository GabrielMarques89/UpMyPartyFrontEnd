using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UpMyPartyFrontEnd.Controllers
{
    public class ContaController : Controller
    {
        public ActionResult Cadastro()
        {
            return View();
        }
        public ActionResult Index()
        {
            return Cadastro();
        }
    }
}
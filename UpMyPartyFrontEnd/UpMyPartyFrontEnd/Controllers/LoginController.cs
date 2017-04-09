#region Imports

using System.Web.Mvc;

#endregion

namespace UpMyPartyFrontEnd.Controllers
{
    [Authorize]
    public class LoginController : Controller
    {
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }
    }
}
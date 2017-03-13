using patent.DAL.DataProvider;
using System.Web.Mvc;

namespace patent.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Views/Home/Main.cshtml", null);
        }

        #region privite fields

        private ServiceDBRepository repository;

        #endregion

        #region constructor

        public HomeController()
        {
            repository = new ServiceDBRepository();
        }

        #endregion
    }
}
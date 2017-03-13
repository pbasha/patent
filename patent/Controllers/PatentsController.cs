using patent.DAL.DataProvider;
using System.Web.Mvc;

namespace patent.Controllers
{
    public class PatentsController : Controller
    {
        #region constructor

        public PatentsController()
        {
            repositiry = new ServiceDBRepository();
        }

        #endregion

        #region post

        [Authorize]
        public ActionResult GetPatents()
        {
            var patents = repositiry.GetAllPatents();
            return PartialView("~/Views/Patents/_partialPatentsList.cshtml", patents);
        }

        #endregion

        #region private logic

        ServiceDBRepository repositiry;

        #endregion
    }
}

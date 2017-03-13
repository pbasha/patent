using patent.DAL.DataProvider;
using patent.DAL.EFModels;
using System.Collections.Generic;
using System.Web.Http;

namespace patent.Controllers
{
    public class PatentsApiController : ApiController
    {

        #region constructor

        public PatentsApiController()
        {
            repositiry = new ServiceDBRepository();
        }

        #endregion

        #region post

        public IEnumerable<Patent> Get()
        {
            return repositiry.GetAllPatents();
        }

        #endregion

        #region private logic

        ServiceDBRepository repositiry;

        #endregion
    }
}

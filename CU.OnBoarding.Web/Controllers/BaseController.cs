using CU.OnBoarding.Web.Models;
using System.Web.Mvc;

namespace CU.OnBoarding.Web.Controllers
{
    [CheckAuthorization]
    public abstract class BaseController : Controller
    {
        // GET: Base
        public BaseController()
        {
        }
        private SessionProfile _currentProfile;
        public SessionProfile CurrentProfile
        {
            get
            {
                if (_currentProfile == null)
                {
                    _currentProfile = ProfileHelper.Profile;
                }

                return _currentProfile;
            }
        }
    }
}
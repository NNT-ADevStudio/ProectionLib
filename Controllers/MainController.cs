using ProectionLib.Models.HelperModels;

namespace ProectionLib.Controllers
{
    public class MainController
    {
        protected Auth Auth { get; set; }

        public virtual string ControllerUrl { get; }

        public MainController(Auth auth)
        {
            Auth = auth;
        }
    }
}

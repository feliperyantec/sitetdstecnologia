using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TDSTecnologia.Site.Core.Entities;

namespace TDSTecnologia.Site.Web.Controllers
{
    public class AbstractController : Controller
    {
        protected readonly UserManager<Usuario> userManager;

        public AbstractController(UserManager<Usuario> userManager)
        {
            this.userManager = userManager;
        }

        public AbstractController()
        {
        }

    }
}

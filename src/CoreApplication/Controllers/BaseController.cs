using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace CoreApplication.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class BaseController : Controller
    {
    }
}

using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AspCore_AutenticaCookie.Controllers
{
    [Authorize]
    public class UsuarioController : Controller
    {
       public IActionResult UsuarioHome()
       {
          return View();
       }

       [HttpGet]
       public async Task<IActionResult> Logout()
       {
           await HttpContext.SignOutAsync();
           return RedirectToAction("LoginUsuario", "Login");
       }
    }
}
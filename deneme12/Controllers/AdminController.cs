using deneme12.Entity;
using deneme12.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace deneme12.Controllers
{
    public class AdminController : Controller
    {
      
        private readonly SignInManager<AppUser> _signInManager;
        public AdminController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }
        public IActionResult Index()
        {
            return View(new LoginModel());
        }
        [HttpPost]
        public IActionResult Index(LoginModel model)
        {
            if(ModelState.IsValid)
            {
               var signInresult = _signInManager.PasswordSignInAsync(model.UserName, model.Password, model.RememberMe, false).Result;
           if(signInresult.Succeeded)
                {
                    return RedirectToAction("Index", "Yonetici");
                }
                ModelState.AddModelError("", "Kullanıcı adı veya şifre hatalı");
           
            }

            return View(model);
        }
    }
}

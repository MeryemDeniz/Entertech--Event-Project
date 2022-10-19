
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Event_Project.Controllers.Admin.Login
{
    public class Login : Controller
    {
        private readonly Admin.Admin.CookieHelper cookieHelper;
        private readonly Controllers.Admin.Admin.RequestHelper requestHelper;
        public Login(Controllers.Admin.Admin.CookieHelper cookieHelper, Controllers.Admin.Admin.RequestHelper requestHelper)
        {
            this.cookieHelper = cookieHelper;
            this.requestHelper = requestHelper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var cookies = HttpContext.Request.Cookies;
            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginView model)
        {
            if (!model.IsCompany)
            {
                var request = requestHelper.Action<Users>($"user/{model.UserName}/{model.Password}", ActionType.Get, null);
                var result = request.Result.Data;
                if (result is not null)
                {
                    string role = (result.Role == 1) ? "user" : "admin";
                    var claims = new List<Claim>
                    {
                        new Claim("Id",result.UserId.ToString()),
                        new Claim(ClaimTypes.Role,role)
                    };
                    cookieHelper.SignIn(claims, model.RememberMe, HttpContext, $"{role}_scheme");
                    return RedirectToAction(nameof(Index), role);
                }
            }
            else
            {
                var request = requestHelper.Action<Companies>($"entegrator/{model.UserName}/{model.Password}", ActionType.Get, null);
                var result = request.Result.Data;
                if (result is not null)
                {
                    string role = "company";
                    List<Claim> claims = new List<Claim>
                    {
                        new Claim("ID",result.CompanyId.ToString()),
                        new Claim(ClaimTypes.Role,role)
                    };
                    cookieHelper.SignIn(claims, model.RememberMe, HttpContext, $"{role}_scheme");
                    return RedirectToAction(nameof(Index), role);
                }
            }
            ViewBag.Error = "Username or password is wrong...";
            return View();
        }
    }
}


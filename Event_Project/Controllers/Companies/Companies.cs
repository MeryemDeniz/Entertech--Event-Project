using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Event_Project.Controllers.Companies
{
    [Authorize(AuthenticationSchemes = "companies_scheme")]
    public class Companies : Controller
    {
        private readonly Admin.Admin.CookieHelper cookieHelper;
        private readonly Admin.Admin.RequestHelper requestHelper;
        private static Companies companies;

        public object ActionType { get; private set; }

        public Companies(Admin.Admin.CookieHelper cookieHelper, Admin.Admin.RequestHelper requestHelper)
        {
            this.cookieHelper = cookieHelper;
            this.requestHelper = requestHelper;
        }
        private void GetCompany()
        {
            string id = HttpContext.User.Claims.FirstOrDefault(u => u.Type.Equals("Id"))?.Value;
            companies = requestHelper.Action<Companies>($"company/{id}?include=1", ActionType.Get, null).Result.Data;
        }
        public IActionResult Index()
        {
            GetCompany();
            return View(companies);
        }

    }
}

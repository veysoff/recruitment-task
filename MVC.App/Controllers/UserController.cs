using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC.App.Models;

namespace MVC.App.Controllers
{
    public class UserController : Controller
    {
        public ActionResult Index()
        {
            return View("Edit", new UserViewModel());
        }

        public ActionResult Details(UserViewModel userViewModel)
        {
            return View(userViewModel);
        }

        public ActionResult Create(UserViewModel userViewModel)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction(nameof(Details), userViewModel);
            }

            return RedirectToAction(nameof(Index));
        }
    }
}

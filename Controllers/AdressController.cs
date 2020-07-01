using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CvNetCore2.Models;
using CvNetCore2.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CvNetCore2.Controllers
{
    public class AdressController : Controller
    {
        private IMainRepository context;


        public AdressController(IMainRepository ctx)
        {
            context = ctx;

        }
        public ViewResult Index() => View(new MainPage
        {
            UserAdresses = context.UserAdresses,

        });

        [HttpPost]
        public IActionResult EditAdress(UserAdress user)
        {
            if (ModelState.IsValid)
            {
                context.SaveAdress(user);

                return RedirectToAction("Index");

            }
            else return View(user);
        }

    }
}
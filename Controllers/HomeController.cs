using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CvNetCore2.Models;
using CvNetCore2.Models.ViewModels;


namespace CvNetCore2.Controllers
{
    public class HomeController : Controller
    {
        private IMainRepository context;
       

        public HomeController(IMainRepository ctx)
        {
            context = ctx;
            
        }
        public ViewResult Index() => View(new MainPage
        {
            UserDetails = context.UserDetails,
            
        });

        [HttpPost]
        public IActionResult EditUser(UserDetails user)
        {
            if (ModelState.IsValid)
            {
                context.SaveUser(user);
                
                return RedirectToAction("Index");

            }
            else return View(user);
        }


       




    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CvNetCore2.Models;
using CvNetCore2.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CvNetCore2.Controllers
{
    public class AboutController : Controller
    {
        private IMainRepository context;


        public AboutController(IMainRepository ctx)
        {
            context = ctx;

        }

        public ViewResult Index() => View(new MainPage
        {
            Abouts = context.Abouts
        });

        [HttpPost]
        public IActionResult EditAbout(About about)
        {
            if (ModelState.IsValid)
            {
                context.SaveAbout(about);
                return RedirectToAction("Index");
            }
            else return View(about);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CvNetCore2.Models;
using CvNetCore2.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CvNetCore2.Controllers
{
    public class HobbiesController : Controller
    {
        private IMainRepository context;
        public HobbiesController(IMainRepository ctx)
        {
            context = ctx;
        }
        public ViewResult Index() => View(new MainPage
        {
            Hobbies = context.Hobbies
        });

        [HttpPost]
        public IActionResult EditHobby(Hobby hobbies)
        {
            if (ModelState.IsValid)
            {
                context.SaveHobbies(hobbies);
                return RedirectToAction("Index");
            }
            else
            {
                return View(hobbies);
            }
        }


        [HttpPost]
        public IActionResult DeleteHobbies(int HobbyID)
        {
            Hobby dbEntry = context.DeleteHobbies(HobbyID);

            return RedirectToAction("Index");

        }
    }
}
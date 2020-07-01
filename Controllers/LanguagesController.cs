using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CvNetCore2.Models;
using CvNetCore2.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CvNetCore2.Controllers
{
    public class LanguagesController : Controller
    {
        private IMainRepository context;
        public LanguagesController(IMainRepository ctx)
        {
            context = ctx;
        }
        public ViewResult Index() => View(new MainPage
        {
            Languages = context.Languages
        });

        [HttpPost]
        public IActionResult EditLanguages(Language languages)
        {
            if (ModelState.IsValid)
            {
                context.SaveLanguages(languages);
                return RedirectToAction("Index");
            }
            else
            {
                return View(languages);
            }
        }


        [HttpPost]
        public IActionResult DeleteLanguages(int LanguageID)
        {
            Language dbEntry = context.DeleteLanguages(LanguageID);

            return RedirectToAction("Index");

        }
    }
}
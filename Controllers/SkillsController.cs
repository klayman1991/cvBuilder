using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CvNetCore2.Models;
using CvNetCore2.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CvNetCore2.Controllers
{
    public class SkillsController : Controller
    {
        private IMainRepository context;
        public SkillsController(IMainRepository ctx)
        {
            context = ctx;
        }
        public ViewResult Index() => View(new MainPage
        {
            Skills = context.Skills
        });

        [HttpPost]
        public IActionResult EditSkills(Skills skills)
        {
            if (ModelState.IsValid)
            {
                context.SaveSkills(skills);
                return RedirectToAction("Index");
            }
            else
            {
                return View(skills);
            }
        }


        [HttpPost]
        public IActionResult DeleteSkills(int SkillsID)
        {
            Skills dbEntry = context.DeleteSkills(SkillsID);

            return RedirectToAction("Index");

        }
    }
}
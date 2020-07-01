using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CvNetCore2.Models;
using CvNetCore2.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CvNetCore2.Controllers
{
    public class CoursesController : Controller
    {
        private IMainRepository context;
        public CoursesController(IMainRepository ctx)
        {
            context = ctx;
        }
        public ViewResult Index() => View(new MainPage
        {
            Courses = context.Courses
        });

        [HttpPost]
        public IActionResult EditCourse(Courses courses)
        {
            if (ModelState.IsValid)
            {
                context.SaveCourses(courses);
                return RedirectToAction("Index");
            }
            else
            {
                return View(courses);
            }
        }


        [HttpPost]
        public IActionResult DeleteCourse(int CoursesID)
        {
            Courses dbEntry = context.DeleteCourse(CoursesID);

            return RedirectToAction("Index");

        }
    }
}
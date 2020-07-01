using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CvNetCore2.Models;
using CvNetCore2.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Rotativa.AspNetCore;

namespace CvNetCore2.Controllers
{
    public class GeneratorController : Controller
    {
        private IMainRepository context;
        private MainPage mainPage;

        public GeneratorController(IMainRepository ctx)
        {
            context = ctx;
            mainPage = new MainPage
            {
                Skills = context.Skills,
                Abouts = context.Abouts,
                Courses = context.Courses,
                Languages = context.Languages,
                Hobbies = context.Hobbies,
                Works = context.Works,
                UserDetails = context.UserDetails,
                UserAdresses = context.UserAdresses
            };


        }

        public ViewResult Index() => View(mainPage);


      

        public IActionResult Pdf()
        {
            return new ViewAsPdf("Pdf", mainPage)
            { PageMargins = { Left = 20, Bottom = 20, Right = 20, Top = 20 } }
            ;
        }

    }
}
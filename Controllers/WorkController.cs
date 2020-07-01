using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CvNetCore2.Models;
using CvNetCore2.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CvNetCore2.Controllers
{
    public class WorkController : Controller
    {
        private IMainRepository context;
       // private AddWorkDescription workDescription;

        public WorkController(IMainRepository ctx/*, AddWorkDescription add*/)
        {
            context = ctx;
        //    workDescription = add;
        }

        public ViewResult Index() => View(new MainPage
        {
            Works = context.Works

        });

        [HttpPost]
        public IActionResult EditWork(Work work)
        {
            if (ModelState.IsValid)
            {
                context.SaveWork(work);
                return RedirectToAction("Index");
            }
            else
            {
                return View(work);
            }
        }

        //[HttpPost]
        //public IActionResult EditWorkDescription(int workID, string workDesc)
        //{
        //    Work work = context.Works.FirstOrDefault(p => p.WorkID == workID);

        //    if(work != null)
        //    {
        //        workDescription.AddDescription(work, workDesc);
        //    }
        //    return View("Index");
        //}
    }
}
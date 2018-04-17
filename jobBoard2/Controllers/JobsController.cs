using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Jobs.Models;

namespace Jobs.Controllers
{
    public class JobsController : Controller
    {
      [HttpGet("/jobs")]
      public ActionResult Index()
      {
          List<Job> allJobs = Job.GetAll();
          return View(allJobs);
      }

      [HttpGet("/jobs/new")]
      public ActionResult JobForm()
      {
          return View();
      }
      [HttpPost("/jobs")]
      public ActionResult Create()
      {
        Job newJob = new Job (Request.Form["title"],(Request.Form["description"]));
        newJob.Save();
        List<Job> allJobs = Job.GetAll();
        return View("Index", allJobs);
      }
      [HttpPost("/delete")]
        public ActionResult DeleteAll()
        {
            Job.ClearAll();
            return View("JobForm");
        }
    }
}

using Nancy;
using System.Collections.Generic;
using System.IO;
using JobBoard.Objects;

namespace JobBoard
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        if (Job.GetCounter() == 0)
        {
          return View["no-jobs.cshtml"];
        }
        else
        {
          return View["index.cshtml", Job.JobList()];
        }
      };
      Post["/add-job"] = _ => {
        Job newJob = new Job(Request.Form["job-name"], Request.Form["job-description"], Request.Form["job-contact"]);
        return View["add-jobs.cshtml"];
      };
    }
  }
}

using Nancy;
using System.Collections.Generic;
using jobBoard.Objects;

namespace jobBoard
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>
      {
        List<Job> currentJobs = Job.GetJobs();
        return View["jobList.cshtml", currentJobs];
      };
      Get["/newJob"] = _ => View["newJob.cshtml"];
      Post["/jobList"] = _ =>
      {
        Contact newContact = new Contact(Request.Form["contactName"], Request.Form["contactEmail"], Request.Form["contactPhone"]);
        Job newJob = new Job(Request.Form["title"], Request.Form["description"], newContact);
        List<Job> currentJobs = Job.GetJobs();
        return View["jobList.cshtml", currentJobs];
      };
      Get["/jobDetail/{id}"] = parameters =>
      {
        Job currentJob = Job.SearchID(parameters.id);
        return View["jobDetails.cshtml", currentJob];
      };
    }
  }
}

using Microsoft.AspNetCore.Mvc;

namespace DoctorsOffice.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      ViewBag.PageTitle = ("Dr. Sillystringz's Factory");
      ViewBag.Header = ("Welcome to the Factory!");
      return View();
    }
  }
}
using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Linq;

namespace DoctorsOffice.Controllers
{
  public class HomeController : Controller
  {

    private readonly FactoryContext _db;

    public HomeController(FactoryContext db)
    {
      _db = db;
    }
    [HttpGet("/")]
    public ActionResult Index()
    {
      ViewBag.PageTitle = ("Dr. Sillystringz's Factory");
      ViewBag.Header = ("Welcome to the Factory!");
      ViewBag.AllEngineers = _db.Engineers.ToList();
      ViewBag.AllMachines = _db.Machines.ToList();
      return View();
    }
  }
}
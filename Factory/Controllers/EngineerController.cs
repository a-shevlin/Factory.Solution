using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Collections.Generic;
using System.Linq;

namespace Factory.Controllers
{
  public class EngineerController : Controller
  {
    private readonly FactoryContext _db;

    public EngineerController(FactoryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      ViewBag.PageTitle = ("Engineers");
      ViewBag.Header = ("Engineers");
      List<Engineer> model = _db.Engineers.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      ViewBag.PageTitle = ("Add Engineer");
      ViewBag.Header = ("Add Engineer");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Engineer engineer)
    {
      _db.Engineers.Add(engineer);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Engineer thisEngineer = _db.Engineers.FirstOrDefault(engineer => engineer.Id == id);
      ViewBag.PageTitle = (thisEngineer.Name + " Details");
      ViewBag.Header = ("Engineer " + thisEngineer.Name + " Details");
      return View(thisEngineer);
    }

    public ActionResult Edit(int id)
    {
      var thisEngineer = _db.Engineers.FirstOrDefault(engineer => engineer.Id == id);
      ViewBag.PageTitle = ("Edit " + thisEngineer.Name);
      ViewBag.Header = ("Edit " + "Engineer " + thisEngineer.Name);
      return View(thisEngineer);
    }

    [HttpPost]
    public ActionResult Edit(Engineer engineer)
    {
      _db.Entry(engineer).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}
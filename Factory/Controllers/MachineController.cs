using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Collections.Generic;
using System.Linq;

namespace Factory.Controllers
{
  public class MachineController : Controller
  {
    private readonly FactoryContext _db;

    public MachineController(FactoryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      ViewBag.PageTitle = ("Machines");
      ViewBag.Header = ("Machines");
      List<Machine> model = _db.Machines.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      ViewBag.PageTitle = ("Add Machine");
      ViewBag.Header = ("Add Machine");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Machine machine)
    {
      _db.Machines.Add(machine);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Machine thisMachine = _db.Machines.FirstOrDefault(machine => machine.Id == id);
      ViewBag.PageTitle = (thisMachine.Model + " Details");
      ViewBag.Header = ("The " + thisMachine.Model + " Machine");
      return View(thisMachine);
    }

    public ActionResult Edit(int id)
    {
      var thisMachine = _db.Machines.FirstOrDefault(machine => machine.Id == id);
      ViewBag.PageTitle = ("Edit " + thisMachine.Model);
      ViewBag.Header = ("Edit " + "Machine " + thisMachine.Model);
      return View(thisMachine);
    }

    [HttpPost]
    public ActionResult Edit(Machine machine)
    {
      _db.Entry(machine).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisMachine = _db.Machines.FirstOrDefault(machine => machine.Id == id);
      ViewBag.PageTitle = ("Delete " + thisMachine.Model);
      ViewBag.Header = ("Delete " + "Machine " + thisMachine.Model);
      return View(thisMachine);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisMachine = _db.Machines.FirstOrDefault(machine => machine.Id == id);
      _db.Machines.Remove(thisMachine);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [HttpPost]
    public ActionResult DeleteEngineer(int joinId)
    {
      var joinEntry = _db.EngineerMachine.FirstOrDefault(entry => entry.Id == joinId);
      _db.EngineerMachine.Remove(joinEntry);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult AddEngineer(int id)
    {
      var thisMachine = _db.Machines.FirstOrDefault(Machine => Machine.Id == id);
      ViewBag.EngineerId = new SelectList(_db.Engineers, "Id", "Name");
      ViewBag.PageTitle = ("License for " + thisMachine.Model);
      ViewBag.Header = ("License for " + thisMachine.Model + " Machine");
      return View(thisMachine);
    }

    [HttpPost]
    public ActionResult AddEngineer(Machine machine, int EngineerId)
    {
      if (EngineerId != 0)
      {
        _db.EngineerMachine.Add(new EngineerMachine() { EngineerId = EngineerId, MachineId = machine.Id });
        _db.SaveChanges();
      }
      return RedirectToAction("Index");
    }
  }
}
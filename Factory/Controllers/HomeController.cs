using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Factory.Models;

namespace Factory.Controllers
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
      var machines = _db.Machines.ToList();
      var engineers = _db.Engineers.ToList();
      ViewBag.Engineers = engineers;
      ViewBag.Machines = machines;
      return View();
    }
  }
}
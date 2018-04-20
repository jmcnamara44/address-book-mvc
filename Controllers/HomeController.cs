using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AddressBook.Models;

namespace AddressBook.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        List<Addresses> allContacts = Addresses.GetAll();
        return View(allContacts);
      }
      [HttpGet("/create-form")]
      public ActionResult CreateForm()
      {
        return View();
      }
      [HttpPost("/create-address")]
      public ActionResult CreateAddress()
      {
      Addresses newAddress = new Addresses(Request.Form["name"], Request.Form["address"], Request.Form["phone-number"]);
      newAddress.Save();
      List<Addresses> allContacts = Addresses.GetAll();
      return View("Index", allContacts);
      }
      [HttpGet("/delete")]
      public ActionResult Delete()
      {
        Addresses.ClearAll();
        List<Addresses> allContacts = Addresses.GetAll();
        return View("Index", allContacts);
      }

    }
}

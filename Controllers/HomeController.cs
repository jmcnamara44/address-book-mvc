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


        return View();
      }
      [HttpGet("/create-form")]
      public ActionResult CreateForm()
      {

        return View();
      }


    }
}

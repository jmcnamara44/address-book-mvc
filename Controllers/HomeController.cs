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
            List<Contact> allContacts = Contact.GetAll();
            return View(allContacts);
        }
        [HttpGet("/create-form")]
        public ActionResult CreateForm()
        {
            return View();
        }
        [HttpPost("/create-contact")]
        public ActionResult CreateContact()
        {
            Address newAddress = new Address(Request.Form["street-address"], Request.Form["city"], Request.Form["state"], Request.Form["zip-code"]);
            Contact newContact = new Contact(Request.Form["name"], newAddress, Request.Form["phone-number"]);
            newContact.Save();
            List<Contact> allContacts = Contact.GetAll();
            return View("Index", allContacts);
        }
        [HttpGet("/delete")]
        public ActionResult Delete()
        {
            Contact.ClearAll();
            List<Contact> allContacts = Contact.GetAll();
            return View("Index", allContacts);
        }
    }
}

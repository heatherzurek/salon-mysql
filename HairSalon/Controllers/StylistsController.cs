using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;

namespace HairSalon.Controllers
{

    public class StylistController : Controller
    {

        [HttpGet("/stylists")]
        public ActionResult Index()
        {
            List<Stylist> allStylists = Stylist.GetAll();
            return View(allStylists);
        }

        [HttpGet("/stylists/new")]
        public ActionResult New()
        {
          return View();
        }

        [HttpPost("/stylists")]
        public ActionResult Create(string stylistName)
        {
            Stylist newStylist = new Stylist(stylistName);
            // newStylist.Save();
            List<Stylist> allStylists = Stylist.GetAll();
            return View("Index", allStylists);
        }

        // [HttpGet("/categories/{id}")]
        // public ActionResult Show(int id)
        // {
        //     Dictionary<string, object> model = new Dictionary<string, object>();
        //     Stylist selectedCategory = Category.Find(id);
        //     List<Item> categoryItems = selectedCategory.GetItems();
        //     model.Add("category", selectedCategory);
        //     model.Add("items", categoryItems);
        //     return View(model);
        // }
        //
        // [HttpPost("/categories/{categoryId}/items")]
        // public ActionResult Create(int categoryId, string itemDescription, DateTime itemDueDate)
        // {
        //     Dictionary<string, object> model = new Dictionary<string, object>();
        //     Category foundCategory = Category.Find(categoryId);
        //     Item newItem = new Item(itemDescription, itemDueDate, categoryId);
        //     newItem.Save();
        //     List<Item> categoryItems = foundCategory.GetItems();
        //     model.Add("items", categoryItems);
        //     model.Add("category", foundCategory);
        //     return View("Show", model);
        // }

    }

}

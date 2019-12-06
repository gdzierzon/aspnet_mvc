using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EfDemo.Models;
using EfDemo.Models.Data;

namespace EfDemo.Controllers
{
    public class HomeController : Controller
    {
        pubsEntities db;

        public HomeController()
        {
            db = new pubsEntities();
        }

        //list of authors
        public ActionResult Index()
        {
            var authors = (from a in db.authors
                           orderby a.au_lname, a.au_fname
                           select a).ToList();

            return View(authors);
        }

        //display form to create a new author
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        //process the create form submission
        [HttpPost]
        public ActionResult Create(author author)
        {
            author.au_id = author.phone;
            author.contract = true;

            if (ModelState.IsValid)
            {
                db.authors.Add(author);
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(author);
        }

        //display form to edit an author
        [HttpGet]
        public ActionResult Edit(string id)
        {
            var author = (from a in db.authors
                          where a.au_id == id
                          select a).SingleOrDefault();

            return View(author);
        }

        //process the edit form submission
        [HttpPost]
        public ActionResult Edit(author formInput)
        {
            if (ModelState.IsValid)
            {
                //the author object is tracked by the pubsEntities database context
                var author = (from a in db.authors
                                    where a.au_id == formInput.au_id
                                    select a).SingleOrDefault();

                author.au_fname = formInput.au_fname;
                author.au_lname = formInput.au_lname;
                author.phone = formInput.phone;
                //author.city = formInput.city;

                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(formInput);
        }
    }
}
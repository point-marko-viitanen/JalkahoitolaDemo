using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JalkahoitolaDemo.Controllers
{
    public class JalkahoitolaController : Controller
    {
        // GET: Jalkahoitola
        public ActionResult Index()
        {
            return View();
        }

        // GET: Jalkahoitola
        public ActionResult Input()
        {
            return View();
        }

        // GET: Jalkahoitola/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Jalkahoitola/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Jalkahoitola/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Jalkahoitola/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Jalkahoitola/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Jalkahoitola/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Jalkahoitola/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

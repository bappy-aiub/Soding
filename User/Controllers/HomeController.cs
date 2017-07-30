using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace User.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        TaskDBContext context = new TaskDBContext();
        public ActionResult Index()
        {
            return View(context.Tasks.ToList());
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Task t = context.Tasks.SingleOrDefault(x=> x.id == id);
            return View(t);
        }

        [HttpPost,ActionName("Edit")]
        public ActionResult Do_Edit(int id)
        {
            Task t = context.Tasks.SingleOrDefault(x => x.id == id);
            TryUpdateModel(t);
            if (ModelState.IsValid)
            {
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else {
                return View(t);
            }
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            Task t = context.Tasks.SingleOrDefault(x => x.id == id);
            return View(t);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            Task t = context.Tasks.SingleOrDefault(x => x.id == id);
            return View(t);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult Confirm_Delete(int id)
        {
            Task t = context.Tasks.SingleOrDefault(x => x.id == id);
            context.Tasks.Remove(t);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Create() {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Task t)
        {
            if (ModelState.IsValid)
            {
                context.Tasks.Add(t);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(t);
            }
        }
    }
}

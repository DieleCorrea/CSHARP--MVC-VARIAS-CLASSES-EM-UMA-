using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VariasClasses.Controllers
{
    public class Todas : Controller
    {
        // GET: Todas
        public ActionResult Index()
        {
            return View();
        }

        // GET: Todas/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Todas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Todas/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Todas/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Todas/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Todas/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Todas/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

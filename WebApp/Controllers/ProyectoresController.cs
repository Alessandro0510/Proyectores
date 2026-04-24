using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class ProyectoresController : Controller
    {
        // GET: ProyectoresController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ProyectoresController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProyectoresController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProyectoresController/Create
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

        // GET: ProyectoresController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProyectoresController/Edit/5
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

        // GET: ProyectoresController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProyectoresController/Delete/5
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

using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //uso ViewData para enviar datos a la vista
            //ViewData["Id"] = 1;
            //ViewData["Marca"] = "Epson";
            //ViewData["Modelo"] = "Xlight";
            //ViewData["Numero de serie"] = "123456";
            //ViewData["Situacion"] = "Bueno";
            //ViewData["FechaDeAlta"] = DateTime.Now.ToString();

            //ViewBag.Id = 2;
            //ViewBag.Marca = "Epson";
            //ViewBag.Modelo = "Xlight";
            //ViewBag.NumeroDeSerie = "123456";
            //ViewBag.Situacion = "Bueno";
            //ViewBag.FechaDeAlta = DateTime.Now.ToString();
            //return View();

            //Uso de modelo de la vista  
            //Proyector proyector = new Proyector()

            var modelo = LoadDATA();
            return View(modelo);
        }
            private IEnumerable<Proyector> LoadDATA()
        {
            var proyectores = new List<Proyector>();

            proyectores.Add(new Proyector()

            {
                Id = 1,
                Marca = "Epson",
                Modelo = "Xlight",
                NumeroDeSerie = "123456",
                Situacion = SituacionProyector.Bueno,
                FechaDeAlta = DateTime.Now
            });

            proyectores.Add(new Proyector()

            {
                Id = 2,
                Marca = "Epson",
                Modelo = "Xlight",
                NumeroDeSerie = "123456",
                Situacion = SituacionProyector.Bueno,
                FechaDeAlta = DateTime.Now
            });

            proyectores.Add(new Proyector()

            {
                Id = 3,
                Marca = "Epson",
                Modelo = "Xlight",
                NumeroDeSerie = "123456",
                Situacion = SituacionProyector.Bueno,
                FechaDeAlta = DateTime.Now
            });

            proyectores.Add(new Proyector()

            {
                Id = 4,
                Marca = "Epson",
                Modelo = "Xlight",
                NumeroDeSerie = "123456",
                Situacion = SituacionProyector.Bueno,
                FechaDeAlta = DateTime.Now
            });

            proyectores.Add(new Proyector()

            {
                Id = 5,
                Marca = "Epson",
                Modelo = "Xlight",
                NumeroDeSerie = "123456",
                Situacion = SituacionProyector.Bueno,
                FechaDeAlta = DateTime.Now
            });

            proyectores.Add(new Proyector()

            {
                Id = 2,
                Marca = "Epson",
                Modelo = "Xlight",
                NumeroDeSerie = "123456",
                Situacion = SituacionProyector.Bueno,
                FechaDeAlta = DateTime.Now
            });
        
            
            return proyectores;
        }

        public IActionResult Privacy()

        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
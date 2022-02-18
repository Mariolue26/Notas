using Microsoft.AspNetCore.Mvc;
using PortalUnab.Models;
using System.Diagnostics;

namespace PortalUnab.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
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

        public IActionResult NoMayores()
        {
            return View();
        }

        public IActionResult PortalUnab(double number1, double number2, double number3, double number4, double number5, double number6)
        {
            if (number1 > 10 || number2 > 10 || number3 > 10 || number4 > 10 || number5 > 10 || number6 > 10)
            {
                return View("NoMayores");
            }

            //Nota por periodo 1
            Double resultN1 = 40 * number1 / 100;
            Double resultN2 = 60 * number2 / 100;
            Double result = resultN1 + resultN2;
            float Proceso = (float)(result / 3);
            Double Periodo = Math.Round(Proceso,1);

            //Nota por periodo 2
            Double resultN3 = 40 * number3 / 100;
            Double resultN4 = 60 * number4 / 100;
            Double result2 = resultN3 + resultN4;
            float Proceso2 = (float)(result2 / 3);
            Double Periodo2 = Math.Round(Proceso2, 1);

            //Nota por periodo 2
            Double resultN5 = 40 * number5 / 100;
            Double resultN6 = 60 * number6 / 100;
            Double result3 = resultN5 + resultN6;
            float Proceso3 = (float)(result3 / 3);
            Double Periodo3 = Math.Round(Proceso3, 1);

            //Impresión de datos
            ViewBag.Numbers1 = number1;
            ViewBag.Numbers2 = number2;
            ViewBag.Numbers3 = number3;
            ViewBag.Numbers4 = number4;
            ViewBag.Numbers5 = number5;
            ViewBag.Numbers6 = number6;

            //Nota final
            Double validacion = Periodo + Periodo2 + Periodo3;
            Double Final = Math.Round(validacion, 1);
            //Impresion de promedios finales
            //ViewBag.VariableAEnviar = result;
            ViewBag.NotaEnviar = Final;
            return View();
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MvcMovie.Controllers
{
    public class HolaMundoController : Controller
    {
        public IActionResult  Index()
        {
            return View();
        }
        public IActionResult Bievenido(string nombre, int NumVeces=1)
        {
            ViewData["Mensaje"] = "Hola " + nombre;
            ViewData["NumVeces"] = NumVeces;
            return View();
         }

        public  int Suma(int numero1,int numero2,int resultado)
        {
            resultado = numero1 + numero2;
            return (resultado);
        }
    }
}

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using sistema_reporte_ciudadano.Models;

namespace sistema_reporte_ciudadano.Controllers
{
    public class HelloController : Controller
    {
      public IActionResult HelloWorld() 
      {
        return View();
      }
    }
}

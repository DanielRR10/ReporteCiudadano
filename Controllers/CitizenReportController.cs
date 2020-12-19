using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using sistema_reporte_ciudadano.Models;

namespace sistema_reporte_ciudadano.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class citizenReportController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<User>> GetData()
        {
            User[] users = new User[]{
                new User{Id=1, IdZone=1, Name="Pedro", Photo="img/perro", Email="perro@gmail.com", Password="HDSJKAD"},
                new User{Id=2, IdZone=2, Name="Pedro", Photo="img/perro", Email="perro@gmail.com", Password="HDSJKAD"}
            };
            return users;
        }
    }
}
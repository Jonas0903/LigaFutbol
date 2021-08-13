using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL_WEB.Controllers
{
    public class FuerzaController : Controller
    {
        // GET: Fuerza
        public ActionResult GetAll()
        {
            ML.Result result = BL.Fuerza.GetAll();
            ML.Fuerza fuerza = new ML.Fuerza();
            fuerza.Fuerzas = new List<object>();
            fuerza.Fuerzas = result.Objects;
            return View(fuerza);
        }
    }
}
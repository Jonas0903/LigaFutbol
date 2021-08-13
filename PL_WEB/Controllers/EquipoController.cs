using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL_WEB.Controllers
{
    public class EquipoController : Controller
    {
        // GET: Equipo
        public ActionResult GetByFuerza(int IdFuerza)
        {
            ML.Equipo equipo = new ML.Equipo();
            equipo.Fuerza = new ML.Fuerza();
            equipo.Fuerza.IdFuerza = IdFuerza;
            ML.Result resultFuerza = BL.Fuerza.GetById(equipo.Fuerza);
            if (resultFuerza.Correct)
            {
                equipo.Fuerza = (ML.Fuerza)resultFuerza.Object;
            }
            else
            {
                return PartialView();
            }
            ML.Result resultEquipos = BL.Equipo.GetByFuerza(equipo);
            if (resultEquipos.Correct)
            {
                equipo.Equipos = resultEquipos.Objects;
            }
            else
            {
                return PartialView();
            }
            return View(equipo);
        }
        [HttpPost]
        public ActionResult Form(ML.Equipo equipo)
        {
            
            ML.Result result;
            if (equipo.IdEquipo == 0)
            {
                
                result = BL.Equipo.Add(equipo);
                if (result.Correct)
                {
                    ViewBag.Message = "Equipo añadido";
                    ML.Result result1 = BL.Equipo.GetByFuerza(equipo);
                    equipo.Equipos = result1.Objects;
                    return PartialView("ValidationModal", equipo);
                }
                else
                {
                    ViewBag.Message = result.Message;
                    return PartialView("ValidationModal", equipo);
                }
            }
            else
            {
                result = BL.Equipo.UpdateFuerzaEquipo(equipo);
                
                if (result.Correct)
                {
                    ViewBag.Message = "Equipo actualizado";
                    return PartialView("ValidationModal", equipo);
                }
                else
                {
                    ViewBag.Message = result.Message;
                    return PartialView("ValidationModal", equipo);
                }
            }
        }
        [HttpGet]
        public ActionResult Form(int? IdEquipo)
        {
            if (IdEquipo == null)
            {
                IdEquipo = 0;
            }
            ML.Equipo equipo = new ML.Equipo();
            equipo.IdEquipo = IdEquipo.Value;
            equipo.Fuerza = new ML.Fuerza();
            ML.Result resultFuerzas = BL.Fuerza.GetAll();
            
            if (equipo.IdEquipo == 0)
            {
                ViewBag.Titulo = "Nuevo Equipo";
                ViewBag.Boton = "Agregar";
            }
            else
            {
                ML.Result resultEquipo = BL.Equipo.GetById(equipo);
                equipo = (ML.Equipo)resultEquipo.Object;
                ViewBag.Boton = "Actualizar";
                ViewBag.Titulo = "Editar";

            }

            equipo.Fuerza.Fuerzas = resultFuerzas.Objects;
            return View(equipo);
        }

    }
}
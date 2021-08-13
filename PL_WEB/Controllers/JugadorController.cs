using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL_WEB.Controllers
{
    public class JugadorController : Controller
    {
        // GET: Jugador
        public ActionResult GetByEquipo(int IdEquipo)
        {
            ML.Jugador jugador = new ML.Jugador();
            jugador.Equipo = new ML.Equipo();
            jugador.Equipo.IdEquipo = IdEquipo;
            ML.Result result = BL.Jugador.GetByEquipo(jugador);
            jugador.Jugadores = result.Objects;
            return View(jugador);
        }
        [HttpGet]
        public ActionResult Form(int? IdJugador)
        {
            if (IdJugador == null)
                IdJugador = 0;
            ML.Jugador jugador = new ML.Jugador();
            jugador.IdJugador = IdJugador.Value;
            ML.Result resultFuerza = BL.Fuerza.GetAll();
            ML.Result resultEquipos = BL.Equipo.GetAll();
            if (jugador.IdJugador == 0)
            {
                ViewBag.Titulo = "Nuevo Jugador";
                ViewBag.Boton = "Agregar";
            }
            else
            {
                ViewBag.Titulo = "Editar Jugador";
                ViewBag.Boton = "Actualizar";
                ML.Result result = BL.Jugador.GetById(jugador);
                jugador = ((ML.Jugador)result.Object);
            }
            
            return View(jugador);
        }
        [HttpPost]
        public ActionResult Form(ML.Jugador jugador)
        {
            if (jugador.IdJugador == 0)
            {
                //ML.Result
            }
            else
            {

            }
            return View();
        }
        public void GetEquipo(int IdFuerza)
        {
            ML.Equipo equipo = new ML.Equipo();
            equipo.Fuerza = new ML.Fuerza();
            equipo.Fuerza.IdFuerza = IdFuerza;
            ML.Result result = BL.Equipo.GetByFuerza(equipo);
            equipo.Equipos = result.Objects;
        }
    }
}
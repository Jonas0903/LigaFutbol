using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Jugador
    {
        public static ML.Result GetByEquipo(ML.Jugador jugador)
        {
            ML.Result result = new ML.Result();
            try
            {
                using(DL.LigaFutbolEntities context = new DL.LigaFutbolEntities())
                {
                    var query = context.JugadorGetByEquipo(jugador.Equipo.IdEquipo);
                    result.Objects = new List<object>();
                    foreach (var obj in query)
                    {
                        ML.Jugador jugador1 = new ML.Jugador();
                        jugador1.IdJugador = (int)obj.IdJugador;
                        jugador1.Apellido = obj.Apellido;
                        jugador1.Goles = (int)obj.Goles;
                        jugador1.Equipo = new ML.Equipo();
                        jugador1.Equipo.IdEquipo = (int)obj.IdEquipo;
                        jugador1.Equipo.Nombre = obj.NombreEquipo;
                        jugador1.Nombre = obj.NombreJugador;
                        result.Objects.Add(jugador1);
                    }
                    result.Correct = true;
                }
            }
            catch(Exception e)
            {
                result.Message = e.Message;
                result.Correct = false;
            }
            return result;
        }
        public static ML.Result Add(ML.Jugador jugador)
        {
            ML.Result result = new ML.Result();
            try
            {
                using(DL.LigaFutbolEntities context = new DL.LigaFutbolEntities())
                {
                    var query = context.JugadorAdd(jugador.Equipo.IdEquipo, jugador.Nombre, jugador.Apellido);
                    result.Correct = true;
                }
            }
            catch(Exception e)
            {
                result.Correct = false;
                result.Ex = e;
                result.Message = e.Message;
            }
            return result;
        }
        public static ML.Result GetById(ML.Jugador jugador)
        {
            ML.Result result = new ML.Result();
            try
            {
                using(DL.LigaFutbolEntities context = new DL.LigaFutbolEntities())
                {
                    var query = context.JugadorGetById(jugador.IdJugador).FirstOrDefault();
                    ML.Jugador jugador1 = new ML.Jugador();
                    jugador1.Apellido = query.Apellido;
                    jugador1.Equipo = new ML.Equipo();
                    jugador1.Equipo.IdEquipo = query.IdEquipo;
                    jugador1.Equipo.Nombre = query.NombreEquipo;
                    jugador1.Goles = (int)query.Goles;
                    jugador1.IdJugador = (int)query.IdJugador;
                    jugador1.Nombre = query.NombreJugador;
                    result.Object = jugador1;
                    result.Correct = true;
                }
            }
            catch(Exception e)
            {
                result.Ex = e;
                result.Correct = false;
                result.Message = e.Message;
            }
            return result;
        }
        public static ML.Result Update(ML.Jugador jugador, int opcion)
        {
            ML.Result result = new ML.Result();
            try
            {
                using(DL.LigaFutbolEntities contex = new DL.LigaFutbolEntities())
                {
                    var query = contex.JugadorUpdate(jugador.IdJugador, jugador.Nombre, jugador.Apellido, jugador.Goles,
                        jugador.Equipo.IdEquipo, opcion);
                    result.Correct = true;
                }
                
            }
            catch(Exception e)
            {
                result.Ex = e;
                result.Message = e.Message;
                result.Correct = false;
            }
            return result;
        }
    }
}

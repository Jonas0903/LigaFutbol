using ML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Equipo
    {
        public static ML.Result GetByFuerza(ML.Equipo equipo)
        {
            ML.Result result = new ML.Result();
            try
            {
                using(DL.LigaFutbolEntities context = new DL.LigaFutbolEntities())
                {
                    result.Objects = new List<object>();
                    var query = context.EquipoGetByFuerza(equipo.Fuerza.IdFuerza).ToList();
                    foreach(var obj in query)
                    {
                        ML.Equipo equipo1 = new ML.Equipo();
                        equipo1.IdEquipo = obj.IdEquipo;
                        equipo1.Nombre = obj.NombreEquipo;
                        equipo1.DiferenciaGoles = (int)obj.DG;
                        equipo1.Empatados = (int)obj.JE;
                        equipo1.Fuerza = new ML.Fuerza();
                        equipo1.Fuerza.IdFuerza = (int)obj.IdFuerza;
                        equipo1.Fuerza.Nombre = obj.NombreFuerza;
                        equipo1.Ganados = (int)obj.JG;
                        equipo1.GolesContra = (int)obj.GC;
                        equipo1.GolesFavor = (int)obj.GF;
                        equipo1.Jugados = (int)obj.JJ;
                        equipo1.Perdidos = (int)obj.JP;
                        equipo1.Puntos = (int)obj.Puntos;
                        result.Objects.Add(equipo1);
                    }
                    result.Correct = true;
                }
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                result.Correct = false;
            }
            return result;
        }

        public static ML.Result GetAll()
        {
            ML.Result result = new Result();
            result.Objects = new List<object>();
            try
            {
                using(DL.LigaFutbolEntities context = new DL.LigaFutbolEntities())
                {
                    var query = context.EquipoGetAll();
                    foreach(var obj in query)
                    {
                        ML.Equipo equipo = new ML.Equipo();
                        equipo.IdEquipo = obj.IdEquipo;
                        equipo.Nombre = obj.Nombre;
                        result.Objects.Add(equipo);
                    }
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

        public static ML.Result Add(ML.Equipo equipo)
        {
            ML.Result result = new ML.Result();
            try
            {
                using(DL.LigaFutbolEntities context = new DL.LigaFutbolEntities())
                {
                    var query = context.EquipoAdd(equipo.Nombre, equipo.Fuerza.IdFuerza);                    
                }
                result.Correct = true;
            }
            catch(Exception e)
            {
                result.Message = e.Message;
                result.Correct = false;
            }
            return result;
        }
        public static ML.Result UpdateFuerzaEquipo(ML.Equipo equipo)
        {
            ML.Result result = new ML.Result();
            try
            {
                using(DL.LigaFutbolEntities context = new DL.LigaFutbolEntities())
                {
                    var query = context.EquipoUpdate(equipo.IdEquipo, equipo.Nombre, equipo.Puntos, equipo.GolesFavor, equipo.GolesContra,
                        equipo.Fuerza.IdFuerza, equipo.DiferenciaGoles, 1);
                }
                result.Correct = true;
            }
            catch(Exception e)
            {
                result.Message = e.Message;
                result.Correct = false;
            }
            return result;
        }
        public static ML.Result UpdateEquipoPartido(ML.Equipo equipo)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.LigaFutbolEntities context = new DL.LigaFutbolEntities())
                {
                    var query = context.EquipoUpdate(equipo.IdEquipo, equipo.Nombre, equipo.Puntos, equipo.GolesFavor, equipo.GolesContra,
                        equipo.Fuerza.IdFuerza, equipo.DiferenciaGoles, 2);
                }
                result.Correct = true;
            }
            catch (Exception e)
            {
                result.Message = e.Message;
                result.Correct = false;
            }
            return result;
        }
        public static ML.Result GetById(ML.Equipo equipo)
        {
            ML.Result result = new ML.Result();
            try
            {
                using(DL.LigaFutbolEntities context=new DL.LigaFutbolEntities())
                {
                    var query = context.EquipoGetById(equipo.IdEquipo).FirstOrDefault();
                    ML.Equipo equipo1 = new ML.Equipo();
                    equipo1.IdEquipo = query.IdEquipo;
                    equipo1.Nombre = query.Nombre;
                    equipo1.DiferenciaGoles = (int)query.DG;
                    equipo1.Empatados = (int)query.Empatados;
                    equipo1.Fuerza = new ML.Fuerza();
                    equipo1.Fuerza.IdFuerza = (int)query.IdFuerza;
                    equipo1.Fuerza.Nombre = query.NombreFuerza;
                    equipo1.Ganados = (int)query.Ganados;
                    equipo1.GolesContra = (int)query.GC;
                    equipo1.GolesFavor = (int)query.GF;
                    equipo1.Jugados = (int)query.Jugados;
                    equipo1.Perdidos = (int)query.Perdidos;
                    equipo1.Puntos = (int)query.Puntos;
                    result.Object = equipo1;
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
    }
}

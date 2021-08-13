using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Fuerza
    {
        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();
            try
            {
                using(DL.LigaFutbolEntities context=new DL.LigaFutbolEntities())
                {
                    var query = context.FuerzaGetAll();
                    result.Objects = new List<object>();
                    foreach(var obj in query)
                    {
                        ML.Fuerza fuerza = new ML.Fuerza();
                        fuerza.IdFuerza = obj.IdFuerza;
                        fuerza.Nombre = obj.Nombre;
                        result.Objects.Add(fuerza);
                    }
                }
                result.Correct = true;
            }
            catch(Exception e)
            {
                result.Message = e.Message;
                result.Ex = e;
                result.Correct = false;
            }
            return result;
        }
        public static ML.Result GetById(ML.Fuerza fuerza)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.LigaFutbolEntities context = new DL.LigaFutbolEntities())
                {
                    var query = context.FuerzaGetById(fuerza.IdFuerza).FirstOrDefault();
                    fuerza.IdFuerza = query.IdFuerza;
                    fuerza.Nombre = query.Nombre;
                    result.Object = fuerza;
                    result.Correct = true;
                }
            }
            catch(Exception e)
            {
                result.Correct = false;
                result.Message = e.Message;
                result.Ex = e;
            }
            return result;
        }
    }
}

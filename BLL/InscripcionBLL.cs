using ResgistroDeEstudiantes.DAL;
using ResgistroDeEstudiantes.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ResgistroDeEstudiantes.BLL
{
    public class InscripcionBLL
    {
        public static bool Guardar(Inscripcion inscripcion)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if (db.Inscripcion.Add(inscripcion) != null)
                    paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static bool Modificar(Inscripcion inscripcion)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(inscripcion).State = EntityState.Modified;
                if(contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static bool Eliminar(int Id)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                var eliminar = db.Inscripcion.Find(Id);
                db.Entry(eliminar).State = EntityState.Deleted;

                paso = (db.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }
        public static Inscripcion Buscar(int Id)
        {
            Contexto db = new Contexto();
            Inscripcion inscripcion = new Inscripcion();
            try
            {
                inscripcion = db.Inscripcion.Find(Id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return inscripcion;
        }

        public static List<Inscripcion> GetList(Expression<Func<Inscripcion, bool>> inscripcion)
        {
            List<Inscripcion> Lista = new List<Inscripcion>();
            Contexto db = new Contexto();
            try
            {
                Lista = db.Inscripcion.Where(inscripcion).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return Lista;
        }
    }
}

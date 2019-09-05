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
    public class EstudianteBLL
    {
        public static bool Guardar(Estudiante estudiante)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if(db.Estudiante.Add(estudiante) != null)
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

        public static bool Modificar(Estudiante estudiante)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                db.Entry(estudiante).State = EntityState.Modified;
                paso = (db.SaveChanges() > 0);
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static bool Eliminar(int Id)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                var eliminar = db.Estudiante.Find(Id);
                db.Entry(eliminar).State = EntityState.Deleted;

                paso = (db.SaveChanges() > 0);
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static Estudiante Buscar(int Id)
        {
            Contexto db = new Contexto();
            Estudiante estudiante = new Estudiante();
            try
            {
                estudiante = db.Estudiante.Find(Id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return estudiante;
        }

        public static List<Estudiante>GetList(Expression<Func<Estudiante, bool>> estudiante)
        {
            List<Estudiante> Lista = new List<Estudiante>();
            Contexto db = new Contexto();
            try
            {
                Lista = db.Estudiante.Where(estudiante).ToList();
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

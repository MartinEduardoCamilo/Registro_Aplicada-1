using ResgistroDeEstudiantes.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResgistroDeEstudiantes.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Estudiante> Estudiante { get; set; }
        public DbSet<Inscripcion> Inscripcion { get; set; }
        public Contexto() : base("ConStr") { }
    }
}

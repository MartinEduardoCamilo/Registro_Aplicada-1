using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResgistroDeEstudiantes.Entidades
{
    public class Inscripcion
    {
        [Key]
        public int InscripcionID { get; set; }
        public DateTime Fecha { get; set; }
        public int EstudianteID { get; set; }
        public decimal Monto { get; set; }
        public decimal Deposito { get; set; }
        public decimal Balance { get; set; }
        public string Comentario { get; set; }

        public Inscripcion()
        {
            InscripcionID = 0;
            Fecha = DateTime.Now;
            EstudianteID = 0;
            Monto = 0;
            Deposito = 0;
            Balance = 0;
            Comentario = string.Empty;
        }
    }
}
//
// Hcaer de diseño de la inscripcion
//

//
// hacer  la tabla de inscripcion en sql
//
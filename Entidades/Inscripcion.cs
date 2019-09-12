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
        public string Comentario { get; set; }
        public float Monto { get; set; }
        public float Deposito { get; set; }
        public float Balance { get; set; }

        public Inscripcion()
        {
            InscripcionID = 0;
            Fecha = DateTime.Now;
            EstudianteID = 0;
            Comentario = string.Empty;
            Monto = 0.0f;
            Deposito = 0.0f;
            Balance = 0.0f;
        }
    }
}
//
// Hcaer de diseño de la inscripcion
//

//
// hacer  la tabla de inscripcion en sql
//
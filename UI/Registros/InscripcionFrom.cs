using ResgistroDeEstudiantes.Entidades;
using ResgistroDeEstudiantes.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ResgistroDeEstudiantes.DAL;

namespace ResgistroDeEstudiantes.UI.Registros
{
    public partial class InscripcionFrom : Form
    {
        public InscripcionFrom()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            IncripcionIDnumericUpDown.Value = 0;
            EstudianteIDnumericUpDown.Value = 0;
            FechadateTimePicker.Value = DateTime.Now;           
            MontotextBox.Text = string.Empty;
            DepositotextBox.Text = string.Empty;
            BalancetextBox.Text = string.Empty;
            ComentariotextBox.Text = string.Empty;
            MyError.Clear();
           
        }

        private Inscripcion LLenaclase()
        {
            Inscripcion inscripcion = new Inscripcion();
            inscripcion.InscripcionID = Convert.ToInt32(IncripcionIDnumericUpDown.Value);
            inscripcion.EstudianteID = Convert.ToInt32(EstudianteIDnumericUpDown.Value);
            inscripcion.Fecha = FechadateTimePicker.Value;
            inscripcion.Monto = Convert.ToDecimal(MontotextBox.Text);
            inscripcion.Deposito = Convert.ToDecimal(DepositotextBox.Text);
            inscripcion.Balance = Convert.ToDecimal(MontotextBox.Text) - Convert.ToDecimal(DepositotextBox.Text);
            inscripcion.Comentario = ComentariotextBox.Text;

            return inscripcion;

        }

        private void LLenaCampo(Inscripcion inscripcion)
        {
            IncripcionIDnumericUpDown.Value = inscripcion.InscripcionID;
            EstudianteIDnumericUpDown.Value = inscripcion.EstudianteID;
            FechadateTimePicker.Value = inscripcion.Fecha;            
            MontotextBox.Text = inscripcion.Monto.ToString();
            DepositotextBox.Text = inscripcion.Deposito.ToString();
            BalancetextBox.Text = inscripcion.Balance.ToString();
            ComentariotextBox.Text = inscripcion.Comentario;

        }

        private bool Validar()
        {
            bool paso = true;
            MyError.Clear();

            if (string.IsNullOrWhiteSpace(ComentariotextBox.Text))
            {
                MyError.SetError(ComentariotextBox, "El campo comentario no puede estar vacio");
                ComentariotextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(DepositotextBox.Text))
            {
                MyError.SetError(DepositotextBox, "El campo deposito no puede estar vacio");
                DepositotextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(MontotextBox.Text))
            {
                MyError.SetError(MontotextBox, "El campo monto no puede estar vacio");
                MontotextBox.Focus();
                paso = false;
            }
            return paso;
        }

        private bool ExiteBaseDato()
        {
            Inscripcion inscripcion = InscripcionBLL.Buscar((int)IncripcionIDnumericUpDown.Value);
            return (inscripcion != null);
        }

        private void Nuevobutton_Click_1(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click_1(object sender, EventArgs e)
        {
            Inscripcion inscripcion;
            bool paso = false;
            Estudiante estudiante = new Estudiante();
            Contexto db = new Contexto();

            if (!Validar())
                return;

            inscripcion = LLenaclase();

            if (IncripcionIDnumericUpDown.Value == 0) {
                paso = BLL.InscripcionBLL.Guardar(inscripcion);
            }
            if(EstudianteIDnumericUpDown.Value == 0)
            {
                paso = BLL.EstudianteBLL.Guardar(estudiante);
            }
                

            else
            {
                if (!ExiteBaseDato())
                {
                    MessageBox.Show("No se puede modificar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                estudiante = db.Estudiante.Find(Convert.ToInt32(EstudianteIDnumericUpDown.Value));

                paso = InscripcionBLL.Modificar(inscripcion);
                paso = EstudianteBLL.Modificar(estudiante);
 
            }

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado!!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo Guardar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Eliminarbutton_Click_1(object sender, EventArgs e)
        {
            MyError.Clear();
            int id;
            int.TryParse(IncripcionIDnumericUpDown.Text, out id);
            Limpiar();
            if (InscripcionBLL.Eliminar(id))
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MyError.SetError(IncripcionIDnumericUpDown, "No se puede eliminar a un estudiante no existente");
        }

        private void Buscarbutton_Click_1(object sender, EventArgs e)
        {
            int id;
            Inscripcion inscripcion = new Inscripcion();
            int.TryParse(IncripcionIDnumericUpDown.Text, out id);

            Limpiar();

            inscripcion = InscripcionBLL.Buscar(id);

            if (inscripcion != null)
            {
                MessageBox.Show("Encontrado");
                LLenaCampo(inscripcion);
            }
            else
            {
                MessageBox.Show("No encontrado");
            }
        }
    }
}

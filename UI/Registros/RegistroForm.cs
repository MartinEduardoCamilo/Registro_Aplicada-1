using ResgistroDeEstudiantes.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResgistroDeEstudiantes.UI.Registros
{
    public partial class RegistroForm : Form
    {
        public RegistroForm()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            IDnumericUpDown.Value = 0;
            MatriculamaskedTextBox.Text = string.Empty;
            NombretextBox.Text = string.Empty;
            ApellidotextBox.Text = string.Empty;
            CedulamaskedTextBox.Text = string.Empty;
            TelefonomaskedTextBox.Text = string.Empty;
            CelularmaskedTextBox.Text = string.Empty;
            EmailtextBox.Text = string.Empty;
            FechaNacimientodateTimePicker.Value = DateTime.Now;
            SexotextBox.Text = string.Empty;
            BalancetextBox.Text = string.Empty;

            MyErrorProvider.Clear();
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private Estudiante LLenaclase()
        {
            Estudiante estudiante = new Estudiante();
            estudiante.EstudianteId = Convert.ToInt32(IDnumericUpDown.Value);
            estudiante.Matricula = MatriculamaskedTextBox.Text;


            return estudiante;

        }
    }
}

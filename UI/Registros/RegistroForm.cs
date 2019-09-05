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
            estudiante.Nombres = NombretextBox.Text;
            estudiante.Apellidos = ApellidotextBox.Text;
            estudiante.Cedula = CedulamaskedTextBox.Text;
            estudiante.Telefono = TelefonomaskedTextBox.Text;
            estudiante.Celular = CelularmaskedTextBox.Text;
            estudiante.Email = EmailtextBox.Text;
            estudiante.FechaNacimiento = FechaNacimientodateTimePicker.Value;
            estudiante.Sexo = SexotextBox.Text;
            estudiante.Balance = BalancetextBox.Text;

            return estudiante;

        }

        private void LLenaCampo(Estudiante estudiante)
        {
            IDnumericUpDown.Value = estudiante.EstudianteId;
            MatriculamaskedTextBox.Text = estudiante.Matricula;
            NombretextBox.Text = estudiante.Nombres;
            ApellidotextBox.Text = estudiante.Apellidos;
            CedulamaskedTextBox.Text = estudiante.Cedula;
            TelefonomaskedTextBox.Text = estudiante.Telefono;
            CelularmaskedTextBox.Text = estudiante.Celular;
            EmailtextBox.Text = estudiante.Email;
            FechaNacimientodateTimePicker.Value = estudiante.FechaNacimiento;
            SexotextBox.Text = estudiante.Sexo;
            BalancetextBox.Text = estudiante.Balance;
        }

        private bool Validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if (string.IsNullOrWhiteSpace(MatriculamaskedTextBox.Text))
            {
                MyErrorProvider.SetError(MatriculamaskedTextBox, "El campo matricula no puede estar vacio");
                MatriculamaskedTextBox.Focus();
                paso = false;
            }
            
            if(NombretextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(NombretextBox, "El campo nombre no debe estar vacio");
                NombretextBox.Focus();
                paso = false;
            }
            return paso;
        }
    }
}

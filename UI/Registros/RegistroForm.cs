using ResgistroDeEstudiantes.BLL;
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
            SexocomboBox.Text = string.Empty;
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
            estudiante.EstudianteID = Convert.ToInt32(IDnumericUpDown.Value);
            estudiante.Matricula = MatriculamaskedTextBox.Text;
            estudiante.Nombres = NombretextBox.Text;
            estudiante.Apellidos = ApellidotextBox.Text;
            estudiante.Cedula = CedulamaskedTextBox.Text;
            estudiante.Telefono = TelefonomaskedTextBox.Text;
            estudiante.Celular = CelularmaskedTextBox.Text;
            estudiante.Email = EmailtextBox.Text;
            estudiante.FechaNacimiento = FechaNacimientodateTimePicker.Value;
            estudiante.Sexo = SexocomboBox.Text;
            estudiante.Balance = Convert.ToSingle(BalancetextBox.Text);

            return estudiante;

        }

        private void LLenaCampo(Estudiante estudiante)
        {
            IDnumericUpDown.Value = estudiante.EstudianteID;
            MatriculamaskedTextBox.Text = estudiante.Matricula;
            NombretextBox.Text = estudiante.Nombres;
            ApellidotextBox.Text = estudiante.Apellidos;
            CedulamaskedTextBox.Text = estudiante.Cedula;
            TelefonomaskedTextBox.Text = estudiante.Telefono;
            CelularmaskedTextBox.Text = estudiante.Celular;
            EmailtextBox.Text = estudiante.Email;
            FechaNacimientodateTimePicker.Value = estudiante.FechaNacimiento;
            SexocomboBox.Text = estudiante.Sexo;
            BalancetextBox.Text = Convert.ToString(estudiante.Balance);

        }

        private bool Validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if (string.IsNullOrWhiteSpace(MatriculamaskedTextBox.Text.Replace("-", "")))
            {
                MyErrorProvider.SetError(MatriculamaskedTextBox, "El campo matricula no puede estar vacio");
                MatriculamaskedTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(TelefonomaskedTextBox.Text.Replace("-", "")))
            {
                MyErrorProvider.SetError(TelefonomaskedTextBox, "El campo telefono no puede estar vacio");
                TelefonomaskedTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(CedulamaskedTextBox.Text.Replace("-", "")))
            {
                MyErrorProvider.SetError(CedulamaskedTextBox, "El campo cedula no puede estar vacio");
                CedulamaskedTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(CelularmaskedTextBox.Text.Replace("-", "")))
            {
                MyErrorProvider.SetError(CelularmaskedTextBox, "El campo celular no puede estar vacio");
                CelularmaskedTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(NombretextBox.Text))
            {
                MyErrorProvider.SetError(NombretextBox, "El campo nombre no debe estar vacio");
                NombretextBox.Focus();
                paso = false;
            }

            if(string.IsNullOrWhiteSpace(ApellidotextBox.Text))
            {
                MyErrorProvider.SetError(ApellidotextBox, "El campo apellido no debe estar vacio");
                ApellidotextBox.Focus();
                paso = false;
            }
            
            if(string.IsNullOrWhiteSpace(EmailtextBox.Text))
            {
                MyErrorProvider.SetError(EmailtextBox, "El Campo Email no debe estar Vacio");
                EmailtextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(BalancetextBox.Text))
            {
                MyErrorProvider.SetError(BalancetextBox, "El balance no debe estar Vacio");
                BalancetextBox.Focus();
                paso = false;
            }
            return paso;
        }

        private bool ExiteBaseDato()
        {
            Estudiante estudiante = EstudianteBLL.Buscar((int)IDnumericUpDown.Value);
            return (estudiante != null);
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Estudiante estudiante;
            bool paso = false;

            if (!Validar())
                return;

            estudiante = LLenaclase();

            if (IDnumericUpDown.Value == 0)
                paso = BLL.EstudianteBLL.Guardar(estudiante);
            else
            {
                if (ExiteBaseDato()) 
                {
                    MessageBox.Show("No se puede modificar un que estudiante exite", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
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

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            Estudiante estudiante = new Estudiante();
            int.TryParse(IDnumericUpDown.Text, out id);

            Limpiar();

            estudiante = EstudianteBLL.Buscar(id); 

            if(estudiante != null)
            {
                MessageBox.Show("Estudiante encontrado");
                LLenaCampo(estudiante);
            }
            else
            {
                MessageBox.Show("Estudiante no encontrado");
            }
        }


        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();
            int id;
            int.TryParse(IDnumericUpDown.Text, out id);
            Limpiar();
            if (EstudianteBLL.Eliminar(id))
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MyErrorProvider.SetError(IDnumericUpDown, "No se puede eliminar a un estudiante no existente");
        }

        private void RegistroForm_Load(object sender, EventArgs e)
        {

        }
    }
}

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

namespace ResgistroDeEstudiantes.UI.Consultas
{
    public partial class ConsultaInscripcionForm : Form
    {
        public ConsultaInscripcionForm()
        {
            InitializeComponent();
        }

        private void Consultarbutton_Click(object sender, EventArgs e)
        {
            var Listado = new List<Inscripcion>();
            if (CriteriotextBox.Text.Trim().Length > 0)
            {
                switch (FiltrocomboBox.SelectedIndex)
                {
                    case 0:
                        Listado = InscripcionBLL.GetList(inscripcion => true);
                        break;
                    case 1:
                        int Id = Convert.ToInt32(CriteriotextBox.Text);
                        Listado = InscripcionBLL.GetList(inscripcion => inscripcion.EstudianteID == Id);
                        break;
                }
            }
            else
            {
                Listado = InscripcionBLL.GetList(inscripcion => true);
            }
            ConsultadataGridView.DataSource = null;
            ConsultadataGridView.DataSource = Listado;
        }
    }
}

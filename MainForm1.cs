using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ResgistroDeEstudiantes.UI.Registros;

namespace ResgistroDeEstudiantes
{
    public partial class MainForm1 : Form
    {
        public MainForm1()
        {
            InitializeComponent();
        }

        private void EstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroForm registro = new RegistroForm();
            registro.Show();
        }

        private void RegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ConsultaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

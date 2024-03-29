﻿using ResgistroDeEstudiantes.BLL;
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
    public partial class ConsultasFrom : Form
    {
        public ConsultasFrom()
        {
            InitializeComponent();
        }

        private void Consultarbutton_Click(object sender, EventArgs e)
        {
            var Listado = new List<Estudiante>();
            if(CriteriotextBox.Text.Trim().Length > 0)
            {
                switch (FiltrocomboBox.SelectedIndex)
                {
                    case 0:
                        Listado = EstudianteBLL.GetList(estudiante => true);
                        break;
                    case 1:
                        int Id = Convert.ToInt32(CriteriotextBox.Text);
                        Listado = EstudianteBLL.GetList(estudiante => estudiante.EstudianteID == Id);
                        break;
                    case 2:
                        Listado = EstudianteBLL.GetList(estudiante => estudiante.Matricula.Contains(CriteriotextBox.Text));
                        break;
                    case 3:
                        Listado = EstudianteBLL.GetList(estudiante => estudiante.Cedula.Contains(CriteriotextBox.Text));
                        break;
                    case 4:
                        Listado = EstudianteBLL.GetList(estudiante => estudiante.Sexo.Contains(CriteriotextBox.Text));
                        break;
                }
            }
            else
            {
                Listado = EstudianteBLL.GetList(estudiante => true);
            }
            ConsultadataGridView.DataSource = null;
            ConsultadataGridView.DataSource = Listado;
        }
    }
}

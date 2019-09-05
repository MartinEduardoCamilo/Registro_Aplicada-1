using System;

namespace ResgistroDeEstudiantes.UI.Registros
{
    partial class RegistroForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Balancelabel = new System.Windows.Forms.Label();
            this.Sexolabel = new System.Windows.Forms.Label();
            this.FechaNacimientolabel = new System.Windows.Forms.Label();
            this.Emaillabel = new System.Windows.Forms.Label();
            this.Celularlabel = new System.Windows.Forms.Label();
            this.Telefonolabel = new System.Windows.Forms.Label();
            this.Cedulalabel = new System.Windows.Forms.Label();
            this.Apellidolabel = new System.Windows.Forms.Label();
            this.Nombrelabel = new System.Windows.Forms.Label();
            this.Matriculalabel = new System.Windows.Forms.Label();
            this.IDlabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SexotextBox = new System.Windows.Forms.TextBox();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.BalancetextBox = new System.Windows.Forms.TextBox();
            this.FechaNacimientodateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.CelularmaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.TelefonomaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.CedulamaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ApellidotextBox = new System.Windows.Forms.TextBox();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.MatriculamaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.IDnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Balancelabel);
            this.panel1.Controls.Add(this.Sexolabel);
            this.panel1.Controls.Add(this.FechaNacimientolabel);
            this.panel1.Controls.Add(this.Emaillabel);
            this.panel1.Controls.Add(this.Celularlabel);
            this.panel1.Controls.Add(this.Telefonolabel);
            this.panel1.Controls.Add(this.Cedulalabel);
            this.panel1.Controls.Add(this.Apellidolabel);
            this.panel1.Controls.Add(this.Nombrelabel);
            this.panel1.Controls.Add(this.Matriculalabel);
            this.panel1.Controls.Add(this.IDlabel);
            this.panel1.Location = new System.Drawing.Point(13, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(103, 411);
            this.panel1.TabIndex = 0;
            // 
            // Balancelabel
            // 
            this.Balancelabel.AutoSize = true;
            this.Balancelabel.Location = new System.Drawing.Point(6, 372);
            this.Balancelabel.Name = "Balancelabel";
            this.Balancelabel.Size = new System.Drawing.Size(46, 13);
            this.Balancelabel.TabIndex = 10;
            this.Balancelabel.Text = "Balance";
            // 
            // Sexolabel
            // 
            this.Sexolabel.AutoSize = true;
            this.Sexolabel.Location = new System.Drawing.Point(6, 339);
            this.Sexolabel.Name = "Sexolabel";
            this.Sexolabel.Size = new System.Drawing.Size(31, 13);
            this.Sexolabel.TabIndex = 9;
            this.Sexolabel.Text = "Sexo";
            // 
            // FechaNacimientolabel
            // 
            this.FechaNacimientolabel.AutoSize = true;
            this.FechaNacimientolabel.Location = new System.Drawing.Point(3, 301);
            this.FechaNacimientolabel.Name = "FechaNacimientolabel";
            this.FechaNacimientolabel.Size = new System.Drawing.Size(93, 13);
            this.FechaNacimientolabel.TabIndex = 8;
            this.FechaNacimientolabel.Text = "Fecha Nacimiento";
            // 
            // Emaillabel
            // 
            this.Emaillabel.AutoSize = true;
            this.Emaillabel.Location = new System.Drawing.Point(3, 267);
            this.Emaillabel.Name = "Emaillabel";
            this.Emaillabel.Size = new System.Drawing.Size(32, 13);
            this.Emaillabel.TabIndex = 7;
            this.Emaillabel.Text = "Email";
            // 
            // Celularlabel
            // 
            this.Celularlabel.AutoSize = true;
            this.Celularlabel.Location = new System.Drawing.Point(3, 235);
            this.Celularlabel.Name = "Celularlabel";
            this.Celularlabel.Size = new System.Drawing.Size(39, 13);
            this.Celularlabel.TabIndex = 6;
            this.Celularlabel.Text = "Celular";
            // 
            // Telefonolabel
            // 
            this.Telefonolabel.AutoSize = true;
            this.Telefonolabel.Location = new System.Drawing.Point(3, 196);
            this.Telefonolabel.Name = "Telefonolabel";
            this.Telefonolabel.Size = new System.Drawing.Size(52, 13);
            this.Telefonolabel.TabIndex = 5;
            this.Telefonolabel.Text = "Teléfono ";
            // 
            // Cedulalabel
            // 
            this.Cedulalabel.AutoSize = true;
            this.Cedulalabel.Location = new System.Drawing.Point(3, 163);
            this.Cedulalabel.Name = "Cedulalabel";
            this.Cedulalabel.Size = new System.Drawing.Size(40, 13);
            this.Cedulalabel.TabIndex = 4;
            this.Cedulalabel.Text = "Cedula";
            // 
            // Apellidolabel
            // 
            this.Apellidolabel.AutoSize = true;
            this.Apellidolabel.Location = new System.Drawing.Point(3, 132);
            this.Apellidolabel.Name = "Apellidolabel";
            this.Apellidolabel.Size = new System.Drawing.Size(44, 13);
            this.Apellidolabel.TabIndex = 3;
            this.Apellidolabel.Text = "Apellido";
            // 
            // Nombrelabel
            // 
            this.Nombrelabel.AutoSize = true;
            this.Nombrelabel.Location = new System.Drawing.Point(3, 103);
            this.Nombrelabel.Name = "Nombrelabel";
            this.Nombrelabel.Size = new System.Drawing.Size(44, 13);
            this.Nombrelabel.TabIndex = 2;
            this.Nombrelabel.Text = "Nombre";
            // 
            // Matriculalabel
            // 
            this.Matriculalabel.AutoSize = true;
            this.Matriculalabel.Location = new System.Drawing.Point(3, 73);
            this.Matriculalabel.Name = "Matriculalabel";
            this.Matriculalabel.Size = new System.Drawing.Size(50, 13);
            this.Matriculalabel.TabIndex = 1;
            this.Matriculalabel.Text = "Matricula";
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.Location = new System.Drawing.Point(3, 17);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(18, 13);
            this.IDlabel.TabIndex = 0;
            this.IDlabel.Text = "ID";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.SexotextBox);
            this.panel2.Controls.Add(this.Buscarbutton);
            this.panel2.Controls.Add(this.BalancetextBox);
            this.panel2.Controls.Add(this.FechaNacimientodateTimePicker);
            this.panel2.Controls.Add(this.EmailtextBox);
            this.panel2.Controls.Add(this.CelularmaskedTextBox);
            this.panel2.Controls.Add(this.TelefonomaskedTextBox);
            this.panel2.Controls.Add(this.CedulamaskedTextBox);
            this.panel2.Controls.Add(this.ApellidotextBox);
            this.panel2.Controls.Add(this.NombretextBox);
            this.panel2.Controls.Add(this.MatriculamaskedTextBox);
            this.panel2.Controls.Add(this.IDnumericUpDown);
            this.panel2.Location = new System.Drawing.Point(157, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 411);
            this.panel2.TabIndex = 1;
            // 
            // SexotextBox
            // 
            this.SexotextBox.Location = new System.Drawing.Point(18, 332);
            this.SexotextBox.Name = "SexotextBox";
            this.SexotextBox.Size = new System.Drawing.Size(227, 20);
            this.SexotextBox.TabIndex = 13;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Buscarbutton.Image")));
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(181, 6);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(117, 43);
            this.Buscarbutton.TabIndex = 12;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            // 
            // BalancetextBox
            // 
            this.BalancetextBox.Location = new System.Drawing.Point(18, 364);
            this.BalancetextBox.Name = "BalancetextBox";
            this.BalancetextBox.Size = new System.Drawing.Size(227, 20);
            this.BalancetextBox.TabIndex = 11;
            // 
            // FechaNacimientodateTimePicker
            // 
            this.FechaNacimientodateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaNacimientodateTimePicker.Location = new System.Drawing.Point(18, 293);
            this.FechaNacimientodateTimePicker.Name = "FechaNacimientodateTimePicker";
            this.FechaNacimientodateTimePicker.Size = new System.Drawing.Size(227, 20);
            this.FechaNacimientodateTimePicker.TabIndex = 8;
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.Location = new System.Drawing.Point(18, 259);
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.Size = new System.Drawing.Size(227, 20);
            this.EmailtextBox.TabIndex = 7;
            // 
            // CelularmaskedTextBox
            // 
            this.CelularmaskedTextBox.Location = new System.Drawing.Point(18, 227);
            this.CelularmaskedTextBox.Mask = "000-000-0000";
            this.CelularmaskedTextBox.Name = "CelularmaskedTextBox";
            this.CelularmaskedTextBox.Size = new System.Drawing.Size(227, 20);
            this.CelularmaskedTextBox.TabIndex = 6;
            // 
            // TelefonomaskedTextBox
            // 
            this.TelefonomaskedTextBox.Location = new System.Drawing.Point(18, 188);
            this.TelefonomaskedTextBox.Mask = "(999)000-0000";
            this.TelefonomaskedTextBox.Name = "TelefonomaskedTextBox";
            this.TelefonomaskedTextBox.Size = new System.Drawing.Size(227, 20);
            this.TelefonomaskedTextBox.TabIndex = 5;
            // 
            // CedulamaskedTextBox
            // 
            this.CedulamaskedTextBox.Location = new System.Drawing.Point(18, 155);
            this.CedulamaskedTextBox.Mask = "000-0000000-0";
            this.CedulamaskedTextBox.Name = "CedulamaskedTextBox";
            this.CedulamaskedTextBox.Size = new System.Drawing.Size(227, 20);
            this.CedulamaskedTextBox.TabIndex = 4;
            // 
            // ApellidotextBox
            // 
            this.ApellidotextBox.Location = new System.Drawing.Point(18, 124);
            this.ApellidotextBox.Name = "ApellidotextBox";
            this.ApellidotextBox.Size = new System.Drawing.Size(227, 20);
            this.ApellidotextBox.TabIndex = 3;
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(18, 95);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(227, 20);
            this.NombretextBox.TabIndex = 2;
            // 
            // MatriculamaskedTextBox
            // 
            this.MatriculamaskedTextBox.Location = new System.Drawing.Point(18, 65);
            this.MatriculamaskedTextBox.Mask = "0000-0000";
            this.MatriculamaskedTextBox.Name = "MatriculamaskedTextBox";
            this.MatriculamaskedTextBox.Size = new System.Drawing.Size(227, 20);
            this.MatriculamaskedTextBox.TabIndex = 1;
            // 
            // IDnumericUpDown
            // 
            this.IDnumericUpDown.Location = new System.Drawing.Point(18, 9);
            this.IDnumericUpDown.Name = "IDnumericUpDown";
            this.IDnumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.IDnumericUpDown.TabIndex = 0;
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = ((System.Drawing.Image)(resources.GetObject("Nuevobutton.Image")));
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Nuevobutton.Location = new System.Drawing.Point(157, 461);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 63);
            this.Nuevobutton.TabIndex = 2;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Guardarbutton.Image")));
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Guardarbutton.Location = new System.Drawing.Point(276, 461);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 63);
            this.Guardarbutton.TabIndex = 3;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(392, 461);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 63);
            this.button1.TabIndex = 4;
            this.button1.Text = "Eliminar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // RegistroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 536);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "RegistroForm";
            this.Text = "RegistroForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.Label Apellidolabel;
        private System.Windows.Forms.Label Nombrelabel;
        private System.Windows.Forms.Label Matriculalabel;
        private System.Windows.Forms.Label Telefonolabel;
        private System.Windows.Forms.Label Cedulalabel;
        private System.Windows.Forms.Label Celularlabel;
        private System.Windows.Forms.Label Emaillabel;
        private System.Windows.Forms.Label FechaNacimientolabel;
        private System.Windows.Forms.Label Balancelabel;
        private System.Windows.Forms.Label Sexolabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown IDnumericUpDown;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.TextBox BalancetextBox;
        private System.Windows.Forms.DateTimePicker FechaNacimientodateTimePicker;
        private System.Windows.Forms.TextBox EmailtextBox;
        private System.Windows.Forms.MaskedTextBox CelularmaskedTextBox;
        private System.Windows.Forms.MaskedTextBox TelefonomaskedTextBox;
        private System.Windows.Forms.MaskedTextBox CedulamaskedTextBox;
        private System.Windows.Forms.TextBox ApellidotextBox;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.MaskedTextBox MatriculamaskedTextBox;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.TextBox SexotextBox;
    }
}
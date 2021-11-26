
namespace PresentacionGUI
{
    partial class FrmAgendamiento
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
            this.label1 = new System.Windows.Forms.Label();
            this.TextCedula = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TextCedulaPaciente = new System.Windows.Forms.TextBox();
            this.TextNombre = new System.Windows.Forms.TextBox();
            this.TextApellido = new System.Windows.Forms.TextBox();
            this.TextEdad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CmbPsicologos = new System.Windows.Forms.ComboBox();
            this.BtnAgendar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.CmbHora = new System.Windows.Forms.ComboBox();
            this.DtgCitas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DtgCitas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(15, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cedula del paciente:";
            // 
            // TextCedula
            // 
            this.TextCedula.Location = new System.Drawing.Point(153, 44);
            this.TextCedula.Margin = new System.Windows.Forms.Padding(2);
            this.TextCedula.Name = "TextCedula";
            this.TextCedula.Size = new System.Drawing.Size(91, 20);
            this.TextCedula.TabIndex = 1;
            this.TextCedula.TextChanged += new System.EventHandler(this.TextCedula_TextChanged);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Location = new System.Drawing.Point(19, 70);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(91, 27);
            this.BtnBuscar.TabIndex = 2;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TextCedulaPaciente
            // 
            this.TextCedulaPaciente.Enabled = false;
            this.TextCedulaPaciente.Location = new System.Drawing.Point(104, 106);
            this.TextCedulaPaciente.Margin = new System.Windows.Forms.Padding(2);
            this.TextCedulaPaciente.Name = "TextCedulaPaciente";
            this.TextCedulaPaciente.Size = new System.Drawing.Size(68, 20);
            this.TextCedulaPaciente.TabIndex = 3;
            // 
            // TextNombre
            // 
            this.TextNombre.Enabled = false;
            this.TextNombre.Location = new System.Drawing.Point(104, 131);
            this.TextNombre.Margin = new System.Windows.Forms.Padding(2);
            this.TextNombre.Name = "TextNombre";
            this.TextNombre.Size = new System.Drawing.Size(68, 20);
            this.TextNombre.TabIndex = 3;
            // 
            // TextApellido
            // 
            this.TextApellido.Enabled = false;
            this.TextApellido.Location = new System.Drawing.Point(104, 158);
            this.TextApellido.Margin = new System.Windows.Forms.Padding(2);
            this.TextApellido.Name = "TextApellido";
            this.TextApellido.Size = new System.Drawing.Size(68, 20);
            this.TextApellido.TabIndex = 3;
            // 
            // TextEdad
            // 
            this.TextEdad.Enabled = false;
            this.TextEdad.Location = new System.Drawing.Point(104, 184);
            this.TextEdad.Margin = new System.Windows.Forms.Padding(2);
            this.TextEdad.Name = "TextEdad";
            this.TextEdad.Size = new System.Drawing.Size(68, 20);
            this.TextEdad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(17, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cedula:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(17, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(17, 156);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Apellido";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(17, 181);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Edad:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(281, 41);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Psicologo:";
            // 
            // CmbPsicologos
            // 
            this.CmbPsicologos.FormattingEnabled = true;
            this.CmbPsicologos.Location = new System.Drawing.Point(374, 43);
            this.CmbPsicologos.Margin = new System.Windows.Forms.Padding(2);
            this.CmbPsicologos.Name = "CmbPsicologos";
            this.CmbPsicologos.Size = new System.Drawing.Size(149, 21);
            this.CmbPsicologos.TabIndex = 6;
            // 
            // BtnAgendar
            // 
            this.BtnAgendar.FlatAppearance.BorderSize = 0;
            this.BtnAgendar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnAgendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgendar.Location = new System.Drawing.Point(289, 192);
            this.BtnAgendar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAgendar.Name = "BtnAgendar";
            this.BtnAgendar.Size = new System.Drawing.Size(63, 24);
            this.BtnAgendar.TabIndex = 7;
            this.BtnAgendar.Text = "Agendar";
            this.BtnAgendar.UseVisualStyleBackColor = true;
            this.BtnAgendar.Click += new System.EventHandler(this.BtnAgendar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(434, 192);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(88, 24);
            this.BtnCancelar.TabIndex = 7;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(281, 78);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 19);
            this.label7.TabIndex = 5;
            this.label7.Text = "Elegir Fecha:";
            // 
            // DtpFecha
            // 
            this.DtpFecha.Location = new System.Drawing.Point(374, 80);
            this.DtpFecha.Margin = new System.Windows.Forms.Padding(2);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(149, 20);
            this.DtpFecha.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(281, 116);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 19);
            this.label8.TabIndex = 5;
            this.label8.Text = "Elegir hora:";
            // 
            // CmbHora
            // 
            this.CmbHora.FormattingEnabled = true;
            this.CmbHora.Items.AddRange(new object[] {
            "8:00 Am - 9:00 Am",
            "9:00 Am - 10:00 Am",
            "10:00 Am - 11:00 Am",
            "11:00 Am - 12:00 Am",
            "2:00 Pm - 3:00 Pm",
            "4:00 Pm - 5:00 Pm"});
            this.CmbHora.Location = new System.Drawing.Point(374, 120);
            this.CmbHora.Margin = new System.Windows.Forms.Padding(2);
            this.CmbHora.Name = "CmbHora";
            this.CmbHora.Size = new System.Drawing.Size(149, 21);
            this.CmbHora.TabIndex = 9;
            // 
            // DtgCitas
            // 
            this.DtgCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgCitas.Location = new System.Drawing.Point(20, 250);
            this.DtgCitas.Margin = new System.Windows.Forms.Padding(2);
            this.DtgCitas.Name = "DtgCitas";
            this.DtgCitas.RowHeadersWidth = 62;
            this.DtgCitas.RowTemplate.Height = 28;
            this.DtgCitas.Size = new System.Drawing.Size(520, 164);
            this.DtgCitas.TabIndex = 45;
            // 
            // FrmAgendamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(602, 461);
            this.Controls.Add(this.DtgCitas);
            this.Controls.Add(this.CmbHora);
            this.Controls.Add(this.DtpFecha);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAgendar);
            this.Controls.Add(this.CmbPsicologos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextEdad);
            this.Controls.Add(this.TextApellido);
            this.Controls.Add(this.TextNombre);
            this.Controls.Add(this.TextCedulaPaciente);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TextCedula);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmAgendamiento";
            this.Text = "FrmAgendamiento";
            this.Load += new System.EventHandler(this.FrmAgendamiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgCitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextCedula;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TextCedulaPaciente;
        private System.Windows.Forms.TextBox TextNombre;
        private System.Windows.Forms.TextBox TextApellido;
        private System.Windows.Forms.TextBox TextEdad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CmbPsicologos;
        private System.Windows.Forms.Button BtnAgendar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CmbHora;
        private System.Windows.Forms.DataGridView DtgCitas;
    }
}
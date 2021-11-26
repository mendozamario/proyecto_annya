
namespace PresentacionGUI
{
    partial class FrmAgregarEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarEmpleado));
            this.DateTimeNacimiento = new System.Windows.Forms.DateTimePicker();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.TextDireccion = new System.Windows.Forms.TextBox();
            this.TextMail = new System.Windows.Forms.TextBox();
            this.TextMovil = new System.Windows.Forms.TextBox();
            this.TextApellido = new System.Windows.Forms.TextBox();
            this.TextNombre = new System.Windows.Forms.TextBox();
            this.TextIdentificacion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CheckEspecialidad = new System.Windows.Forms.CheckBox();
            this.TextEspecialidad = new System.Windows.Forms.TextBox();
            this.CmbSexo = new System.Windows.Forms.ComboBox();
            this.LblEspecialidad = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.CmbTipoId = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // DateTimeNacimiento
            // 
            this.DateTimeNacimiento.Location = new System.Drawing.Point(343, 302);
            this.DateTimeNacimiento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DateTimeNacimiento.Name = "DateTimeNacimiento";
            this.DateTimeNacimiento.Size = new System.Drawing.Size(488, 26);
            this.DateTimeNacimiento.TabIndex = 42;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.White;
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.Black;
            this.BtnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancelar.Image")));
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelar.Location = new System.Drawing.Point(712, 624);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(131, 46);
            this.BtnCancelar.TabIndex = 41;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // TextDireccion
            // 
            this.TextDireccion.Location = new System.Drawing.Point(345, 465);
            this.TextDireccion.Name = "TextDireccion";
            this.TextDireccion.Size = new System.Drawing.Size(488, 26);
            this.TextDireccion.TabIndex = 38;
            // 
            // TextMail
            // 
            this.TextMail.Location = new System.Drawing.Point(343, 410);
            this.TextMail.Name = "TextMail";
            this.TextMail.Size = new System.Drawing.Size(488, 26);
            this.TextMail.TabIndex = 37;
            // 
            // TextMovil
            // 
            this.TextMovil.Location = new System.Drawing.Point(343, 354);
            this.TextMovil.Name = "TextMovil";
            this.TextMovil.Size = new System.Drawing.Size(488, 26);
            this.TextMovil.TabIndex = 36;
            // 
            // TextApellido
            // 
            this.TextApellido.Location = new System.Drawing.Point(343, 194);
            this.TextApellido.Name = "TextApellido";
            this.TextApellido.Size = new System.Drawing.Size(488, 26);
            this.TextApellido.TabIndex = 34;
            // 
            // TextNombre
            // 
            this.TextNombre.Location = new System.Drawing.Point(343, 138);
            this.TextNombre.Name = "TextNombre";
            this.TextNombre.Size = new System.Drawing.Size(488, 26);
            this.TextNombre.TabIndex = 33;
            // 
            // TextIdentificacion
            // 
            this.TextIdentificacion.Location = new System.Drawing.Point(343, 83);
            this.TextIdentificacion.Name = "TextIdentificacion";
            this.TextIdentificacion.Size = new System.Drawing.Size(488, 26);
            this.TextIdentificacion.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(47, 462);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 29);
            this.label9.TabIndex = 31;
            this.label9.Text = "Direccion:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(47, 407);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 29);
            this.label8.TabIndex = 30;
            this.label8.Text = "E-Mail:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(47, 351);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 29);
            this.label7.TabIndex = 29;
            this.label7.Text = "Telefono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(47, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 29);
            this.label5.TabIndex = 27;
            this.label5.Text = "Fecha de Nacimiento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(47, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 29);
            this.label4.TabIndex = 26;
            this.label4.Text = "Sexo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(47, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 29);
            this.label3.TabIndex = 25;
            this.label3.Text = "Apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(49, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 29);
            this.label2.TabIndex = 24;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(47, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "Identificacion:";
            // 
            // CheckEspecialidad
            // 
            this.CheckEspecialidad.AutoSize = true;
            this.CheckEspecialidad.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckEspecialidad.ForeColor = System.Drawing.Color.Black;
            this.CheckEspecialidad.Location = new System.Drawing.Point(343, 517);
            this.CheckEspecialidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CheckEspecialidad.Name = "CheckEspecialidad";
            this.CheckEspecialidad.Size = new System.Drawing.Size(131, 28);
            this.CheckEspecialidad.TabIndex = 48;
            this.CheckEspecialidad.Text = "Especialidad";
            this.CheckEspecialidad.UseVisualStyleBackColor = true;
            this.CheckEspecialidad.CheckedChanged += new System.EventHandler(this.CheckEspecialidad_CheckedChanged);
            // 
            // TextEspecialidad
            // 
            this.TextEspecialidad.Location = new System.Drawing.Point(343, 569);
            this.TextEspecialidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextEspecialidad.Name = "TextEspecialidad";
            this.TextEspecialidad.Size = new System.Drawing.Size(488, 26);
            this.TextEspecialidad.TabIndex = 49;
            // 
            // CmbSexo
            // 
            this.CmbSexo.FormattingEnabled = true;
            this.CmbSexo.Items.AddRange(new object[] {
            "Masculino\t",
            "Femenino"});
            this.CmbSexo.Location = new System.Drawing.Point(343, 249);
            this.CmbSexo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbSexo.Name = "CmbSexo";
            this.CmbSexo.Size = new System.Drawing.Size(488, 28);
            this.CmbSexo.TabIndex = 45;
            // 
            // LblEspecialidad
            // 
            this.LblEspecialidad.AutoSize = true;
            this.LblEspecialidad.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEspecialidad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblEspecialidad.Location = new System.Drawing.Point(47, 569);
            this.LblEspecialidad.Name = "LblEspecialidad";
            this.LblEspecialidad.Size = new System.Drawing.Size(134, 29);
            this.LblEspecialidad.TabIndex = 50;
            this.LblEspecialidad.Text = "Especialidad:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.White;
            this.BtnGuardar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnGuardar.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuardar.Image")));
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.Location = new System.Drawing.Point(48, 624);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(131, 46);
            this.BtnGuardar.TabIndex = 51;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(47, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 29);
            this.label6.TabIndex = 23;
            this.label6.Text = "Tipo Identificacion:";
            // 
            // CmbTipoId
            // 
            this.CmbTipoId.FormattingEnabled = true;
            this.CmbTipoId.Items.AddRange(new object[] {
            "C.C",
            "T.I"});
            this.CmbTipoId.Location = new System.Drawing.Point(343, 28);
            this.CmbTipoId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbTipoId.Name = "CmbTipoId";
            this.CmbTipoId.Size = new System.Drawing.Size(488, 28);
            this.CmbTipoId.TabIndex = 45;
            // 
            // FrmAgregarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(903, 682);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.LblEspecialidad);
            this.Controls.Add(this.TextEspecialidad);
            this.Controls.Add(this.CheckEspecialidad);
            this.Controls.Add(this.CmbTipoId);
            this.Controls.Add(this.CmbSexo);
            this.Controls.Add(this.DateTimeNacimiento);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.TextDireccion);
            this.Controls.Add(this.TextMail);
            this.Controls.Add(this.TextMovil);
            this.Controls.Add(this.TextApellido);
            this.Controls.Add(this.TextNombre);
            this.Controls.Add(this.TextIdentificacion);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAgregarEmpleado";
            this.Text = "FrmAgregarEmpleado";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DateTimeNacimiento;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.TextBox TextDireccion;
        private System.Windows.Forms.TextBox TextMail;
        private System.Windows.Forms.TextBox TextMovil;
        private System.Windows.Forms.TextBox TextApellido;
        private System.Windows.Forms.TextBox TextNombre;
        private System.Windows.Forms.TextBox TextIdentificacion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CheckEspecialidad;
        private System.Windows.Forms.TextBox TextEspecialidad;
        private System.Windows.Forms.ComboBox CmbSexo;
        private System.Windows.Forms.Label LblEspecialidad;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.ComboBox CmbTipoId;
        private System.Windows.Forms.Label label6;
    }
}

namespace PresentacionGUI
{
    partial class FrmAgregarNotas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarNotas));
            this.label1 = new System.Windows.Forms.Label();
            this.TextId = new System.Windows.Forms.TextBox();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TextNotas = new System.Windows.Forms.TextBox();
            this.TextDiagnostico = new System.Windows.Forms.TextBox();
            this.DtgCitas = new System.Windows.Forms.DataGridView();
            this.BtnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DtgCitas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 29);
            this.label1.TabIndex = 46;
            this.label1.Text = "Id Psicologo:";
            // 
            // TextId
            // 
            this.TextId.Location = new System.Drawing.Point(171, 25);
            this.TextId.Name = "TextId";
            this.TextId.Size = new System.Drawing.Size(120, 26);
            this.TextId.TabIndex = 47;
            this.TextId.TextChanged += new System.EventHandler(this.TextIdSesion_TextChanged);
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnConsultar.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnConsultar.Location = new System.Drawing.Point(297, 14);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(111, 45);
            this.BtnConsultar.TabIndex = 54;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(70, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 29);
            this.label5.TabIndex = 50;
            this.label5.Text = "Notas:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(20, 409);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 29);
            this.label6.TabIndex = 50;
            this.label6.Text = "Diagnostico:";
            // 
            // TextNotas
            // 
            this.TextNotas.Enabled = false;
            this.TextNotas.Location = new System.Drawing.Point(171, 248);
            this.TextNotas.Multiline = true;
            this.TextNotas.Name = "TextNotas";
            this.TextNotas.Size = new System.Drawing.Size(648, 155);
            this.TextNotas.TabIndex = 55;
            // 
            // TextDiagnostico
            // 
            this.TextDiagnostico.Enabled = false;
            this.TextDiagnostico.Location = new System.Drawing.Point(171, 409);
            this.TextDiagnostico.Multiline = true;
            this.TextDiagnostico.Name = "TextDiagnostico";
            this.TextDiagnostico.Size = new System.Drawing.Size(648, 168);
            this.TextDiagnostico.TabIndex = 56;
            // 
            // DtgCitas
            // 
            this.DtgCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgCitas.Location = new System.Drawing.Point(171, 76);
            this.DtgCitas.Name = "DtgCitas";
            this.DtgCitas.RowHeadersWidth = 62;
            this.DtgCitas.RowTemplate.Height = 28;
            this.DtgCitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtgCitas.Size = new System.Drawing.Size(648, 150);
            this.DtgCitas.TabIndex = 57;
            this.DtgCitas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgCitas_CellDoubleClick);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.White;
            this.BtnGuardar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnGuardar.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuardar.Image")));
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.Location = new System.Drawing.Point(171, 600);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(131, 46);
            this.BtnGuardar.TabIndex = 58;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // FrmAgregarNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(903, 682);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.DtgCitas);
            this.Controls.Add(this.TextDiagnostico);
            this.Controls.Add(this.TextNotas);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TextId);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAgregarNotas";
            this.Text = "ClinicPlanner";
            ((System.ComponentModel.ISupportInitialize)(this.DtgCitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextId;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextNotas;
        private System.Windows.Forms.TextBox TextDiagnostico;
        private System.Windows.Forms.DataGridView DtgCitas;
        private System.Windows.Forms.Button BtnGuardar;
    }
}
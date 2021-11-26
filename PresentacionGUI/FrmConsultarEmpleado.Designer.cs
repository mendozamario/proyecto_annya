
namespace PresentacionGUI
{
    partial class FrmConsultarEmpleado
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
            this.TextId = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.DtgEmpleado = new System.Windows.Forms.DataGridView();
            this.CmbFiltro = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DtgEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // TextId
            // 
            this.TextId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextId.Cursor = System.Windows.Forms.Cursors.Default;
            this.TextId.Location = new System.Drawing.Point(509, 60);
            this.TextId.Name = "TextId";
            this.TextId.Size = new System.Drawing.Size(148, 26);
            this.TextId.TabIndex = 5;
            this.TextId.TextChanged += new System.EventHandler(this.TextId_TextChanged);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Location = new System.Drawing.Point(12, 94);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(109, 40);
            this.BtnBuscar.TabIndex = 4;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // DtgEmpleado
            // 
            this.DtgEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DtgEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgEmpleado.Location = new System.Drawing.Point(12, 140);
            this.DtgEmpleado.Name = "DtgEmpleado";
            this.DtgEmpleado.ReadOnly = true;
            this.DtgEmpleado.RowHeadersWidth = 62;
            this.DtgEmpleado.RowTemplate.Height = 28;
            this.DtgEmpleado.Size = new System.Drawing.Size(836, 364);
            this.DtgEmpleado.TabIndex = 3;
            // 
            // CmbFiltro
            // 
            this.CmbFiltro.FormattingEnabled = true;
            this.CmbFiltro.Items.AddRange(new object[] {
            "Todos",
            "Activos",
            "Inactivos"});
            this.CmbFiltro.Location = new System.Drawing.Point(12, 60);
            this.CmbFiltro.Name = "CmbFiltro";
            this.CmbFiltro.Size = new System.Drawing.Size(148, 28);
            this.CmbFiltro.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Identificacion:";
            // 
            // FrmConsultarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(903, 682);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbFiltro);
            this.Controls.Add(this.TextId);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.DtgEmpleado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultarEmpleado";
            this.Text = "FrmConsultarEmpleado";
            ((System.ComponentModel.ISupportInitialize)(this.DtgEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextId;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.DataGridView DtgEmpleado;
        private System.Windows.Forms.ComboBox CmbFiltro;
        private System.Windows.Forms.Label label1;
    }
}
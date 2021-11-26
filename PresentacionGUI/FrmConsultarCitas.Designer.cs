
namespace PresentacionGUI
{
    partial class FrmConsultarCitas
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
            this.DtgCitas = new System.Windows.Forms.DataGridView();
            this.LabelFilter = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.CmbFiltro = new System.Windows.Forms.ComboBox();
            this.TextId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DtgCitas)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgCitas
            // 
            this.DtgCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgCitas.Location = new System.Drawing.Point(28, 156);
            this.DtgCitas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DtgCitas.Name = "DtgCitas";
            this.DtgCitas.ReadOnly = true;
            this.DtgCitas.RowHeadersWidth = 62;
            this.DtgCitas.Size = new System.Drawing.Size(831, 438);
            this.DtgCitas.TabIndex = 0;
            // 
            // LabelFilter
            // 
            this.LabelFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelFilter.AutoSize = true;
            this.LabelFilter.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFilter.ForeColor = System.Drawing.Color.Black;
            this.LabelFilter.Location = new System.Drawing.Point(387, 58);
            this.LabelFilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelFilter.Name = "LabelFilter";
            this.LabelFilter.Size = new System.Drawing.Size(137, 29);
            this.LabelFilter.TabIndex = 1;
            this.LabelFilter.Text = "Filtrar por ID:";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnBuscar.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnBuscar.Location = new System.Drawing.Point(28, 63);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(96, 33);
            this.BtnBuscar.TabIndex = 3;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // CmbFiltro
            // 
            this.CmbFiltro.FormattingEnabled = true;
            this.CmbFiltro.Items.AddRange(new object[] {
            "Todos",
            "Pendiente",
            "Cancelado",
            "Finalizado"});
            this.CmbFiltro.Location = new System.Drawing.Point(141, 68);
            this.CmbFiltro.Name = "CmbFiltro";
            this.CmbFiltro.Size = new System.Drawing.Size(157, 28);
            this.CmbFiltro.TabIndex = 4;
            // 
            // TextId
            // 
            this.TextId.Location = new System.Drawing.Point(557, 63);
            this.TextId.Name = "TextId";
            this.TextId.Size = new System.Drawing.Size(123, 26);
            this.TextId.TabIndex = 2;
            this.TextId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FrmConsultarCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(903, 682);
            this.Controls.Add(this.CmbFiltro);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TextId);
            this.Controls.Add(this.LabelFilter);
            this.Controls.Add(this.DtgCitas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmConsultarCitas";
            this.Text = "FrmConsultarCitas";
            ((System.ComponentModel.ISupportInitialize)(this.DtgCitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgCitas;
        private System.Windows.Forms.Label LabelFilter;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.ComboBox CmbFiltro;
        private System.Windows.Forms.TextBox TextId;
    }
}
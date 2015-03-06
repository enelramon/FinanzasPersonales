namespace FinanzasPersonales.Consultas
{
    partial class cGastos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cGastos));
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.BuscarButtom = new System.Windows.Forms.Button();
            this.FiltroTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BuscarPorComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CancelarButtom = new System.Windows.Forms.Button();
            this.AceptarButtom = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TotaltextBox = new System.Windows.Forms.TextBox();
            this.CantidadtextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToAddRows = false;
            this.DataGridView.AllowUserToDeleteRows = false;
            this.DataGridView.AllowUserToOrderColumns = true;
            this.DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(12, 42);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.ReadOnly = true;
            this.DataGridView.Size = new System.Drawing.Size(606, 265);
            this.DataGridView.TabIndex = 0;
            // 
            // BuscarButtom
            // 
            this.BuscarButtom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BuscarButtom.Image = ((System.Drawing.Image)(resources.GetObject("BuscarButtom.Image")));
            this.BuscarButtom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButtom.Location = new System.Drawing.Point(538, 12);
            this.BuscarButtom.Name = "BuscarButtom";
            this.BuscarButtom.Size = new System.Drawing.Size(76, 24);
            this.BuscarButtom.TabIndex = 38;
            this.BuscarButtom.Text = "Buscar";
            this.BuscarButtom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarButtom.UseVisualStyleBackColor = true;
            this.BuscarButtom.Click += new System.EventHandler(this.BuscarButtom_Click);
            // 
            // FiltroTextBox
            // 
            this.FiltroTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FiltroTextBox.Location = new System.Drawing.Point(210, 15);
            this.FiltroTextBox.Name = "FiltroTextBox";
            this.FiltroTextBox.Size = new System.Drawing.Size(314, 20);
            this.FiltroTextBox.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "=";
            // 
            // BuscarPorComboBox
            // 
            this.BuscarPorComboBox.FormattingEnabled = true;
            this.BuscarPorComboBox.Items.AddRange(new object[] {
            "IdGasto",
            "Fecha",
            "IdCuenta",
            "IdSubClas",
            "Concepto",
            "Monto"});
            this.BuscarPorComboBox.Location = new System.Drawing.Point(83, 15);
            this.BuscarPorComboBox.Name = "BuscarPorComboBox";
            this.BuscarPorComboBox.Size = new System.Drawing.Size(102, 21);
            this.BuscarPorComboBox.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Buscar Por:";
            // 
            // CancelarButtom
            // 
            this.CancelarButtom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CancelarButtom.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelarButtom.Image = ((System.Drawing.Image)(resources.GetObject("CancelarButtom.Image")));
            this.CancelarButtom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelarButtom.Location = new System.Drawing.Point(344, 316);
            this.CancelarButtom.Name = "CancelarButtom";
            this.CancelarButtom.Size = new System.Drawing.Size(75, 33);
            this.CancelarButtom.TabIndex = 49;
            this.CancelarButtom.Text = "Cancelar";
            this.CancelarButtom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CancelarButtom.UseVisualStyleBackColor = true;
            // 
            // AceptarButtom
            // 
            this.AceptarButtom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AceptarButtom.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.AceptarButtom.Image = ((System.Drawing.Image)(resources.GetObject("AceptarButtom.Image")));
            this.AceptarButtom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AceptarButtom.Location = new System.Drawing.Point(210, 316);
            this.AceptarButtom.Name = "AceptarButtom";
            this.AceptarButtom.Size = new System.Drawing.Size(75, 33);
            this.AceptarButtom.TabIndex = 48;
            this.AceptarButtom.Text = "Aceptar";
            this.AceptarButtom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AceptarButtom.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(474, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Total:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Cantidad:";
            // 
            // TotaltextBox
            // 
            this.TotaltextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TotaltextBox.Location = new System.Drawing.Point(514, 323);
            this.TotaltextBox.Name = "TotaltextBox";
            this.TotaltextBox.Size = new System.Drawing.Size(100, 20);
            this.TotaltextBox.TabIndex = 45;
            // 
            // CantidadtextBox
            // 
            this.CantidadtextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CantidadtextBox.Location = new System.Drawing.Point(67, 323);
            this.CantidadtextBox.Name = "CantidadtextBox";
            this.CantidadtextBox.Size = new System.Drawing.Size(53, 20);
            this.CantidadtextBox.TabIndex = 44;
            // 
            // cGastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 361);
            this.Controls.Add(this.CancelarButtom);
            this.Controls.Add(this.AceptarButtom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TotaltextBox);
            this.Controls.Add(this.CantidadtextBox);
            this.Controls.Add(this.BuscarButtom);
            this.Controls.Add(this.FiltroTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BuscarPorComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGridView);
            this.Name = "cGastos";
            this.Text = "Consulta de Gastos";
            this.Load += new System.EventHandler(this.cGastos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Button BuscarButtom;
        private System.Windows.Forms.TextBox FiltroTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox BuscarPorComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CancelarButtom;
        private System.Windows.Forms.Button AceptarButtom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TotaltextBox;
        private System.Windows.Forms.TextBox CantidadtextBox;
    }
}
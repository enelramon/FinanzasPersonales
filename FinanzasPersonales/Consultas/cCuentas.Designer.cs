namespace FinanzasPersonales.Consultas
{
    partial class cCuentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cCuentas));
            this.DatosdataGridView = new System.Windows.Forms.DataGridView();
            this.BuscarButtom = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BuscarPorcomboBox = new System.Windows.Forms.ComboBox();
            this.FiltrotextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CantidadtextBox = new System.Windows.Forms.TextBox();
            this.TotaltextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CancelarButtom = new System.Windows.Forms.Button();
            this.AceptarButtom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DatosdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DatosdataGridView
            // 
            this.DatosdataGridView.AllowUserToAddRows = false;
            this.DatosdataGridView.AllowUserToDeleteRows = false;
            this.DatosdataGridView.AllowUserToOrderColumns = true;
            this.DatosdataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DatosdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosdataGridView.Location = new System.Drawing.Point(12, 43);
            this.DatosdataGridView.Name = "DatosdataGridView";
            this.DatosdataGridView.ReadOnly = true;
            this.DatosdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatosdataGridView.Size = new System.Drawing.Size(546, 315);
            this.DatosdataGridView.TabIndex = 0;
            this.DatosdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatosdataGridView_CellContentClick);
            // 
            // BuscarButtom
            // 
            this.BuscarButtom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BuscarButtom.Image = ((System.Drawing.Image)(resources.GetObject("BuscarButtom.Image")));
            this.BuscarButtom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButtom.Location = new System.Drawing.Point(482, 10);
            this.BuscarButtom.Name = "BuscarButtom";
            this.BuscarButtom.Size = new System.Drawing.Size(76, 24);
            this.BuscarButtom.TabIndex = 32;
            this.BuscarButtom.Text = "Buscar";
            this.BuscarButtom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarButtom.UseVisualStyleBackColor = true;
            this.BuscarButtom.Click += new System.EventHandler(this.BuscarButtom_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Buscar Por:";
            // 
            // BuscarPorcomboBox
            // 
            this.BuscarPorcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BuscarPorcomboBox.FormattingEnabled = true;
            this.BuscarPorcomboBox.Items.AddRange(new object[] {
            "IdCuenta",
            "Descripcion"});
            this.BuscarPorcomboBox.Location = new System.Drawing.Point(81, 12);
            this.BuscarPorcomboBox.Name = "BuscarPorcomboBox";
            this.BuscarPorcomboBox.Size = new System.Drawing.Size(101, 21);
            this.BuscarPorcomboBox.TabIndex = 35;
            // 
            // FiltrotextBox
            // 
            this.FiltrotextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FiltrotextBox.Location = new System.Drawing.Point(208, 12);
            this.FiltrotextBox.Name = "FiltrotextBox";
            this.FiltrotextBox.Size = new System.Drawing.Size(268, 20);
            this.FiltrotextBox.TabIndex = 36;
            this.FiltrotextBox.TextChanged += new System.EventHandler(this.FiltrotextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "=";
            // 
            // CantidadtextBox
            // 
            this.CantidadtextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CantidadtextBox.Location = new System.Drawing.Point(69, 364);
            this.CantidadtextBox.Name = "CantidadtextBox";
            this.CantidadtextBox.Size = new System.Drawing.Size(53, 20);
            this.CantidadtextBox.TabIndex = 38;
            // 
            // TotaltextBox
            // 
            this.TotaltextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TotaltextBox.Location = new System.Drawing.Point(460, 364);
            this.TotaltextBox.Name = "TotaltextBox";
            this.TotaltextBox.Size = new System.Drawing.Size(100, 20);
            this.TotaltextBox.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Cantidad:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(420, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Total:";
            // 
            // CancelarButtom
            // 
            this.CancelarButtom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CancelarButtom.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelarButtom.Image = ((System.Drawing.Image)(resources.GetObject("CancelarButtom.Image")));
            this.CancelarButtom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelarButtom.Location = new System.Drawing.Point(289, 388);
            this.CancelarButtom.Name = "CancelarButtom";
            this.CancelarButtom.Size = new System.Drawing.Size(82, 33);
            this.CancelarButtom.TabIndex = 43;
            this.CancelarButtom.Text = "Cancelar";
            this.CancelarButtom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CancelarButtom.UseVisualStyleBackColor = true;
            this.CancelarButtom.Click += new System.EventHandler(this.CancelarButtom_Click);
            // 
            // AceptarButtom
            // 
            this.AceptarButtom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AceptarButtom.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.AceptarButtom.Image = ((System.Drawing.Image)(resources.GetObject("AceptarButtom.Image")));
            this.AceptarButtom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AceptarButtom.Location = new System.Drawing.Point(200, 388);
            this.AceptarButtom.Name = "AceptarButtom";
            this.AceptarButtom.Size = new System.Drawing.Size(82, 33);
            this.AceptarButtom.TabIndex = 42;
            this.AceptarButtom.Text = "Aceptar";
            this.AceptarButtom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AceptarButtom.UseVisualStyleBackColor = true;
            this.AceptarButtom.Click += new System.EventHandler(this.AceptarButtom_Click);
            // 
            // cCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 431);
            this.Controls.Add(this.CancelarButtom);
            this.Controls.Add(this.AceptarButtom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TotaltextBox);
            this.Controls.Add(this.CantidadtextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FiltrotextBox);
            this.Controls.Add(this.BuscarPorcomboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BuscarButtom);
            this.Controls.Add(this.DatosdataGridView);
            this.Name = "cCuentas";
            this.Text = "Consulta de Cuentas";
            ((System.ComponentModel.ISupportInitialize)(this.DatosdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BuscarButtom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox BuscarPorcomboBox;
        private System.Windows.Forms.TextBox FiltrotextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CantidadtextBox;
        private System.Windows.Forms.TextBox TotaltextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CancelarButtom;
        private System.Windows.Forms.Button AceptarButtom;
        protected System.Windows.Forms.DataGridView DatosdataGridView;
    }
}
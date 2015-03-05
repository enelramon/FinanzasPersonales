namespace FinanzasPersonales.Registros
{
    partial class rPresupuesto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rPresupuesto));
            this.DetalledataGridView = new System.Windows.Forms.DataGridView();
            this.ClasificacioncomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ValortextBox = new System.Windows.Forms.TextBox();
            this.GuardarButtom = new System.Windows.Forms.Button();
            this.IdtextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BuscarButtom = new System.Windows.Forms.Button();
            this.DescripciontextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.LimpiarButtom = new System.Windows.Forms.Button();
            this.BorrarButtom = new System.Windows.Forms.Button();
            this.Secuencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clasificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DetalledataGridView
            // 
            this.DetalledataGridView.AllowUserToAddRows = false;
            this.DetalledataGridView.AllowUserToDeleteRows = false;
            this.DetalledataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalledataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Secuencia,
            this.Clasificacion,
            this.Valor});
            this.DetalledataGridView.Location = new System.Drawing.Point(12, 88);
            this.DetalledataGridView.Name = "DetalledataGridView";
            this.DetalledataGridView.ReadOnly = true;
            this.DetalledataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DetalledataGridView.Size = new System.Drawing.Size(366, 150);
            this.DetalledataGridView.TabIndex = 0;
            // 
            // ClasificacioncomboBox
            // 
            this.ClasificacioncomboBox.FormattingEnabled = true;
            this.ClasificacioncomboBox.Location = new System.Drawing.Point(79, 61);
            this.ClasificacioncomboBox.Name = "ClasificacioncomboBox";
            this.ClasificacioncomboBox.Size = new System.Drawing.Size(121, 21);
            this.ClasificacioncomboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Clasificacion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor:";
            // 
            // ValortextBox
            // 
            this.ValortextBox.Location = new System.Drawing.Point(278, 61);
            this.ValortextBox.Name = "ValortextBox";
            this.ValortextBox.Size = new System.Drawing.Size(100, 20);
            this.ValortextBox.TabIndex = 4;
            // 
            // GuardarButtom
            // 
            this.GuardarButtom.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.GuardarButtom.Image = ((System.Drawing.Image)(resources.GetObject("GuardarButtom.Image")));
            this.GuardarButtom.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButtom.Location = new System.Drawing.Point(93, 254);
            this.GuardarButtom.Name = "GuardarButtom";
            this.GuardarButtom.Size = new System.Drawing.Size(75, 33);
            this.GuardarButtom.TabIndex = 16;
            this.GuardarButtom.Text = "Guardar";
            this.GuardarButtom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarButtom.UseVisualStyleBackColor = true;
            this.GuardarButtom.Click += new System.EventHandler(this.GuardarButtom_Click);
            // 
            // IdtextBox
            // 
            this.IdtextBox.Location = new System.Drawing.Point(79, 12);
            this.IdtextBox.Name = "IdtextBox";
            this.IdtextBox.Size = new System.Drawing.Size(67, 20);
            this.IdtextBox.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Id:";
            // 
            // BuscarButtom
            // 
            this.BuscarButtom.Image = ((System.Drawing.Image)(resources.GetObject("BuscarButtom.Image")));
            this.BuscarButtom.Location = new System.Drawing.Point(152, 7);
            this.BuscarButtom.Name = "BuscarButtom";
            this.BuscarButtom.Size = new System.Drawing.Size(34, 29);
            this.BuscarButtom.TabIndex = 32;
            this.BuscarButtom.UseVisualStyleBackColor = true;
            this.BuscarButtom.Click += new System.EventHandler(this.BuscarButtom_Click);
            // 
            // DescripciontextBox
            // 
            this.DescripciontextBox.Location = new System.Drawing.Point(79, 38);
            this.DescripciontextBox.Name = "DescripciontextBox";
            this.DescripciontextBox.Size = new System.Drawing.Size(299, 20);
            this.DescripciontextBox.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Descripcion:";
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Nuevobutton.Image = ((System.Drawing.Image)(resources.GetObject("Nuevobutton.Image")));
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Nuevobutton.Location = new System.Drawing.Point(197, 7);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 29);
            this.Nuevobutton.TabIndex = 35;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // LimpiarButtom
            // 
            this.LimpiarButtom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LimpiarButtom.Image = ((System.Drawing.Image)(resources.GetObject("LimpiarButtom.Image")));
            this.LimpiarButtom.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LimpiarButtom.Location = new System.Drawing.Point(12, 254);
            this.LimpiarButtom.Name = "LimpiarButtom";
            this.LimpiarButtom.Size = new System.Drawing.Size(75, 33);
            this.LimpiarButtom.TabIndex = 36;
            this.LimpiarButtom.Text = "Limpiar";
            this.LimpiarButtom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LimpiarButtom.UseVisualStyleBackColor = true;
            this.LimpiarButtom.Click += new System.EventHandler(this.LimpiarButtom_Click);
            // 
            // BorrarButtom
            // 
            this.BorrarButtom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BorrarButtom.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BorrarButtom.Image = ((System.Drawing.Image)(resources.GetObject("BorrarButtom.Image")));
            this.BorrarButtom.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BorrarButtom.Location = new System.Drawing.Point(174, 254);
            this.BorrarButtom.Name = "BorrarButtom";
            this.BorrarButtom.Size = new System.Drawing.Size(75, 33);
            this.BorrarButtom.TabIndex = 37;
            this.BorrarButtom.Text = "Borrar";
            this.BorrarButtom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BorrarButtom.UseVisualStyleBackColor = true;
            this.BorrarButtom.Click += new System.EventHandler(this.BorrarButtom_Click);
            // 
            // Secuencia
            // 
            this.Secuencia.HeaderText = "Column1";
            this.Secuencia.Name = "Secuencia";
            this.Secuencia.ReadOnly = true;
            this.Secuencia.Visible = false;
            // 
            // Clasificacion
            // 
            this.Clasificacion.HeaderText = "Clasificacion";
            this.Clasificacion.Name = "Clasificacion";
            this.Clasificacion.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // rPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 299);
            this.Controls.Add(this.BorrarButtom);
            this.Controls.Add(this.LimpiarButtom);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.DescripciontextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BuscarButtom);
            this.Controls.Add(this.IdtextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GuardarButtom);
            this.Controls.Add(this.ValortextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClasificacioncomboBox);
            this.Controls.Add(this.DetalledataGridView);
            this.Name = "rPresupuesto";
            this.Text = "rPresupuesto";
            this.Load += new System.EventHandler(this.rPresupuesto_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DetalledataGridView;
        private System.Windows.Forms.ComboBox ClasificacioncomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ValortextBox;
        private System.Windows.Forms.Button GuardarButtom;
        private System.Windows.Forms.TextBox IdtextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BuscarButtom;
        private System.Windows.Forms.TextBox DescripciontextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button LimpiarButtom;
        private System.Windows.Forms.Button BorrarButtom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Secuencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clasificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
    }
}
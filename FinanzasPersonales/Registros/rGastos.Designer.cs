namespace FinanzasPersonales.Registros
{
    partial class rGastos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rGastos));
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.MontoTextBox = new System.Windows.Forms.TextBox();
            this.ConceptoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LimpiarButtom = new System.Windows.Forms.Button();
            this.BorrarButtom = new System.Windows.Forms.Button();
            this.GuardarButtom = new System.Windows.Forms.Button();
            this.BuscarButtom = new System.Windows.Forms.Button();
            this.ErrorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.BuscarPorcomboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BuscarPor2comboBox = new System.Windows.Forms.ComboBox();
            this.ErrorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            this.SuspendLayout();
            // 
            // IDTextBox
            // 
            this.IDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IDTextBox.Location = new System.Drawing.Point(154, 12);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(44, 20);
            this.IDTextBox.TabIndex = 0;
            this.IDTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // MontoTextBox
            // 
            this.MontoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MontoTextBox.Location = new System.Drawing.Point(207, 119);
            this.MontoTextBox.Name = "MontoTextBox";
            this.MontoTextBox.Size = new System.Drawing.Size(43, 20);
            this.MontoTextBox.TabIndex = 3;
            this.MontoTextBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // ConceptoTextBox
            // 
            this.ConceptoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConceptoTextBox.Location = new System.Drawing.Point(85, 93);
            this.ConceptoTextBox.MaxLength = 80;
            this.ConceptoTextBox.Name = "ConceptoTextBox";
            this.ConceptoTextBox.Size = new System.Drawing.Size(165, 20);
            this.ConceptoTextBox.TabIndex = 4;
            this.ConceptoTextBox.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID del Gasto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Concepto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Monto";
            // 
            // LimpiarButtom
            // 
            this.LimpiarButtom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LimpiarButtom.Image = ((System.Drawing.Image)(resources.GetObject("LimpiarButtom.Image")));
            this.LimpiarButtom.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LimpiarButtom.Location = new System.Drawing.Point(22, 216);
            this.LimpiarButtom.Name = "LimpiarButtom";
            this.LimpiarButtom.Size = new System.Drawing.Size(75, 33);
            this.LimpiarButtom.TabIndex = 30;
            this.LimpiarButtom.Text = "Limpiar";
            this.LimpiarButtom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LimpiarButtom.UseVisualStyleBackColor = true;
            this.LimpiarButtom.Click += new System.EventHandler(this.LimpiarButtom_Click);
            // 
            // BorrarButtom
            // 
            this.BorrarButtom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BorrarButtom.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BorrarButtom.Image = ((System.Drawing.Image)(resources.GetObject("BorrarButtom.Image")));
            this.BorrarButtom.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BorrarButtom.Location = new System.Drawing.Point(184, 216);
            this.BorrarButtom.Name = "BorrarButtom";
            this.BorrarButtom.Size = new System.Drawing.Size(75, 33);
            this.BorrarButtom.TabIndex = 29;
            this.BorrarButtom.Text = "Borrar";
            this.BorrarButtom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BorrarButtom.UseVisualStyleBackColor = true;
            this.BorrarButtom.Click += new System.EventHandler(this.BorrarButtom_Click);
            // 
            // GuardarButtom
            // 
            this.GuardarButtom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GuardarButtom.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.GuardarButtom.Image = ((System.Drawing.Image)(resources.GetObject("GuardarButtom.Image")));
            this.GuardarButtom.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButtom.Location = new System.Drawing.Point(103, 216);
            this.GuardarButtom.Name = "GuardarButtom";
            this.GuardarButtom.Size = new System.Drawing.Size(75, 33);
            this.GuardarButtom.TabIndex = 28;
            this.GuardarButtom.Text = "Guardar";
            this.GuardarButtom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarButtom.UseVisualStyleBackColor = true;
            this.GuardarButtom.Click += new System.EventHandler(this.GuardarButtom_Click);
            // 
            // BuscarButtom
            // 
            this.BuscarButtom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BuscarButtom.Image = ((System.Drawing.Image)(resources.GetObject("BuscarButtom.Image")));
            this.BuscarButtom.Location = new System.Drawing.Point(234, 9);
            this.BuscarButtom.Name = "BuscarButtom";
            this.BuscarButtom.Size = new System.Drawing.Size(34, 24);
            this.BuscarButtom.TabIndex = 31;
            this.BuscarButtom.UseVisualStyleBackColor = true;
            this.BuscarButtom.Click += new System.EventHandler(this.BuscarButtom_Click);
            // 
            // ErrorProvider1
            // 
            this.ErrorProvider1.ContainerControl = this;
            // 
            // BuscarPorcomboBox
            // 
            this.BuscarPorcomboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BuscarPorcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BuscarPorcomboBox.FormattingEnabled = true;
            this.BuscarPorcomboBox.Items.AddRange(new object[] {
            "IdCuenta",
            "Descripcion"});
            this.BuscarPorcomboBox.Location = new System.Drawing.Point(150, 40);
            this.BuscarPorcomboBox.Name = "BuscarPorcomboBox";
            this.BuscarPorcomboBox.Size = new System.Drawing.Size(105, 21);
            this.BuscarPorcomboBox.TabIndex = 37;
            this.BuscarPorcomboBox.SelectedIndexChanged += new System.EventHandler(this.BuscarPorcomboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Buscar Cuenta Por:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "ID de SubClasificacion";
            // 
            // BuscarPor2comboBox
            // 
            this.BuscarPor2comboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BuscarPor2comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BuscarPor2comboBox.FormattingEnabled = true;
            this.BuscarPor2comboBox.Items.AddRange(new object[] {
            "IdSubClas",
            "Descripcion"});
            this.BuscarPor2comboBox.Location = new System.Drawing.Point(150, 67);
            this.BuscarPor2comboBox.Name = "BuscarPor2comboBox";
            this.BuscarPor2comboBox.Size = new System.Drawing.Size(105, 21);
            this.BuscarPor2comboBox.TabIndex = 38;
            this.BuscarPor2comboBox.SelectedIndexChanged += new System.EventHandler(this.BuscarPor2comboBox_SelectedIndexChanged);
            // 
            // ErrorProvider2
            // 
            this.ErrorProvider2.ContainerControl = this;
            // 
            // ErrorProvider3
            // 
            this.ErrorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // rGastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 261);
            this.Controls.Add(this.BuscarPor2comboBox);
            this.Controls.Add(this.BuscarPorcomboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BuscarButtom);
            this.Controls.Add(this.LimpiarButtom);
            this.Controls.Add(this.BorrarButtom);
            this.Controls.Add(this.GuardarButtom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConceptoTextBox);
            this.Controls.Add(this.MontoTextBox);
            this.Controls.Add(this.IDTextBox);
            this.Name = "rGastos";
            this.Text = "Registro de Gastos";
            this.Load += new System.EventHandler(this.rGastos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.TextBox MontoTextBox;
        private System.Windows.Forms.TextBox ConceptoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button LimpiarButtom;
        private System.Windows.Forms.Button BorrarButtom;
        private System.Windows.Forms.Button GuardarButtom;
        private System.Windows.Forms.Button BuscarButtom;
        private System.Windows.Forms.ErrorProvider ErrorProvider1;
        private System.Windows.Forms.ComboBox BuscarPorcomboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox BuscarPor2comboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider ErrorProvider2;
        private System.Windows.Forms.ErrorProvider ErrorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
    }
}
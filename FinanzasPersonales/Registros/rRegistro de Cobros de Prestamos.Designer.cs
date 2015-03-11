namespace FinanzasPersonales.Registros
{
    partial class rRegistro_de_Cobros_de_Prestamos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rRegistro_de_Cobros_de_Prestamos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1Cobros = new System.Windows.Forms.TextBox();
            this.comboBox1Prestamo = new System.Windows.Forms.ComboBox();
            this.textBox2MontoCB = new System.Windows.Forms.TextBox();
            this.LimpiarButtomRegistro = new System.Windows.Forms.Button();
            this.BorrarButtomRegistro = new System.Windows.Forms.Button();
            this.GuardarButtomRegistro = new System.Windows.Forms.Button();
            this.textBox3Balance = new System.Windows.Forms.TextBox();
            this.BuscarButtomRegistro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prestamo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Balance Pendiente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Monto";
            // 
            // textBox1Cobros
            // 
            this.textBox1Cobros.Location = new System.Drawing.Point(113, 63);
            this.textBox1Cobros.Name = "textBox1Cobros";
            this.textBox1Cobros.Size = new System.Drawing.Size(89, 20);
            this.textBox1Cobros.TabIndex = 4;
            // 
            // comboBox1Prestamo
            // 
            this.comboBox1Prestamo.FormattingEnabled = true;
            this.comboBox1Prestamo.Items.AddRange(new object[] {
            "Cuentas",
            "rRegistro de prestamos"});
            this.comboBox1Prestamo.Location = new System.Drawing.Point(113, 129);
            this.comboBox1Prestamo.Name = "comboBox1Prestamo";
            this.comboBox1Prestamo.Size = new System.Drawing.Size(281, 21);
            this.comboBox1Prestamo.TabIndex = 5;
            this.comboBox1Prestamo.SelectedIndexChanged += new System.EventHandler(this.comboBox1Prestamo_SelectedIndexChanged);
            // 
            // textBox2MontoCB
            // 
            this.textBox2MontoCB.Location = new System.Drawing.Point(113, 216);
            this.textBox2MontoCB.Name = "textBox2MontoCB";
            this.textBox2MontoCB.Size = new System.Drawing.Size(100, 20);
            this.textBox2MontoCB.TabIndex = 6;
            // 
            // LimpiarButtomRegistro
            // 
            this.LimpiarButtomRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LimpiarButtomRegistro.Image = ((System.Drawing.Image)(resources.GetObject("LimpiarButtomRegistro.Image")));
            this.LimpiarButtomRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LimpiarButtomRegistro.Location = new System.Drawing.Point(45, 272);
            this.LimpiarButtomRegistro.Name = "LimpiarButtomRegistro";
            this.LimpiarButtomRegistro.Size = new System.Drawing.Size(100, 33);
            this.LimpiarButtomRegistro.TabIndex = 47;
            this.LimpiarButtomRegistro.Text = "Limpiar";
            this.LimpiarButtomRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LimpiarButtomRegistro.UseVisualStyleBackColor = true;
            // 
            // BorrarButtomRegistro
            // 
            this.BorrarButtomRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BorrarButtomRegistro.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BorrarButtomRegistro.Image = ((System.Drawing.Image)(resources.GetObject("BorrarButtomRegistro.Image")));
            this.BorrarButtomRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BorrarButtomRegistro.Location = new System.Drawing.Point(264, 272);
            this.BorrarButtomRegistro.Name = "BorrarButtomRegistro";
            this.BorrarButtomRegistro.Size = new System.Drawing.Size(95, 33);
            this.BorrarButtomRegistro.TabIndex = 46;
            this.BorrarButtomRegistro.Text = "Borrar";
            this.BorrarButtomRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BorrarButtomRegistro.UseVisualStyleBackColor = true;
            this.BorrarButtomRegistro.Click += new System.EventHandler(this.BorrarButtomRegistro_Click);
            // 
            // GuardarButtomRegistro
            // 
            this.GuardarButtomRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GuardarButtomRegistro.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.GuardarButtomRegistro.Image = ((System.Drawing.Image)(resources.GetObject("GuardarButtomRegistro.Image")));
            this.GuardarButtomRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButtomRegistro.Location = new System.Drawing.Point(159, 272);
            this.GuardarButtomRegistro.Name = "GuardarButtomRegistro";
            this.GuardarButtomRegistro.Size = new System.Drawing.Size(88, 33);
            this.GuardarButtomRegistro.TabIndex = 45;
            this.GuardarButtomRegistro.Text = "Guardar";
            this.GuardarButtomRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarButtomRegistro.UseVisualStyleBackColor = true;
            this.GuardarButtomRegistro.Click += new System.EventHandler(this.GuardarButtomRegistro_Click);
            // 
            // textBox3Balance
            // 
            this.textBox3Balance.Location = new System.Drawing.Point(213, 173);
            this.textBox3Balance.Name = "textBox3Balance";
            this.textBox3Balance.Size = new System.Drawing.Size(100, 20);
            this.textBox3Balance.TabIndex = 48;
            // 
            // BuscarButtomRegistro
            // 
            this.BuscarButtomRegistro.Image = ((System.Drawing.Image)(resources.GetObject("BuscarButtomRegistro.Image")));
            this.BuscarButtomRegistro.Location = new System.Drawing.Point(213, 62);
            this.BuscarButtomRegistro.Name = "BuscarButtomRegistro";
            this.BuscarButtomRegistro.Size = new System.Drawing.Size(50, 20);
            this.BuscarButtomRegistro.TabIndex = 49;
            this.BuscarButtomRegistro.UseVisualStyleBackColor = true;
            // 
            // rRegistro_de_Cobros_de_Prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 339);
            this.Controls.Add(this.BuscarButtomRegistro);
            this.Controls.Add(this.textBox3Balance);
            this.Controls.Add(this.LimpiarButtomRegistro);
            this.Controls.Add(this.BorrarButtomRegistro);
            this.Controls.Add(this.GuardarButtomRegistro);
            this.Controls.Add(this.textBox2MontoCB);
            this.Controls.Add(this.comboBox1Prestamo);
            this.Controls.Add(this.textBox1Cobros);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "rRegistro_de_Cobros_de_Prestamos";
            this.Text = "rRegistro_de_Cobros_de_Prestamos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1Cobros;
        private System.Windows.Forms.ComboBox comboBox1Prestamo;
        private System.Windows.Forms.TextBox textBox2MontoCB;
        private System.Windows.Forms.Button LimpiarButtomRegistro;
        private System.Windows.Forms.Button BorrarButtomRegistro;
        private System.Windows.Forms.Button GuardarButtomRegistro;
        private System.Windows.Forms.TextBox textBox3Balance;
        private System.Windows.Forms.Button BuscarButtomRegistro;
    }
}
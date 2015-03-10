namespace FinanzasPersonales.Registros
{
    partial class Cobro_de_Prestamos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cobro_de_Prestamos));
            this.LimpiarButtom = new System.Windows.Forms.Button();
            this.BorrarButtom = new System.Windows.Forms.Button();
            this.GuardarButtom = new System.Windows.Forms.Button();
            this.BuscarButtom = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.IdCobrotextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BalancetextBox = new System.Windows.Forms.TextBox();
            this.MontotextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PrestamoComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LimpiarButtom
            // 
            this.LimpiarButtom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LimpiarButtom.Image = ((System.Drawing.Image)(resources.GetObject("LimpiarButtom.Image")));
            this.LimpiarButtom.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LimpiarButtom.Location = new System.Drawing.Point(86, 166);
            this.LimpiarButtom.Name = "LimpiarButtom";
            this.LimpiarButtom.Size = new System.Drawing.Size(75, 33);
            this.LimpiarButtom.TabIndex = 33;
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
            this.BorrarButtom.Location = new System.Drawing.Point(248, 166);
            this.BorrarButtom.Name = "BorrarButtom";
            this.BorrarButtom.Size = new System.Drawing.Size(75, 33);
            this.BorrarButtom.TabIndex = 32;
            this.BorrarButtom.Text = "Borrar";
            this.BorrarButtom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BorrarButtom.UseVisualStyleBackColor = true;
            this.BorrarButtom.Click += new System.EventHandler(this.BorrarButtom_Click);
            // 
            // GuardarButtom
            // 
            this.GuardarButtom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GuardarButtom.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.GuardarButtom.Image = ((System.Drawing.Image)(resources.GetObject("GuardarButtom.Image")));
            this.GuardarButtom.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButtom.Location = new System.Drawing.Point(167, 166);
            this.GuardarButtom.Name = "GuardarButtom";
            this.GuardarButtom.Size = new System.Drawing.Size(75, 33);
            this.GuardarButtom.TabIndex = 31;
            this.GuardarButtom.Text = "Guardar";
            this.GuardarButtom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarButtom.UseVisualStyleBackColor = true;
            this.GuardarButtom.Click += new System.EventHandler(this.GuardarButtom_Click);
            // 
            // BuscarButtom
            // 
            this.BuscarButtom.Image = ((System.Drawing.Image)(resources.GetObject("BuscarButtom.Image")));
            this.BuscarButtom.Location = new System.Drawing.Point(179, 9);
            this.BuscarButtom.Name = "BuscarButtom";
            this.BuscarButtom.Size = new System.Drawing.Size(34, 24);
            this.BuscarButtom.TabIndex = 36;
            this.BuscarButtom.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Id";
            // 
            // IdCobrotextBox
            // 
            this.IdCobrotextBox.Location = new System.Drawing.Point(86, 12);
            this.IdCobrotextBox.Name = "IdCobrotextBox";
            this.IdCobrotextBox.Size = new System.Drawing.Size(69, 20);
            this.IdCobrotextBox.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Prestamo";
            // 
            // BalancetextBox
            // 
            this.BalancetextBox.Location = new System.Drawing.Point(230, 82);
            this.BalancetextBox.Name = "BalancetextBox";
            this.BalancetextBox.ReadOnly = true;
            this.BalancetextBox.Size = new System.Drawing.Size(69, 20);
            this.BalancetextBox.TabIndex = 45;
            // 
            // MontotextBox
            // 
            this.MontotextBox.Location = new System.Drawing.Point(86, 119);
            this.MontotextBox.Name = "MontotextBox";
            this.MontotextBox.Size = new System.Drawing.Size(81, 20);
            this.MontotextBox.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Balance Pendiente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Monto";
            // 
            // PrestamoComboBox
            // 
            this.PrestamoComboBox.FormattingEnabled = true;
            this.PrestamoComboBox.Location = new System.Drawing.Point(86, 44);
            this.PrestamoComboBox.Name = "PrestamoComboBox";
            this.PrestamoComboBox.Size = new System.Drawing.Size(284, 21);
            this.PrestamoComboBox.TabIndex = 46;
            // 
            // Cobro_de_Prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 211);
            this.Controls.Add(this.PrestamoComboBox);
            this.Controls.Add(this.BalancetextBox);
            this.Controls.Add(this.MontotextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BuscarButtom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IdCobrotextBox);
            this.Controls.Add(this.LimpiarButtom);
            this.Controls.Add(this.BorrarButtom);
            this.Controls.Add(this.GuardarButtom);
            this.Name = "Cobro_de_Prestamos";
            this.Text = "Cobro_de_Prestamos";
            this.Load += new System.EventHandler(this.Cobro_de_Prestamos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LimpiarButtom;
        private System.Windows.Forms.Button BorrarButtom;
        private System.Windows.Forms.Button GuardarButtom;
        private System.Windows.Forms.Button BuscarButtom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IdCobrotextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BalancetextBox;
        private System.Windows.Forms.TextBox MontotextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox PrestamoComboBox;
    }
}
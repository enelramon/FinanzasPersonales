namespace FinanzasPersonales.Registros
{
    partial class rPrestamos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rPrestamos));
            this.LimpiarButtom = new System.Windows.Forms.Button();
            this.BorrarButtom = new System.Windows.Forms.Button();
            this.GuardarButtom = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.ConceptoTextBox = new System.Windows.Forms.TextBox();
            this.MontoTextBox = new System.Windows.Forms.TextBox();
            this.BalanceTextBox = new System.Windows.Forms.TextBox();
            this.BuscarButtom = new System.Windows.Forms.Button();
            this.BuscarPorcomboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LimpiarButtom
            // 
            this.LimpiarButtom.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LimpiarButtom.Image = ((System.Drawing.Image)(resources.GetObject("LimpiarButtom.Image")));
            this.LimpiarButtom.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LimpiarButtom.Location = new System.Drawing.Point(79, 168);
            this.LimpiarButtom.Name = "LimpiarButtom";
            this.LimpiarButtom.Size = new System.Drawing.Size(75, 33);
            this.LimpiarButtom.TabIndex = 61;
            this.LimpiarButtom.Text = "Limpiar";
            this.LimpiarButtom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LimpiarButtom.UseVisualStyleBackColor = true;
            this.LimpiarButtom.Click += new System.EventHandler(this.LimpiarButtom_Click);
            // 
            // BorrarButtom
            // 
            this.BorrarButtom.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BorrarButtom.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BorrarButtom.Image = ((System.Drawing.Image)(resources.GetObject("BorrarButtom.Image")));
            this.BorrarButtom.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BorrarButtom.Location = new System.Drawing.Point(241, 168);
            this.BorrarButtom.Name = "BorrarButtom";
            this.BorrarButtom.Size = new System.Drawing.Size(75, 33);
            this.BorrarButtom.TabIndex = 60;
            this.BorrarButtom.Text = "Borrar";
            this.BorrarButtom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BorrarButtom.UseVisualStyleBackColor = true;
            this.BorrarButtom.Click += new System.EventHandler(this.BorrarButtom_Click);
            // 
            // GuardarButtom
            // 
            this.GuardarButtom.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.GuardarButtom.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.GuardarButtom.Image = ((System.Drawing.Image)(resources.GetObject("GuardarButtom.Image")));
            this.GuardarButtom.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButtom.Location = new System.Drawing.Point(160, 168);
            this.GuardarButtom.Name = "GuardarButtom";
            this.GuardarButtom.Size = new System.Drawing.Size(75, 33);
            this.GuardarButtom.TabIndex = 59;
            this.GuardarButtom.Text = "Guardar";
            this.GuardarButtom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarButtom.UseVisualStyleBackColor = true;
            this.GuardarButtom.Click += new System.EventHandler(this.GuardarButtom_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 64;
            this.label3.Text = "Concepto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 65;
            this.label4.Text = "Monto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(164, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 66;
            this.label5.Text = "Balance Pendiente:";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(80, 22);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(100, 20);
            this.IdTextBox.TabIndex = 67;
            // 
            // ConceptoTextBox
            // 
            this.ConceptoTextBox.Location = new System.Drawing.Point(80, 96);
            this.ConceptoTextBox.Name = "ConceptoTextBox";
            this.ConceptoTextBox.Size = new System.Drawing.Size(290, 20);
            this.ConceptoTextBox.TabIndex = 69;
            // 
            // MontoTextBox
            // 
            this.MontoTextBox.Location = new System.Drawing.Point(80, 131);
            this.MontoTextBox.Name = "MontoTextBox";
            this.MontoTextBox.Size = new System.Drawing.Size(68, 20);
            this.MontoTextBox.TabIndex = 70;
            // 
            // BalanceTextBox
            // 
            this.BalanceTextBox.Location = new System.Drawing.Point(270, 131);
            this.BalanceTextBox.Name = "BalanceTextBox";
            this.BalanceTextBox.Size = new System.Drawing.Size(100, 20);
            this.BalanceTextBox.TabIndex = 71;
            // 
            // BuscarButtom
            // 
            this.BuscarButtom.Image = ((System.Drawing.Image)(resources.GetObject("BuscarButtom.Image")));
            this.BuscarButtom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButtom.Location = new System.Drawing.Point(197, 18);
            this.BuscarButtom.Name = "BuscarButtom";
            this.BuscarButtom.Size = new System.Drawing.Size(32, 24);
            this.BuscarButtom.TabIndex = 72;
            this.BuscarButtom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarButtom.UseVisualStyleBackColor = true;
            // 
            // BuscarPorcomboBox
            // 
            this.BuscarPorcomboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BuscarPorcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BuscarPorcomboBox.FormattingEnabled = true;
            this.BuscarPorcomboBox.Location = new System.Drawing.Point(80, 58);
            this.BuscarPorcomboBox.Name = "BuscarPorcomboBox";
            this.BuscarPorcomboBox.Size = new System.Drawing.Size(290, 21);
            this.BuscarPorcomboBox.TabIndex = 74;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 73;
            this.label6.Text = "Cuenta";
            // 
            // rPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 213);
            this.Controls.Add(this.BuscarPorcomboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BuscarButtom);
            this.Controls.Add(this.BalanceTextBox);
            this.Controls.Add(this.MontoTextBox);
            this.Controls.Add(this.ConceptoTextBox);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LimpiarButtom);
            this.Controls.Add(this.BorrarButtom);
            this.Controls.Add(this.GuardarButtom);
            this.Name = "rPrestamos";
            this.Text = "Registro de Prestamos";
            this.Load += new System.EventHandler(this.rPrestamos_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LimpiarButtom;
        private System.Windows.Forms.Button BorrarButtom;
        private System.Windows.Forms.Button GuardarButtom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.TextBox ConceptoTextBox;
        private System.Windows.Forms.TextBox MontoTextBox;
        private System.Windows.Forms.TextBox BalanceTextBox;
        private System.Windows.Forms.Button BuscarButtom;
        private System.Windows.Forms.ComboBox BuscarPorcomboBox;
        private System.Windows.Forms.Label label6;
    }
}
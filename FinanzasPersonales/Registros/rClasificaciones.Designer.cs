namespace FinanzasPersonales.Registros
{
    partial class rClasificaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rClasificaciones));
            this.Active = new System.Windows.Forms.CheckBox();
            this.LimpiarButtom = new System.Windows.Forms.Button();
            this.BottarButtom = new System.Windows.Forms.Button();
            this.AceptarButtom = new System.Windows.Forms.Button();
            this.BuscarButtom = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Active
            // 
            this.Active.AutoSize = true;
            this.Active.BackColor = System.Drawing.Color.Transparent;
            this.Active.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Active.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Active.Location = new System.Drawing.Point(126, 96);
            this.Active.Name = "Active";
            this.Active.Size = new System.Drawing.Size(68, 20);
            this.Active.TabIndex = 18;
            this.Active.Text = "Active";
            this.Active.UseVisualStyleBackColor = false;
            // 
            // LimpiarButtom
            // 
            this.LimpiarButtom.Image = ((System.Drawing.Image)(resources.GetObject("LimpiarButtom.Image")));
            this.LimpiarButtom.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LimpiarButtom.Location = new System.Drawing.Point(36, 136);
            this.LimpiarButtom.Name = "LimpiarButtom";
            this.LimpiarButtom.Size = new System.Drawing.Size(75, 33);
            this.LimpiarButtom.TabIndex = 17;
            this.LimpiarButtom.Text = "Limpiar";
            this.LimpiarButtom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LimpiarButtom.UseVisualStyleBackColor = true;
            // 
            // BottarButtom
            // 
            this.BottarButtom.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BottarButtom.Image = ((System.Drawing.Image)(resources.GetObject("BottarButtom.Image")));
            this.BottarButtom.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BottarButtom.Location = new System.Drawing.Point(198, 136);
            this.BottarButtom.Name = "BottarButtom";
            this.BottarButtom.Size = new System.Drawing.Size(75, 33);
            this.BottarButtom.TabIndex = 16;
            this.BottarButtom.Text = "Borrar";
            this.BottarButtom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BottarButtom.UseVisualStyleBackColor = true;
            this.BottarButtom.Click += new System.EventHandler(this.BottarButtom_Click);
            // 
            // AceptarButtom
            // 
            this.AceptarButtom.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.AceptarButtom.Image = ((System.Drawing.Image)(resources.GetObject("AceptarButtom.Image")));
            this.AceptarButtom.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AceptarButtom.Location = new System.Drawing.Point(117, 136);
            this.AceptarButtom.Name = "AceptarButtom";
            this.AceptarButtom.Size = new System.Drawing.Size(75, 33);
            this.AceptarButtom.TabIndex = 15;
            this.AceptarButtom.Text = "Guardar";
            this.AceptarButtom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AceptarButtom.UseVisualStyleBackColor = true;
            // 
            // BuscarButtom
            // 
            this.BuscarButtom.Image = ((System.Drawing.Image)(resources.GetObject("BuscarButtom.Image")));
            this.BuscarButtom.Location = new System.Drawing.Point(239, 41);
            this.BuscarButtom.Name = "BuscarButtom";
            this.BuscarButtom.Size = new System.Drawing.Size(34, 24);
            this.BuscarButtom.TabIndex = 14;
            this.BuscarButtom.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID:";
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(126, 70);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(173, 20);
            this.NombreTextBox.TabIndex = 11;
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(126, 44);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(98, 20);
            this.IDTextBox.TabIndex = 10;
            // 
            // rClasificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 186);
            this.Controls.Add(this.Active);
            this.Controls.Add(this.LimpiarButtom);
            this.Controls.Add(this.BottarButtom);
            this.Controls.Add(this.AceptarButtom);
            this.Controls.Add(this.BuscarButtom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.IDTextBox);
            this.Name = "rClasificaciones";
            this.Text = "Registro de Clasificaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Active;
        private System.Windows.Forms.Button LimpiarButtom;
        private System.Windows.Forms.Button BottarButtom;
        private System.Windows.Forms.Button AceptarButtom;
        private System.Windows.Forms.Button BuscarButtom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.TextBox IDTextBox;
    }
}
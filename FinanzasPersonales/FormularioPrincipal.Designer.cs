﻿namespace FinanzasPersonales
{
    partial class FormularioPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioPrincipal));
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BuscarButtom = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.AceptarButtom = new System.Windows.Forms.Button();
            this.BottarButtom = new System.Windows.Forms.Button();
            this.LimpiarButtom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(134, 12);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.IDTextBox.TabIndex = 0;
            this.IDTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(134, 38);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(173, 20);
            this.NombreTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            // 
            // BuscarButtom
            // 
            this.BuscarButtom.Image = ((System.Drawing.Image)(resources.GetObject("BuscarButtom.Image")));
            this.BuscarButtom.Location = new System.Drawing.Point(263, 8);
            this.BuscarButtom.Name = "BuscarButtom";
            this.BuscarButtom.Size = new System.Drawing.Size(27, 26);
            this.BuscarButtom.TabIndex = 4;
            this.BuscarButtom.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 93);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(55, 17);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Activa";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // AceptarButtom
            // 
            this.AceptarButtom.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.AceptarButtom.Image = ((System.Drawing.Image)(resources.GetObject("AceptarButtom.Image")));
            this.AceptarButtom.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AceptarButtom.Location = new System.Drawing.Point(232, 64);
            this.AceptarButtom.Name = "AceptarButtom";
            this.AceptarButtom.Size = new System.Drawing.Size(75, 23);
            this.AceptarButtom.TabIndex = 6;
            this.AceptarButtom.Text = "Aceptar";
            this.AceptarButtom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AceptarButtom.UseVisualStyleBackColor = true;
            this.AceptarButtom.Click += new System.EventHandler(this.button2_Click);
            // 
            // BottarButtom
            // 
            this.BottarButtom.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BottarButtom.Image = ((System.Drawing.Image)(resources.GetObject("BottarButtom.Image")));
            this.BottarButtom.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BottarButtom.Location = new System.Drawing.Point(232, 122);
            this.BottarButtom.Name = "BottarButtom";
            this.BottarButtom.Size = new System.Drawing.Size(75, 23);
            this.BottarButtom.TabIndex = 7;
            this.BottarButtom.Text = "Borrar";
            this.BottarButtom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BottarButtom.UseVisualStyleBackColor = true;
            // 
            // LimpiarButtom
            // 
            this.LimpiarButtom.Image = ((System.Drawing.Image)(resources.GetObject("LimpiarButtom.Image")));
            this.LimpiarButtom.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LimpiarButtom.Location = new System.Drawing.Point(232, 93);
            this.LimpiarButtom.Name = "LimpiarButtom";
            this.LimpiarButtom.Size = new System.Drawing.Size(75, 23);
            this.LimpiarButtom.TabIndex = 8;
            this.LimpiarButtom.Text = "Limpiar";
            this.LimpiarButtom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LimpiarButtom.UseVisualStyleBackColor = true;
            // 
            // FormularioPrincipal
            // 
            this.AcceptButton = this.AceptarButtom;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(319, 155);
            this.Controls.Add(this.LimpiarButtom);
            this.Controls.Add(this.BottarButtom);
            this.Controls.Add(this.AceptarButtom);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.BuscarButtom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.IDTextBox);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormularioPrincipal";
            this.Text = "Registro de Clasificaciones";
            this.Load += new System.EventHandler(this.FormularioPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BuscarButtom;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button AceptarButtom;
        private System.Windows.Forms.Button BottarButtom;
        private System.Windows.Forms.Button LimpiarButtom;
    }
}

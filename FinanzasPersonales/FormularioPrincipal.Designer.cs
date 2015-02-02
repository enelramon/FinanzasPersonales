namespace FinanzasPersonales
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
            this.AceptarButtom = new System.Windows.Forms.Button();
            this.BottarButtom = new System.Windows.Forms.Button();
            this.LimpiarButtom = new System.Windows.Forms.Button();
            this.Active = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // IDTextBox
            // 
            resources.ApplyResources(this.IDTextBox, "IDTextBox");
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // NombreTextBox
            // 
            resources.ApplyResources(this.NombreTextBox, "NombreTextBox");
            this.NombreTextBox.Name = "NombreTextBox";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // BuscarButtom
            // 
            resources.ApplyResources(this.BuscarButtom, "BuscarButtom");
            this.BuscarButtom.Name = "BuscarButtom";
            this.BuscarButtom.UseVisualStyleBackColor = true;
            // 
            // AceptarButtom
            // 
            resources.ApplyResources(this.AceptarButtom, "AceptarButtom");
            this.AceptarButtom.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.AceptarButtom.Name = "AceptarButtom";
            this.AceptarButtom.UseVisualStyleBackColor = true;
            this.AceptarButtom.Click += new System.EventHandler(this.button2_Click);
            // 
            // BottarButtom
            // 
            resources.ApplyResources(this.BottarButtom, "BottarButtom");
            this.BottarButtom.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BottarButtom.Name = "BottarButtom";
            this.BottarButtom.UseVisualStyleBackColor = true;
            // 
            // LimpiarButtom
            // 
            resources.ApplyResources(this.LimpiarButtom, "LimpiarButtom");
            this.LimpiarButtom.Name = "LimpiarButtom";
            this.LimpiarButtom.UseVisualStyleBackColor = true;
            // 
            // Active
            // 
            resources.ApplyResources(this.Active, "Active");
            this.Active.BackColor = System.Drawing.Color.Transparent;
            this.Active.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Active.Name = "Active";
            this.Active.UseVisualStyleBackColor = false;
            // 
            // FormularioPrincipal
            // 
            this.AcceptButton = this.AceptarButtom;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.Active);
            this.Controls.Add(this.LimpiarButtom);
            this.Controls.Add(this.BottarButtom);
            this.Controls.Add(this.AceptarButtom);
            this.Controls.Add(this.BuscarButtom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.IDTextBox);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormularioPrincipal";
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
        private System.Windows.Forms.Button AceptarButtom;
        private System.Windows.Forms.Button BottarButtom;
        private System.Windows.Forms.Button LimpiarButtom;
        private System.Windows.Forms.CheckBox Active;
    }
}


namespace FinanzasPersonales.Registros
{
    partial class rCobro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rCobro));
            this.BalancePTextBox3 = new System.Windows.Forms.TextBox();
            this.MontoTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PrestamoComboBox = new System.Windows.Forms.ComboBox();
            this.LimpiarButtom = new System.Windows.Forms.Button();
            this.BorrarButtom = new System.Windows.Forms.Button();
            this.GuardarButtom = new System.Windows.Forms.Button();
            this.BuscarButtom = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IdCobroTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.finanzasPersonalesDBDataSet = new FinanzasPersonales.FinanzasPersonalesDBDataSet();
            this.prestamosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prestamosTableAdapter = new FinanzasPersonales.FinanzasPersonalesDBDataSetTableAdapters.PrestamosTableAdapter();
            this.finanzasPersonalesDBDataSet1 = new FinanzasPersonales.FinanzasPersonalesDBDataSet1();
            this.prestamosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.prestamosTableAdapter1 = new FinanzasPersonales.FinanzasPersonalesDBDataSet1TableAdapters.PrestamosTableAdapter();
            this.finanzasPersonalesDBDataSet2 = new FinanzasPersonales.FinanzasPersonalesDBDataSet2();
            this.prestamosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.prestamosTableAdapter2 = new FinanzasPersonales.FinanzasPersonalesDBDataSet2TableAdapters.PrestamosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finanzasPersonalesDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finanzasPersonalesDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finanzasPersonalesDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // BalancePTextBox3
            // 
            this.BalancePTextBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BalancePTextBox3.Location = new System.Drawing.Point(191, 84);
            this.BalancePTextBox3.Name = "BalancePTextBox3";
            this.BalancePTextBox3.ReadOnly = true;
            this.BalancePTextBox3.Size = new System.Drawing.Size(100, 20);
            this.BalancePTextBox3.TabIndex = 59;
            // 
            // MontoTextBox
            // 
            this.MontoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MontoTextBox.Location = new System.Drawing.Point(74, 175);
            this.MontoTextBox.Name = "MontoTextBox";
            this.MontoTextBox.Size = new System.Drawing.Size(99, 20);
            this.MontoTextBox.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "Balance Pendiente:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "Monto";
            // 
            // PrestamoComboBox
            // 
            this.PrestamoComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrestamoComboBox.DataSource = this.prestamosBindingSource2;
            this.PrestamoComboBox.DisplayMember = "Concepto";
            this.PrestamoComboBox.FormattingEnabled = true;
            this.PrestamoComboBox.Location = new System.Drawing.Point(96, 57);
            this.PrestamoComboBox.Name = "PrestamoComboBox";
            this.PrestamoComboBox.Size = new System.Drawing.Size(310, 21);
            this.PrestamoComboBox.TabIndex = 54;
            this.PrestamoComboBox.ValueMember = "Balance";
            // 
            // LimpiarButtom
            // 
            this.LimpiarButtom.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LimpiarButtom.Image = ((System.Drawing.Image)(resources.GetObject("LimpiarButtom.Image")));
            this.LimpiarButtom.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LimpiarButtom.Location = new System.Drawing.Point(110, 210);
            this.LimpiarButtom.Name = "LimpiarButtom";
            this.LimpiarButtom.Size = new System.Drawing.Size(75, 33);
            this.LimpiarButtom.TabIndex = 52;
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
            this.BorrarButtom.Location = new System.Drawing.Point(272, 210);
            this.BorrarButtom.Name = "BorrarButtom";
            this.BorrarButtom.Size = new System.Drawing.Size(75, 33);
            this.BorrarButtom.TabIndex = 51;
            this.BorrarButtom.Text = "Borrar";
            this.BorrarButtom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BorrarButtom.UseVisualStyleBackColor = true;
            // 
            // GuardarButtom
            // 
            this.GuardarButtom.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.GuardarButtom.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.GuardarButtom.Image = ((System.Drawing.Image)(resources.GetObject("GuardarButtom.Image")));
            this.GuardarButtom.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButtom.Location = new System.Drawing.Point(191, 210);
            this.GuardarButtom.Name = "GuardarButtom";
            this.GuardarButtom.Size = new System.Drawing.Size(75, 33);
            this.GuardarButtom.TabIndex = 50;
            this.GuardarButtom.Text = "Guardar";
            this.GuardarButtom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarButtom.UseVisualStyleBackColor = true;
            this.GuardarButtom.Click += new System.EventHandler(this.GuardarButtom_Click);
            // 
            // BuscarButtom
            // 
            this.BuscarButtom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BuscarButtom.Image = ((System.Drawing.Image)(resources.GetObject("BuscarButtom.Image")));
            this.BuscarButtom.Location = new System.Drawing.Point(191, 19);
            this.BuscarButtom.Name = "BuscarButtom";
            this.BuscarButtom.Size = new System.Drawing.Size(34, 24);
            this.BuscarButtom.TabIndex = 49;
            this.BuscarButtom.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Prestamo:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "ID";
            // 
            // IdCobroTextBox
            // 
            this.IdCobroTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IdCobroTextBox.Location = new System.Drawing.Point(96, 22);
            this.IdCobroTextBox.Name = "IdCobroTextBox";
            this.IdCobroTextBox.Size = new System.Drawing.Size(77, 20);
            this.IdCobroTextBox.TabIndex = 46;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // finanzasPersonalesDBDataSet
            // 
            this.finanzasPersonalesDBDataSet.DataSetName = "FinanzasPersonalesDBDataSet";
            this.finanzasPersonalesDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prestamosBindingSource
            // 
            this.prestamosBindingSource.DataMember = "Prestamos";
            this.prestamosBindingSource.DataSource = this.finanzasPersonalesDBDataSet;
            // 
            // prestamosTableAdapter
            // 
            this.prestamosTableAdapter.ClearBeforeFill = true;
            // 
            // finanzasPersonalesDBDataSet1
            // 
            this.finanzasPersonalesDBDataSet1.DataSetName = "FinanzasPersonalesDBDataSet1";
            this.finanzasPersonalesDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prestamosBindingSource1
            // 
            this.prestamosBindingSource1.DataMember = "Prestamos";
            this.prestamosBindingSource1.DataSource = this.finanzasPersonalesDBDataSet1;
            // 
            // prestamosTableAdapter1
            // 
            this.prestamosTableAdapter1.ClearBeforeFill = true;
            // 
            // finanzasPersonalesDBDataSet2
            // 
            this.finanzasPersonalesDBDataSet2.DataSetName = "FinanzasPersonalesDBDataSet2";
            this.finanzasPersonalesDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prestamosBindingSource2
            // 
            this.prestamosBindingSource2.DataMember = "Prestamos";
            this.prestamosBindingSource2.DataSource = this.finanzasPersonalesDBDataSet2;
            // 
            // prestamosTableAdapter2
            // 
            this.prestamosTableAdapter2.ClearBeforeFill = true;
            // 
            // rCobro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 262);
            this.Controls.Add(this.BalancePTextBox3);
            this.Controls.Add(this.MontoTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PrestamoComboBox);
            this.Controls.Add(this.LimpiarButtom);
            this.Controls.Add(this.BorrarButtom);
            this.Controls.Add(this.GuardarButtom);
            this.Controls.Add(this.BuscarButtom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IdCobroTextBox);
            this.Name = "rCobro";
            this.Text = "Registro de Cobros de Prestamos";
            this.Load += new System.EventHandler(this.rCobro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finanzasPersonalesDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finanzasPersonalesDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finanzasPersonalesDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BalancePTextBox3;
        private System.Windows.Forms.TextBox MontoTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox PrestamoComboBox;
        private System.Windows.Forms.Button LimpiarButtom;
        private System.Windows.Forms.Button BorrarButtom;
        private System.Windows.Forms.Button GuardarButtom;
        private System.Windows.Forms.Button BuscarButtom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IdCobroTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private FinanzasPersonalesDBDataSet finanzasPersonalesDBDataSet;
        private System.Windows.Forms.BindingSource prestamosBindingSource;
        private FinanzasPersonalesDBDataSetTableAdapters.PrestamosTableAdapter prestamosTableAdapter;
        private FinanzasPersonalesDBDataSet1 finanzasPersonalesDBDataSet1;
        private System.Windows.Forms.BindingSource prestamosBindingSource1;
        private FinanzasPersonalesDBDataSet1TableAdapters.PrestamosTableAdapter prestamosTableAdapter1;
        private FinanzasPersonalesDBDataSet2 finanzasPersonalesDBDataSet2;
        private System.Windows.Forms.BindingSource prestamosBindingSource2;
        private FinanzasPersonalesDBDataSet2TableAdapters.PrestamosTableAdapter prestamosTableAdapter2;
    }
}
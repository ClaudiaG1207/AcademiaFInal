namespace ProyecAcademiaEuropea
{
    partial class DetalleInscripcion
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
            this.dgvdetalle = new System.Windows.Forms.DataGridView();
            this.space1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pagar = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblestudiante = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtid = new System.Windows.Forms.TextBox();
            this.semestre2 = new System.Windows.Forms.GroupBox();
            this.btnGuardarNota2 = new System.Windows.Forms.Button();
            this.txtnota2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.semestre1 = new System.Windows.Forms.GroupBox();
            this.btnGuardarNota1 = new System.Windows.Forms.Button();
            this.txtnota1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetalle)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.semestre2.SuspendLayout();
            this.semestre1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvdetalle
            // 
            this.dgvdetalle.AllowUserToAddRows = false;
            this.dgvdetalle.AllowUserToDeleteRows = false;
            this.dgvdetalle.AllowUserToResizeRows = false;
            this.dgvdetalle.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvdetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.space1,
            this.Pagar});
            this.dgvdetalle.Location = new System.Drawing.Point(13, 71);
            this.dgvdetalle.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.dgvdetalle.Name = "dgvdetalle";
            this.dgvdetalle.ReadOnly = true;
            this.dgvdetalle.RowHeadersWidth = 82;
            this.dgvdetalle.RowTemplate.Height = 33;
            this.dgvdetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdetalle.ShowCellToolTips = false;
            this.dgvdetalle.ShowEditingIcon = false;
            this.dgvdetalle.Size = new System.Drawing.Size(888, 397);
            this.dgvdetalle.TabIndex = 62;
            this.dgvdetalle.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdetalle_CellClick);
            // 
            // space1
            // 
            this.space1.HeaderText = "";
            this.space1.MinimumWidth = 10;
            this.space1.Name = "space1";
            this.space1.ReadOnly = true;
            this.space1.Width = 200;
            // 
            // Pagar
            // 
            this.Pagar.HeaderText = "";
            this.Pagar.Image = global::ProyecAcademiaEuropea.Properties.Resources.calificaciones_de_los_estudiantes;
            this.Pagar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Pagar.MinimumWidth = 10;
            this.Pagar.Name = "Pagar";
            this.Pagar.ReadOnly = true;
            this.Pagar.Width = 200;
            // 
            // lblestudiante
            // 
            this.lblestudiante.AutoSize = true;
            this.lblestudiante.Location = new System.Drawing.Point(51, 10);
            this.lblestudiante.Name = "lblestudiante";
            this.lblestudiante.Size = new System.Drawing.Size(44, 16);
            this.lblestudiante.TabIndex = 63;
            this.lblestudiante.Text = "label1";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::ProyecAcademiaEuropea.Properties.Resources.dolar;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 10;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 200;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(925, 512);
            this.tabControl1.TabIndex = 64;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvdetalle);
            this.tabPage1.Controls.Add(this.lblestudiante);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(917, 483);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtid);
            this.tabPage2.Controls.Add(this.semestre2);
            this.tabPage2.Controls.Add(this.semestre1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(917, 483);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(344, 319);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 22);
            this.txtid.TabIndex = 5;
            // 
            // semestre2
            // 
            this.semestre2.Controls.Add(this.btnGuardarNota2);
            this.semestre2.Controls.Add(this.txtnota2);
            this.semestre2.Controls.Add(this.label2);
            this.semestre2.Location = new System.Drawing.Point(421, 30);
            this.semestre2.Name = "semestre2";
            this.semestre2.Size = new System.Drawing.Size(350, 283);
            this.semestre2.TabIndex = 4;
            this.semestre2.TabStop = false;
            this.semestre2.Text = "Segundo Semestre";
            // 
            // btnGuardarNota2
            // 
            this.btnGuardarNota2.Location = new System.Drawing.Point(255, 219);
            this.btnGuardarNota2.Name = "btnGuardarNota2";
            this.btnGuardarNota2.Size = new System.Drawing.Size(75, 45);
            this.btnGuardarNota2.TabIndex = 1;
            this.btnGuardarNota2.Text = "Guardar";
            this.btnGuardarNota2.UseVisualStyleBackColor = true;
            // 
            // txtnota2
            // 
            this.txtnota2.Location = new System.Drawing.Point(98, 51);
            this.txtnota2.Name = "txtnota2";
            this.txtnota2.Size = new System.Drawing.Size(100, 22);
            this.txtnota2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nota:";
            // 
            // semestre1
            // 
            this.semestre1.Controls.Add(this.btnGuardarNota1);
            this.semestre1.Controls.Add(this.txtnota1);
            this.semestre1.Controls.Add(this.label1);
            this.semestre1.Location = new System.Drawing.Point(15, 30);
            this.semestre1.Name = "semestre1";
            this.semestre1.Size = new System.Drawing.Size(350, 283);
            this.semestre1.TabIndex = 3;
            this.semestre1.TabStop = false;
            this.semestre1.Text = "Primer Semestre";
            // 
            // btnGuardarNota1
            // 
            this.btnGuardarNota1.Location = new System.Drawing.Point(255, 219);
            this.btnGuardarNota1.Name = "btnGuardarNota1";
            this.btnGuardarNota1.Size = new System.Drawing.Size(75, 45);
            this.btnGuardarNota1.TabIndex = 1;
            this.btnGuardarNota1.Text = "Guardar";
            this.btnGuardarNota1.UseVisualStyleBackColor = true;
            // 
            // txtnota1
            // 
            this.txtnota1.Location = new System.Drawing.Point(98, 51);
            this.txtnota1.Name = "txtnota1";
            this.txtnota1.Size = new System.Drawing.Size(100, 22);
            this.txtnota1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nota:";
            // 
            // DetalleInscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 562);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DetalleInscripcion";
            this.Text = "DetalleInscripcion";
            this.Load += new System.EventHandler(this.DetalleInscripcion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetalle)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.semestre2.ResumeLayout(false);
            this.semestre2.PerformLayout();
            this.semestre1.ResumeLayout(false);
            this.semestre1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvdetalle;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Label lblestudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn space1;
        private System.Windows.Forms.DataGridViewImageColumn Pagar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox semestre1;
        private System.Windows.Forms.Button btnGuardarNota1;
        private System.Windows.Forms.TextBox txtnota1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox semestre2;
        private System.Windows.Forms.Button btnGuardarNota2;
        private System.Windows.Forms.TextBox txtnota2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtid;
    }
}
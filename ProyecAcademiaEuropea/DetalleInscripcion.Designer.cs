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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetalleInscripcion));
            this.dgvdetalle = new System.Windows.Forms.DataGridView();
            this.space1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pagar = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblestudiante = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnGuardarNota1 = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.semestre2 = new System.Windows.Forms.GroupBox();
            this.txtnota2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.semestre1 = new System.Windows.Forms.GroupBox();
            this.txtnota1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LbEstuantesR = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetalle)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.semestre2.SuspendLayout();
            this.semestre1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.dgvdetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdetalle_CellContentClick);
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
            this.lblestudiante.Font = new System.Drawing.Font("Century", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestudiante.ForeColor = System.Drawing.Color.Gold;
            this.lblestudiante.Location = new System.Drawing.Point(363, 16);
            this.lblestudiante.Name = "lblestudiante";
            this.lblestudiante.Size = new System.Drawing.Size(101, 33);
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
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(31, 84);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(925, 512);
            this.tabControl1.TabIndex = 64;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Navy;
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dgvdetalle);
            this.tabPage1.Controls.Add(this.lblestudiante);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(917, 483);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registro de Cursos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(23, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(297, 33);
            this.label3.TabIndex = 64;
            this.label3.Text = "Nombre Estudiante:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Navy;
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.LbEstuantesR);
            this.tabPage2.Controls.Add(this.btnGuardarNota1);
            this.tabPage2.Controls.Add(this.txtid);
            this.tabPage2.Controls.Add(this.semestre2);
            this.tabPage2.Controls.Add(this.semestre1);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(917, 483);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Agregar Nota";
            // 
            // btnGuardarNota1
            // 
            this.btnGuardarNota1.BackColor = System.Drawing.Color.Gold;
            this.btnGuardarNota1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarNota1.ForeColor = System.Drawing.Color.Navy;
            this.btnGuardarNota1.Location = new System.Drawing.Point(507, 398);
            this.btnGuardarNota1.Name = "btnGuardarNota1";
            this.btnGuardarNota1.Size = new System.Drawing.Size(109, 46);
            this.btnGuardarNota1.TabIndex = 1;
            this.btnGuardarNota1.Text = "Guardar";
            this.btnGuardarNota1.UseVisualStyleBackColor = false;
            this.btnGuardarNota1.Click += new System.EventHandler(this.btnGuardarNota1_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(531, 411);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(41, 22);
            this.txtid.TabIndex = 5;
            // 
            // semestre2
            // 
            this.semestre2.Controls.Add(this.txtnota2);
            this.semestre2.Controls.Add(this.label2);
            this.semestre2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semestre2.ForeColor = System.Drawing.Color.Gold;
            this.semestre2.Location = new System.Drawing.Point(70, 320);
            this.semestre2.Name = "semestre2";
            this.semestre2.Size = new System.Drawing.Size(369, 124);
            this.semestre2.TabIndex = 4;
            this.semestre2.TabStop = false;
            this.semestre2.Text = "Segundo Semestre";
            // 
            // txtnota2
            // 
            this.txtnota2.Location = new System.Drawing.Point(107, 58);
            this.txtnota2.Name = "txtnota2";
            this.txtnota2.Size = new System.Drawing.Size(100, 32);
            this.txtnota2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(25, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nota:";
            // 
            // semestre1
            // 
            this.semestre1.Controls.Add(this.txtnota1);
            this.semestre1.Controls.Add(this.label1);
            this.semestre1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semestre1.ForeColor = System.Drawing.Color.Gold;
            this.semestre1.Location = new System.Drawing.Point(70, 135);
            this.semestre1.Name = "semestre1";
            this.semestre1.Size = new System.Drawing.Size(369, 124);
            this.semestre1.TabIndex = 3;
            this.semestre1.TabStop = false;
            this.semestre1.Text = "Primer Semestre";
            // 
            // txtnota1
            // 
            this.txtnota1.Location = new System.Drawing.Point(102, 54);
            this.txtnota1.Name = "txtnota1";
            this.txtnota1.Size = new System.Drawing.Size(109, 32);
            this.txtnota1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(24, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nota:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(945, 24);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(49, 54);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 65;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(602, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // LbEstuantesR
            // 
            this.LbEstuantesR.AutoSize = true;
            this.LbEstuantesR.Font = new System.Drawing.Font("Century Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbEstuantesR.ForeColor = System.Drawing.Color.Gold;
            this.LbEstuantesR.Location = new System.Drawing.Point(272, 33);
            this.LbEstuantesR.Name = "LbEstuantesR";
            this.LbEstuantesR.Size = new System.Drawing.Size(260, 34);
            this.LbEstuantesR.TabIndex = 46;
            this.LbEstuantesR.Text = "Registro De Notas:";
            // 
            // DetalleInscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1016, 618);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.TextBox txtnota2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LbEstuantesR;
    }
}
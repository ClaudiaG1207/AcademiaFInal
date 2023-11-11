namespace ProyecAcademiaEuropea
{
    partial class Inscripcion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inscripcion));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataCursos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIdEstudiante = new System.Windows.Forms.TextBox();
            this.btnbuscarestudiante = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.CBIdioma = new System.Windows.Forms.ComboBox();
            this.FechaIns = new System.Windows.Forms.DateTimePicker();
            this.CBNivel = new System.Windows.Forms.ComboBox();
            this.TxtNomEstuIns = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.LbEstuantesR = new System.Windows.Forms.Label();
            this.dtMatriculas = new System.Windows.Forms.DataGridView();
            this.btnadd = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.IdCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdNivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.space1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Ver = new System.Windows.Forms.DataGridViewImageColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCursos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtMatriculas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(24, 54);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1325, 588);
            this.tabControl1.TabIndex = 62;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Navy;
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.btnadd);
            this.tabPage1.Controls.Add(this.dtMatriculas);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1317, 559);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Inscripciones";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Navy;
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.btnGuardar);
            this.tabPage2.Controls.Add(this.LbEstuantesR);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1317, 559);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataCursos);
            this.groupBox2.Font = new System.Drawing.Font("Modern No. 20", 13.8F);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(693, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(616, 323);
            this.groupBox2.TabIndex = 76;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle de Inscripción ";
            // 
            // dataCursos
            // 
            this.dataCursos.AllowUserToAddRows = false;
            this.dataCursos.AllowUserToDeleteRows = false;
            this.dataCursos.AllowUserToResizeRows = false;
            this.dataCursos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCurso,
            this.Curso,
            this.IdNivel,
            this.Nivel});
            this.dataCursos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataCursos.Location = new System.Drawing.Point(3, 41);
            this.dataCursos.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.dataCursos.Name = "dataCursos";
            this.dataCursos.ReadOnly = true;
            this.dataCursos.RowHeadersWidth = 82;
            this.dataCursos.RowTemplate.Height = 33;
            this.dataCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataCursos.ShowCellToolTips = false;
            this.dataCursos.ShowEditingIcon = false;
            this.dataCursos.Size = new System.Drawing.Size(610, 279);
            this.dataCursos.TabIndex = 62;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIdEstudiante);
            this.groupBox1.Controls.Add(this.btnbuscarestudiante);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.CBIdioma);
            this.groupBox1.Controls.Add(this.FechaIns);
            this.groupBox1.Controls.Add(this.CBNivel);
            this.groupBox1.Controls.Add(this.TxtNomEstuIns);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 13.8F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(8, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(679, 277);
            this.groupBox1.TabIndex = 75;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Inscripción:";
            // 
            // txtIdEstudiante
            // 
            this.txtIdEstudiante.Location = new System.Drawing.Point(269, 20);
            this.txtIdEstudiante.Name = "txtIdEstudiante";
            this.txtIdEstudiante.Size = new System.Drawing.Size(40, 32);
            this.txtIdEstudiante.TabIndex = 72;
            this.txtIdEstudiante.Visible = false;
            // 
            // btnbuscarestudiante
            // 
            this.btnbuscarestudiante.BackColor = System.Drawing.Color.Gold;
            this.btnbuscarestudiante.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscarestudiante.ForeColor = System.Drawing.Color.Navy;
            this.btnbuscarestudiante.Location = new System.Drawing.Point(545, 50);
            this.btnbuscarestudiante.Name = "btnbuscarestudiante";
            this.btnbuscarestudiante.Size = new System.Drawing.Size(89, 37);
            this.btnbuscarestudiante.TabIndex = 71;
            this.btnbuscarestudiante.Text = "Buscar";
            this.btnbuscarestudiante.UseVisualStyleBackColor = false;
            this.btnbuscarestudiante.Click += new System.EventHandler(this.btnbuscarestudiante_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gold;
            this.button3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Navy;
            this.button3.Location = new System.Drawing.Point(429, 201);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 37);
            this.button3.TabIndex = 70;
            this.button3.Text = "Agregar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // CBIdioma
            // 
            this.CBIdioma.FormattingEnabled = true;
            this.CBIdioma.Location = new System.Drawing.Point(170, 152);
            this.CBIdioma.Name = "CBIdioma";
            this.CBIdioma.Size = new System.Drawing.Size(204, 33);
            this.CBIdioma.TabIndex = 58;
            // 
            // FechaIns
            // 
            this.FechaIns.Location = new System.Drawing.Point(170, 107);
            this.FechaIns.Name = "FechaIns";
            this.FechaIns.Size = new System.Drawing.Size(271, 32);
            this.FechaIns.TabIndex = 57;
            // 
            // CBNivel
            // 
            this.CBNivel.FormattingEnabled = true;
            this.CBNivel.Location = new System.Drawing.Point(170, 201);
            this.CBNivel.Name = "CBNivel";
            this.CBNivel.Size = new System.Drawing.Size(204, 33);
            this.CBNivel.TabIndex = 56;
            // 
            // TxtNomEstuIns
            // 
            this.TxtNomEstuIns.Enabled = false;
            this.TxtNomEstuIns.Location = new System.Drawing.Point(269, 57);
            this.TxtNomEstuIns.Name = "TxtNomEstuIns";
            this.TxtNomEstuIns.Size = new System.Drawing.Size(266, 32);
            this.TxtNomEstuIns.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(83, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 46;
            this.label4.Text = "Nivel:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(73, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 45;
            this.label3.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(65, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 44;
            this.label2.Text = "Curso:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 25);
            this.label1.TabIndex = 43;
            this.label1.Text = "Nombre y Apellidos :";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Gold;
            this.btnGuardar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Navy;
            this.btnGuardar.Location = new System.Drawing.Point(741, 500);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(131, 37);
            this.btnGuardar.TabIndex = 73;
            this.btnGuardar.Text = "Guadar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // LbEstuantesR
            // 
            this.LbEstuantesR.AutoSize = true;
            this.LbEstuantesR.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbEstuantesR.ForeColor = System.Drawing.Color.Gold;
            this.LbEstuantesR.Location = new System.Drawing.Point(680, 46);
            this.LbEstuantesR.Name = "LbEstuantesR";
            this.LbEstuantesR.Size = new System.Drawing.Size(183, 37);
            this.LbEstuantesR.TabIndex = 71;
            this.LbEstuantesR.Text = "Inscripción:";
            // 
            // dtMatriculas
            // 
            this.dtMatriculas.AllowUserToAddRows = false;
            this.dtMatriculas.AllowUserToDeleteRows = false;
            this.dtMatriculas.AllowUserToResizeRows = false;
            this.dtMatriculas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtMatriculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtMatriculas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.space1,
            this.Eliminar,
            this.Ver});
            this.dtMatriculas.Location = new System.Drawing.Point(18, 100);
            this.dtMatriculas.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.dtMatriculas.Name = "dtMatriculas";
            this.dtMatriculas.ReadOnly = true;
            this.dtMatriculas.RowHeadersWidth = 82;
            this.dtMatriculas.RowTemplate.Height = 33;
            this.dtMatriculas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtMatriculas.ShowCellToolTips = false;
            this.dtMatriculas.ShowEditingIcon = false;
            this.dtMatriculas.Size = new System.Drawing.Size(1262, 416);
            this.dtMatriculas.TabIndex = 62;
            this.dtMatriculas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtMatriculas_CellClick);
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(1220, 16);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(60, 50);
            this.btnadd.TabIndex = 63;
            this.btnadd.Text = "+";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gold;
            this.button2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Navy;
            this.button2.Location = new System.Drawing.Point(403, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 37);
            this.button2.TabIndex = 74;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(127, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(266, 22);
            this.textBox1.TabIndex = 73;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(19, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 25);
            this.label5.TabIndex = 72;
            this.label5.Text = "Buscar :";
            // 
            // IdCurso
            // 
            this.IdCurso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IdCurso.HeaderText = "IdCurso";
            this.IdCurso.MinimumWidth = 10;
            this.IdCurso.Name = "IdCurso";
            this.IdCurso.ReadOnly = true;
            this.IdCurso.Visible = false;
            // 
            // Curso
            // 
            this.Curso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Curso.HeaderText = "Curso";
            this.Curso.MinimumWidth = 10;
            this.Curso.Name = "Curso";
            this.Curso.ReadOnly = true;
            // 
            // IdNivel
            // 
            this.IdNivel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IdNivel.HeaderText = "IdNivel";
            this.IdNivel.MinimumWidth = 10;
            this.IdNivel.Name = "IdNivel";
            this.IdNivel.ReadOnly = true;
            this.IdNivel.Visible = false;
            // 
            // Nivel
            // 
            this.Nivel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nivel.HeaderText = "Nivel";
            this.Nivel.MinimumWidth = 10;
            this.Nivel.Name = "Nivel";
            this.Nivel.ReadOnly = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::ProyecAcademiaEuropea.Properties.Resources.borrar;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 10;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 200;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::ProyecAcademiaEuropea.Properties.Resources.ver;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 10;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 200;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(566, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1285, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(49, 54);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 42;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // space1
            // 
            this.space1.HeaderText = "";
            this.space1.MinimumWidth = 10;
            this.space1.Name = "space1";
            this.space1.ReadOnly = true;
            this.space1.Width = 200;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "";
            this.Eliminar.Image = global::ProyecAcademiaEuropea.Properties.Resources.borrar;
            this.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Eliminar.MinimumWidth = 10;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 200;
            // 
            // Ver
            // 
            this.Ver.HeaderText = "";
            this.Ver.Image = global::ProyecAcademiaEuropea.Properties.Resources.ver__1_;
            this.Ver.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Ver.MinimumWidth = 10;
            this.Ver.Name = "Ver";
            this.Ver.ReadOnly = true;
            this.Ver.Width = 200;
            // 
            // Inscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1379, 663);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inscripcion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inscripcion";
            this.Load += new System.EventHandler(this.Inscripcion_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataCursos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtMatriculas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dtMatriculas;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataCursos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtIdEstudiante;
        private System.Windows.Forms.Button btnbuscarestudiante;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox CBIdioma;
        private System.Windows.Forms.DateTimePicker FechaIns;
        private System.Windows.Forms.ComboBox CBNivel;
        private System.Windows.Forms.TextBox TxtNomEstuIns;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LbEstuantesR;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdNivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn space1;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.DataGridViewImageColumn Ver;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
    }
}
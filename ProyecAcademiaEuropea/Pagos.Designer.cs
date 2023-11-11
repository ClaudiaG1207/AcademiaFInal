namespace ProyecAcademiaEuropea
{
    partial class Pagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pagos));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LbEstuantesR = new System.Windows.Forms.Label();
            this.TxtTipoPa = new System.Windows.Forms.ComboBox();
            this.TxtMonto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FechaPago = new System.Windows.Forms.DateTimePicker();
            this.BtnPagar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtcurso = new System.Windows.Forms.TextBox();
            this.txtidcurso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbldeuda = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvdetalle = new System.Windows.Forms.DataGridView();
            this.space1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pagar = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1042, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(51, 58);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 40;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(391, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // LbEstuantesR
            // 
            this.LbEstuantesR.AutoSize = true;
            this.LbEstuantesR.Font = new System.Drawing.Font("Century Gothic", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbEstuantesR.ForeColor = System.Drawing.Color.Gold;
            this.LbEstuantesR.Location = new System.Drawing.Point(521, 38);
            this.LbEstuantesR.Name = "LbEstuantesR";
            this.LbEstuantesR.Size = new System.Drawing.Size(124, 39);
            this.LbEstuantesR.TabIndex = 41;
            this.LbEstuantesR.Text = "Pagos:";
            // 
            // TxtTipoPa
            // 
            this.TxtTipoPa.FormattingEnabled = true;
            this.TxtTipoPa.Items.AddRange(new object[] {
            "Efectivo ",
            "Transferencia"});
            this.TxtTipoPa.Location = new System.Drawing.Point(218, 156);
            this.TxtTipoPa.Name = "TxtTipoPa";
            this.TxtTipoPa.Size = new System.Drawing.Size(143, 24);
            this.TxtTipoPa.TabIndex = 50;
            // 
            // TxtMonto
            // 
            this.TxtMonto.Location = new System.Drawing.Point(218, 111);
            this.TxtMonto.Name = "TxtMonto";
            this.TxtMonto.Size = new System.Drawing.Size(109, 22);
            this.TxtMonto.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(117, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 22);
            this.label9.TabIndex = 46;
            this.label9.Text = "Monto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(57, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 22);
            this.label5.TabIndex = 45;
            this.label5.Text = "Tipo de Pago:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(68, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 22);
            this.label2.TabIndex = 43;
            this.label2.Text = "Fecha Pago :";
            // 
            // FechaPago
            // 
            this.FechaPago.CalendarFont = new System.Drawing.Font("Modern No. 20", 13.8F);
            this.FechaPago.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaPago.Location = new System.Drawing.Point(218, 61);
            this.FechaPago.Name = "FechaPago";
            this.FechaPago.Size = new System.Drawing.Size(279, 29);
            this.FechaPago.TabIndex = 53;
            // 
            // BtnPagar
            // 
            this.BtnPagar.BackColor = System.Drawing.Color.Gold;
            this.BtnPagar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPagar.ForeColor = System.Drawing.Color.Navy;
            this.BtnPagar.Location = new System.Drawing.Point(478, 228);
            this.BtnPagar.Name = "BtnPagar";
            this.BtnPagar.Size = new System.Drawing.Size(91, 34);
            this.BtnPagar.TabIndex = 67;
            this.BtnPagar.Text = "Pagar";
            this.BtnPagar.UseVisualStyleBackColor = false;
            this.BtnPagar.Click += new System.EventHandler(this.BtnPagar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(123, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 22);
            this.label1.TabIndex = 69;
            this.label1.Text = "Curso:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtcurso);
            this.groupBox1.Controls.Add(this.txtidcurso);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BtnPagar);
            this.groupBox1.Controls.Add(this.FechaPago);
            this.groupBox1.Controls.Add(this.TxtTipoPa);
            this.groupBox1.Controls.Add(this.TxtMonto);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(245, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(626, 286);
            this.groupBox1.TabIndex = 71;
            this.groupBox1.TabStop = false;
            // 
            // txtcurso
            // 
            this.txtcurso.Location = new System.Drawing.Point(218, 22);
            this.txtcurso.Name = "txtcurso";
            this.txtcurso.Size = new System.Drawing.Size(242, 22);
            this.txtcurso.TabIndex = 72;
            // 
            // txtidcurso
            // 
            this.txtidcurso.Location = new System.Drawing.Point(501, 26);
            this.txtidcurso.Name = "txtidcurso";
            this.txtidcurso.Size = new System.Drawing.Size(46, 22);
            this.txtidcurso.TabIndex = 71;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Goldenrod;
            this.label3.Location = new System.Drawing.Point(180, 505);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 27);
            this.label3.TabIndex = 74;
            this.label3.Text = "$";
            // 
            // lbldeuda
            // 
            this.lbldeuda.AutoSize = true;
            this.lbldeuda.BackColor = System.Drawing.Color.Transparent;
            this.lbldeuda.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldeuda.ForeColor = System.Drawing.Color.Goldenrod;
            this.lbldeuda.Location = new System.Drawing.Point(221, 505);
            this.lbldeuda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldeuda.Name = "lbldeuda";
            this.lbldeuda.Size = new System.Drawing.Size(42, 27);
            this.lbldeuda.TabIndex = 73;
            this.lbldeuda.Text = "---";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Goldenrod;
            this.label4.Location = new System.Drawing.Point(11, 505);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 27);
            this.label4.TabIndex = 72;
            this.label4.Text = "Total deuda:";
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
            this.dgvdetalle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvdetalle.Location = new System.Drawing.Point(0, 574);
            this.dgvdetalle.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.dgvdetalle.Name = "dgvdetalle";
            this.dgvdetalle.ReadOnly = true;
            this.dgvdetalle.RowHeadersWidth = 82;
            this.dgvdetalle.RowTemplate.Height = 33;
            this.dgvdetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdetalle.ShowCellToolTips = false;
            this.dgvdetalle.ShowEditingIcon = false;
            this.dgvdetalle.Size = new System.Drawing.Size(1105, 279);
            this.dgvdetalle.TabIndex = 75;
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
            this.Pagar.Image = global::ProyecAcademiaEuropea.Properties.Resources.dolar;
            this.Pagar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Pagar.MinimumWidth = 10;
            this.Pagar.Name = "Pagar";
            this.Pagar.ReadOnly = true;
            this.Pagar.Width = 200;
            // 
            // Pagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1105, 853);
            this.Controls.Add(this.dgvdetalle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbldeuda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LbEstuantesR);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pagos";
            this.Text = "Pagos";
            this.Load += new System.EventHandler(this.Pagos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LbEstuantesR;
        private System.Windows.Forms.ComboBox TxtTipoPa;
        private System.Windows.Forms.TextBox TxtMonto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker FechaPago;
        private System.Windows.Forms.Button BtnPagar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox curso;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtidcurso;
        private System.Windows.Forms.TextBox txtcurso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbldeuda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvdetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn space1;
        private System.Windows.Forms.DataGridViewImageColumn Pagar;
    }
}
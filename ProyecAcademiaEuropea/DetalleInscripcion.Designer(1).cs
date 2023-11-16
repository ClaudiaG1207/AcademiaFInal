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
            this.label1 = new System.Windows.Forms.Label();
            this.lbldeuda = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.space1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Pagar = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetalle)).BeginInit();
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
            this.dgvdetalle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvdetalle.Location = new System.Drawing.Point(0, 240);
            this.dgvdetalle.Margin = new System.Windows.Forms.Padding(20, 19, 20, 19);
            this.dgvdetalle.Name = "dgvdetalle";
            this.dgvdetalle.ReadOnly = true;
            this.dgvdetalle.RowHeadersWidth = 82;
            this.dgvdetalle.RowTemplate.Height = 33;
            this.dgvdetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdetalle.ShowCellToolTips = false;
            this.dgvdetalle.ShowEditingIcon = false;
            this.dgvdetalle.Size = new System.Drawing.Size(1442, 436);
            this.dgvdetalle.TabIndex = 62;
            this.dgvdetalle.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdetalle_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 42);
            this.label1.TabIndex = 63;
            this.label1.Text = "Total deuda:";
            // 
            // lbldeuda
            // 
            this.lbldeuda.AutoSize = true;
            this.lbldeuda.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldeuda.Location = new System.Drawing.Point(288, 36);
            this.lbldeuda.Name = "lbldeuda";
            this.lbldeuda.Size = new System.Drawing.Size(54, 42);
            this.lbldeuda.TabIndex = 64;
            this.lbldeuda.Text = "---";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(245, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 42);
            this.label2.TabIndex = 65;
            this.label2.Text = "$";
            // 
            // space1
            // 
            this.space1.HeaderText = "";
            this.space1.MinimumWidth = 10;
            this.space1.Name = "space1";
            this.space1.ReadOnly = true;
            this.space1.Width = 200;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::ProyecAcademiaEuropea.Properties.Resources.dolar;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 10;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 200;
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
            // DetalleInscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1442, 676);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbldeuda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvdetalle);
            this.Name = "DetalleInscripcion";
            this.Text = "DetalleInscripcion";
            this.Load += new System.EventHandler(this.DetalleInscripcion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvdetalle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbldeuda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn space1;
        private System.Windows.Forms.DataGridViewImageColumn Pagar;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}
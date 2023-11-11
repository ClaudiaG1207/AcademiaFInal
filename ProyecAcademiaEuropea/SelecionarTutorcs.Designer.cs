namespace ProyecAcademiaEuropea
{
    partial class SelecionarTutorcs
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
            this.dtTutor = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtTutor)).BeginInit();
            this.SuspendLayout();
            // 
            // dtTutor
            // 
            this.dtTutor.AllowUserToAddRows = false;
            this.dtTutor.AllowUserToDeleteRows = false;
            this.dtTutor.AllowUserToResizeRows = false;
            this.dtTutor.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtTutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtTutor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtTutor.Location = new System.Drawing.Point(0, 232);
            this.dtTutor.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.dtTutor.Name = "dtTutor";
            this.dtTutor.ReadOnly = true;
            this.dtTutor.RowHeadersWidth = 82;
            this.dtTutor.RowTemplate.Height = 33;
            this.dtTutor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtTutor.ShowCellToolTips = false;
            this.dtTutor.ShowEditingIcon = false;
            this.dtTutor.Size = new System.Drawing.Size(581, 279);
            this.dtTutor.TabIndex = 648;
            this.dtTutor.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtTutor_CellContentDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(52, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 27);
            this.label1.TabIndex = 649;
            this.label1.Text = "Nombre Tutor :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(258, 114);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 19);
            this.textBox1.TabIndex = 650;
            // 
            // SelecionarTutorcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(581, 511);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtTutor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SelecionarTutorcs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelecionarTutorcs";
            this.Load += new System.EventHandler(this.SelecionarTutorcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtTutor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtTutor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}
namespace ProyecAcademiaEuropea
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lblErrorUsuario = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtContra = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabelContra = new System.Windows.Forms.LinkLabel();
            this.BtnMini = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LbError = new System.Windows.Forms.Label();
            this.lblErrorUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblErrorUsuario
            // 
            this.lblErrorUsuario.BackColor = System.Drawing.Color.White;
            this.lblErrorUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.lblErrorUsuario.Controls.Add(this.pictureBox1);
            this.lblErrorUsuario.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblErrorUsuario.Location = new System.Drawing.Point(0, 0);
            this.lblErrorUsuario.Name = "lblErrorUsuario";
            this.lblErrorUsuario.Size = new System.Drawing.Size(250, 377);
            this.lblErrorUsuario.TabIndex = 0;
            this.lblErrorUsuario.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.TxtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUsuario.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.TxtUsuario.ForeColor = System.Drawing.SystemColors.Info;
            this.TxtUsuario.Location = new System.Drawing.Point(375, 122);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(461, 25);
            this.TxtUsuario.TabIndex = 1;
            this.TxtUsuario.Text = "USUARIO";
            this.TxtUsuario.TextChanged += new System.EventHandler(this.TxtUsuario_TextChanged);
            this.TxtUsuario.Enter += new System.EventHandler(this.TxtUsuario_Enter);
            this.TxtUsuario.Leave += new System.EventHandler(this.TxtUsuario_Leave);
            // 
            // TxtContra
            // 
            this.TxtContra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.TxtContra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtContra.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.TxtContra.ForeColor = System.Drawing.SystemColors.Info;
            this.TxtContra.Location = new System.Drawing.Point(375, 190);
            this.TxtContra.Name = "TxtContra";
            this.TxtContra.Size = new System.Drawing.Size(461, 25);
            this.TxtContra.TabIndex = 3;
            this.TxtContra.Text = "CONTRASEÑA";
            this.TxtContra.Enter += new System.EventHandler(this.TxtContra_Enter);
            this.TxtContra.Leave += new System.EventHandler(this.TxtContra_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(375, 153);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(482, 1);
            this.panel2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(375, 221);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(482, 1);
            this.panel3.TabIndex = 10;
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.Gold;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Font = new System.Drawing.Font("Bahnschrift", 10.8F);
            this.BtnLogin.ForeColor = System.Drawing.Color.Navy;
            this.BtnLogin.Location = new System.Drawing.Point(375, 247);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(461, 40);
            this.BtnLogin.TabIndex = 11;
            this.BtnLogin.Text = "ACCEDER";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 18F);
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(546, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = " LOGIN";
            // 
            // linkLabelContra
            // 
            this.linkLabelContra.ActiveLinkColor = System.Drawing.Color.Gold;
            this.linkLabelContra.AutoSize = true;
            this.linkLabelContra.Font = new System.Drawing.Font("Bahnschrift", 10.8F);
            this.linkLabelContra.LinkColor = System.Drawing.SystemColors.Info;
            this.linkLabelContra.Location = new System.Drawing.Point(508, 323);
            this.linkLabelContra.Name = "linkLabelContra";
            this.linkLabelContra.Size = new System.Drawing.Size(218, 22);
            this.linkLabelContra.TabIndex = 0;
            this.linkLabelContra.TabStop = true;
            this.linkLabelContra.Text = "¿Ha olvidado contraseña?";
            this.linkLabelContra.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelContra_LinkClicked);
            // 
            // BtnMini
            // 
            this.BtnMini.Image = ((System.Drawing.Image)(resources.GetObject("BtnMini.Image")));
            this.BtnMini.Location = new System.Drawing.Point(889, 9);
            this.BtnMini.Name = "BtnMini";
            this.BtnMini.Size = new System.Drawing.Size(25, 25);
            this.BtnMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnMini.TabIndex = 12;
            this.BtnMini.TabStop = false;
            this.BtnMini.Click += new System.EventHandler(this.BtnMini_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(930, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // LbError
            // 
            this.LbError.AutoSize = true;
            this.LbError.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbError.ForeColor = System.Drawing.SystemColors.Info;
            this.LbError.Location = new System.Drawing.Point(547, 81);
            this.LbError.Name = "LbError";
            this.LbError.Size = new System.Drawing.Size(132, 28);
            this.LbError.TabIndex = 14;
            this.LbError.Text = "Error Mensaje";
            this.LbError.Visible = false;
            this.LbError.Click += new System.EventHandler(this.LbError_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(962, 377);
            this.Controls.Add(this.LbError);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BtnMini);
            this.Controls.Add(this.linkLabelContra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TxtContra);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.lblErrorUsuario);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Login";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.lblErrorUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel lblErrorUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtContra;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabelContra;
        private System.Windows.Forms.PictureBox BtnMini;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label LbError;
    }
}
namespace UniCosmet
{
    partial class LogIn
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_nickName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_login = new System.Windows.Forms.Button();
            this.bt_signUp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(506, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(454, 560);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 45.2F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 101);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inicia sesión";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 15.2F);
            this.label2.Location = new System.Drawing.Point(32, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "y descubre los beneficios";
            // 
            // tb_nickName
            // 
            this.tb_nickName.Location = new System.Drawing.Point(38, 250);
            this.tb_nickName.Name = "tb_nickName";
            this.tb_nickName.Size = new System.Drawing.Size(181, 22);
            this.tb_nickName.TabIndex = 3;
            this.tb_nickName.TextChanged += new System.EventHandler(this.tb_nickName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 10.2F);
            this.label3.Location = new System.Drawing.Point(34, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "usuario";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(38, 342);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(181, 22);
            this.tb_password.TabIndex = 5;
            this.tb_password.TextChanged += new System.EventHandler(this.tb_password_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 10.2F);
            this.label4.Location = new System.Drawing.Point(34, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "contraseña";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // bt_login
            // 
            this.bt_login.Location = new System.Drawing.Point(38, 431);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(85, 34);
            this.bt_login.TabIndex = 7;
            this.bt_login.Text = "aceptar";
            this.bt_login.UseVisualStyleBackColor = true;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // bt_signUp
            // 
            this.bt_signUp.Location = new System.Drawing.Point(158, 431);
            this.bt_signUp.Name = "bt_signUp";
            this.bt_signUp.Size = new System.Drawing.Size(91, 34);
            this.bt_signUp.TabIndex = 8;
            this.bt_signUp.Text = "registrarse";
            this.bt_signUp.UseVisualStyleBackColor = true;
            this.bt_signUp.Click += new System.EventHandler(this.bt_signUp_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 559);
            this.Controls.Add(this.bt_signUp);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_nickName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LogIn";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_nickName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.Button bt_signUp;
    }
}


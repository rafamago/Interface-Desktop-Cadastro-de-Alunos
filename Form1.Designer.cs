using System;

namespace faculdade
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lb_loginUsario = new System.Windows.Forms.Label();
            this.txt_loginUsuario = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lb_loginSenha = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linklbForgetPassword = new System.Windows.Forms.LinkLabel();
            this.txt_senhaUsuario = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_loginUsario
            // 
            this.lb_loginUsario.AutoSize = true;
            this.lb_loginUsario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_loginUsario.Location = new System.Drawing.Point(23, 20);
            this.lb_loginUsario.Name = "lb_loginUsario";
            this.lb_loginUsario.Size = new System.Drawing.Size(75, 24);
            this.lb_loginUsario.TabIndex = 0;
            this.lb_loginUsario.Text = "Usuário";
            this.lb_loginUsario.Click += new System.EventHandler(this.lb_nomeAluno_Click);
            // 
            // txt_loginUsuario
            // 
            this.txt_loginUsuario.Location = new System.Drawing.Point(25, 47);
            this.txt_loginUsuario.Name = "txt_loginUsuario";
            this.txt_loginUsuario.Size = new System.Drawing.Size(107, 22);
            this.txt_loginUsuario.TabIndex = 1;
            this.txt_loginUsuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Aqua;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogin.Location = new System.Drawing.Point(27, 194);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(107, 35);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Entrar";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lb_loginSenha
            // 
            this.lb_loginSenha.AutoSize = true;
            this.lb_loginSenha.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_loginSenha.Location = new System.Drawing.Point(23, 93);
            this.lb_loginSenha.Name = "lb_loginSenha";
            this.lb_loginSenha.Size = new System.Drawing.Size(61, 24);
            this.lb_loginSenha.TabIndex = 6;
            this.lb_loginSenha.Text = "Senha";
            this.lb_loginSenha.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aquamarine;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.linklbForgetPassword);
            this.panel1.Controls.Add(this.txt_senhaUsuario);
            this.panel1.Controls.Add(this.lb_loginSenha);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.txt_loginUsuario);
            this.panel1.Controls.Add(this.lb_loginUsario);
            this.panel1.Location = new System.Drawing.Point(41, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 255);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(177, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // linklbForgetPassword
            // 
            this.linklbForgetPassword.AutoSize = true;
            this.linklbForgetPassword.Location = new System.Drawing.Point(24, 160);
            this.linklbForgetPassword.Name = "linklbForgetPassword";
            this.linklbForgetPassword.Size = new System.Drawing.Size(209, 16);
            this.linklbForgetPassword.TabIndex = 8;
            this.linklbForgetPassword.TabStop = true;
            this.linklbForgetPassword.Text = "Esqueci minha senha / Recuperar";
            this.linklbForgetPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbForgetPassword_LinkClicked);
            // 
            // txt_senhaUsuario
            // 
            this.txt_senhaUsuario.Location = new System.Drawing.Point(25, 119);
            this.txt_senhaUsuario.Name = "txt_senhaUsuario";
            this.txt_senhaUsuario.PasswordChar = '*';
            this.txt_senhaUsuario.Size = new System.Drawing.Size(107, 22);
            this.txt_senhaUsuario.TabIndex = 7;
            this.txt_senhaUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_senhaUsuario.TextChanged += new System.EventHandler(this.txt_senhaUsuario_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(404, 318);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Label lb_loginUsario;
        private System.Windows.Forms.TextBox txt_loginUsuario;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lb_loginSenha;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linklbForgetPassword;
        private System.Windows.Forms.TextBox txt_senhaUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


namespace faculdade
{
    partial class Form3
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
            this.lbl_Esquecisenha = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_enviaremailrecup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Esquecisenha
            // 
            this.lbl_Esquecisenha.AutoSize = true;
            this.lbl_Esquecisenha.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Esquecisenha.Location = new System.Drawing.Point(27, 31);
            this.lbl_Esquecisenha.Name = "lbl_Esquecisenha";
            this.lbl_Esquecisenha.Size = new System.Drawing.Size(449, 22);
            this.lbl_Esquecisenha.TabIndex = 0;
            this.lbl_Esquecisenha.Text = "Digite seu e-mail e enviaremos um código de recuperação:";
            this.lbl_Esquecisenha.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(55, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(411, 22);
            this.textBox1.TabIndex = 1;
            // 
            // btn_enviaremailrecup
            // 
            this.btn_enviaremailrecup.BackColor = System.Drawing.Color.Turquoise;
            this.btn_enviaremailrecup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_enviaremailrecup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_enviaremailrecup.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enviaremailrecup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_enviaremailrecup.Location = new System.Drawing.Point(209, 119);
            this.btn_enviaremailrecup.Name = "btn_enviaremailrecup";
            this.btn_enviaremailrecup.Size = new System.Drawing.Size(93, 37);
            this.btn_enviaremailrecup.TabIndex = 2;
            this.btn_enviaremailrecup.Text = "Enviar";
            this.btn_enviaremailrecup.UseVisualStyleBackColor = false;
            this.btn_enviaremailrecup.Click += new System.EventHandler(this.btn_enviaremailrecup_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(528, 190);
            this.Controls.Add(this.btn_enviaremailrecup);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_Esquecisenha);
            this.Cursor = System.Windows.Forms.Cursors.No;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Esquecisenha;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_enviaremailrecup;
    }
}
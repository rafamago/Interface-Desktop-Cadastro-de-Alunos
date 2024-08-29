using System;

namespace faculdade
{
    partial class Form2
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
            this.lbl_nameAluno = new System.Windows.Forms.Label();
            this.lbl_emailAluno = new System.Windows.Forms.Label();
            this.txt_aluno = new System.Windows.Forms.TextBox();
            this.btn_cleanCadastro = new System.Windows.Forms.Button();
            this.btn_eraseCadastro = new System.Windows.Forms.Button();
            this.txt_telefoneAluno = new System.Windows.Forms.TextBox();
            this.txt_adressAluno = new System.Windows.Forms.TextBox();
            this.lbl_adressAluno = new System.Windows.Forms.Label();
            this.btn_salvarCadastro = new System.Windows.Forms.Button();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.lbl_registerPin = new System.Windows.Forms.Label();
            this.txt_matriculaAluno = new System.Windows.Forms.TextBox();
            this.txt_emailAluno = new System.Windows.Forms.TextBox();
            this.dgv_aluno = new System.Windows.Forms.DataGridView();
            this.btn_sairCadastroAluno = new System.Windows.Forms.Button();
            this.lbl_alunosCadastrados = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.txt_estado = new System.Windows.Forms.Label();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_aluno)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nameAluno
            // 
            this.lbl_nameAluno.AutoSize = true;
            this.lbl_nameAluno.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nameAluno.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_nameAluno.Location = new System.Drawing.Point(14, 74);
            this.lbl_nameAluno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nameAluno.Name = "lbl_nameAluno";
            this.lbl_nameAluno.Size = new System.Drawing.Size(45, 18);
            this.lbl_nameAluno.TabIndex = 1;
            this.lbl_nameAluno.Text = "Aluno";
            this.lbl_nameAluno.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lbl_emailAluno
            // 
            this.lbl_emailAluno.AutoSize = true;
            this.lbl_emailAluno.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_emailAluno.Location = new System.Drawing.Point(14, 163);
            this.lbl_emailAluno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_emailAluno.Name = "lbl_emailAluno";
            this.lbl_emailAluno.Size = new System.Drawing.Size(42, 18);
            this.lbl_emailAluno.TabIndex = 2;
            this.lbl_emailAluno.Text = "Email";
            this.lbl_emailAluno.Click += new System.EventHandler(this.lbl_email_Click);
            // 
            // txt_aluno
            // 
            this.txt_aluno.Location = new System.Drawing.Point(15, 94);
            this.txt_aluno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_aluno.Name = "txt_aluno";
            this.txt_aluno.Size = new System.Drawing.Size(334, 20);
            this.txt_aluno.TabIndex = 3;
            // 
            // btn_cleanCadastro
            // 
            this.btn_cleanCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_cleanCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cleanCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cleanCadastro.Location = new System.Drawing.Point(500, 129);
            this.btn_cleanCadastro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_cleanCadastro.Name = "btn_cleanCadastro";
            this.btn_cleanCadastro.Size = new System.Drawing.Size(104, 28);
            this.btn_cleanCadastro.TabIndex = 5;
            this.btn_cleanCadastro.Text = "Limpar";
            this.btn_cleanCadastro.UseVisualStyleBackColor = false;
            this.btn_cleanCadastro.Click += new System.EventHandler(this.btn_cleanCadastro_Click);
            // 
            // btn_eraseCadastro
            // 
            this.btn_eraseCadastro.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_eraseCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_eraseCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eraseCadastro.Location = new System.Drawing.Point(500, 214);
            this.btn_eraseCadastro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_eraseCadastro.Name = "btn_eraseCadastro";
            this.btn_eraseCadastro.Size = new System.Drawing.Size(104, 25);
            this.btn_eraseCadastro.TabIndex = 6;
            this.btn_eraseCadastro.Text = "Apagar";
            this.btn_eraseCadastro.UseVisualStyleBackColor = false;
            this.btn_eraseCadastro.Click += new System.EventHandler(this.btn_eraseCadastro_Click);
            // 
            // txt_telefoneAluno
            // 
            this.txt_telefoneAluno.Location = new System.Drawing.Point(16, 136);
            this.txt_telefoneAluno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_telefoneAluno.Name = "txt_telefoneAluno";
            this.txt_telefoneAluno.Size = new System.Drawing.Size(140, 20);
            this.txt_telefoneAluno.TabIndex = 7;
            // 
            // txt_adressAluno
            // 
            this.txt_adressAluno.Location = new System.Drawing.Point(15, 232);
            this.txt_adressAluno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_adressAluno.Multiline = true;
            this.txt_adressAluno.Name = "txt_adressAluno";
            this.txt_adressAluno.Size = new System.Drawing.Size(334, 24);
            this.txt_adressAluno.TabIndex = 13;
            this.txt_adressAluno.TextChanged += new System.EventHandler(this.txt_adressAluno_TextChanged);
            // 
            // lbl_adressAluno
            // 
            this.lbl_adressAluno.AutoSize = true;
            this.lbl_adressAluno.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_adressAluno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_adressAluno.Location = new System.Drawing.Point(14, 211);
            this.lbl_adressAluno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_adressAluno.Name = "lbl_adressAluno";
            this.lbl_adressAluno.Size = new System.Drawing.Size(66, 18);
            this.lbl_adressAluno.TabIndex = 14;
            this.lbl_adressAluno.Text = "Endereço";
            // 
            // btn_salvarCadastro
            // 
            this.btn_salvarCadastro.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_salvarCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_salvarCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvarCadastro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_salvarCadastro.Location = new System.Drawing.Point(500, 174);
            this.btn_salvarCadastro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_salvarCadastro.Name = "btn_salvarCadastro";
            this.btn_salvarCadastro.Size = new System.Drawing.Size(104, 26);
            this.btn_salvarCadastro.TabIndex = 15;
            this.btn_salvarCadastro.Text = "Salvar";
            this.btn_salvarCadastro.UseVisualStyleBackColor = false;
            this.btn_salvarCadastro.Click += new System.EventHandler(this.btn_salvarCadastro_Click);
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phone.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_phone.Location = new System.Drawing.Point(14, 115);
            this.lbl_phone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(63, 18);
            this.lbl_phone.TabIndex = 16;
            this.lbl_phone.Text = "Telefone";
            // 
            // lbl_registerPin
            // 
            this.lbl_registerPin.AutoSize = true;
            this.lbl_registerPin.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_registerPin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_registerPin.Location = new System.Drawing.Point(169, 119);
            this.lbl_registerPin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_registerPin.Name = "lbl_registerPin";
            this.lbl_registerPin.Size = new System.Drawing.Size(65, 18);
            this.lbl_registerPin.TabIndex = 17;
            this.lbl_registerPin.Text = "Matrícula";
            // 
            // txt_matriculaAluno
            // 
            this.txt_matriculaAluno.Location = new System.Drawing.Point(171, 137);
            this.txt_matriculaAluno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_matriculaAluno.Name = "txt_matriculaAluno";
            this.txt_matriculaAluno.Size = new System.Drawing.Size(178, 20);
            this.txt_matriculaAluno.TabIndex = 18;
            // 
            // txt_emailAluno
            // 
            this.txt_emailAluno.Location = new System.Drawing.Point(15, 184);
            this.txt_emailAluno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_emailAluno.Name = "txt_emailAluno";
            this.txt_emailAluno.Size = new System.Drawing.Size(334, 20);
            this.txt_emailAluno.TabIndex = 19;
            // 
            // dgv_aluno
            // 
            this.dgv_aluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_aluno.Location = new System.Drawing.Point(15, 287);
            this.dgv_aluno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_aluno.Name = "dgv_aluno";
            this.dgv_aluno.RowHeadersWidth = 51;
            this.dgv_aluno.RowTemplate.Height = 24;
            this.dgv_aluno.Size = new System.Drawing.Size(589, 195);
            this.dgv_aluno.TabIndex = 20;
            this.dgv_aluno.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_aluno_CellContentClick);
            // 
            // btn_sairCadastroAluno
            // 
            this.btn_sairCadastroAluno.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_sairCadastroAluno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sairCadastroAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sairCadastroAluno.Location = new System.Drawing.Point(500, 84);
            this.btn_sairCadastroAluno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_sairCadastroAluno.Name = "btn_sairCadastroAluno";
            this.btn_sairCadastroAluno.Size = new System.Drawing.Size(104, 28);
            this.btn_sairCadastroAluno.TabIndex = 21;
            this.btn_sairCadastroAluno.Text = "Sair";
            this.btn_sairCadastroAluno.UseVisualStyleBackColor = false;
            this.btn_sairCadastroAluno.Click += new System.EventHandler(this.btn_sairCadastroAluno_Click);
            // 
            // lbl_alunosCadastrados
            // 
            this.lbl_alunosCadastrados.AutoSize = true;
            this.lbl_alunosCadastrados.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_alunosCadastrados.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_alunosCadastrados.Location = new System.Drawing.Point(14, 267);
            this.lbl_alunosCadastrados.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_alunosCadastrados.Name = "lbl_alunosCadastrados";
            this.lbl_alunosCadastrados.Size = new System.Drawing.Size(127, 18);
            this.lbl_alunosCadastrados.TabIndex = 22;
            this.lbl_alunosCadastrados.Text = "Alunos cadastrados";
            this.lbl_alunosCadastrados.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aqua;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(436, 495);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 25);
            this.button1.TabIndex = 25;
            this.button1.Text = "Consultar alunos";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.Location = new System.Drawing.Point(226, 20);
            this.lbl_welcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(160, 24);
            this.lbl_welcome.TabIndex = 26;
            this.lbl_welcome.Text = "Seja bem vinda ";
            // 
            // txt_estado
            // 
            this.txt_estado.AutoSize = true;
            this.txt_estado.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_estado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_estado.Location = new System.Drawing.Point(359, 211);
            this.txt_estado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Size = new System.Drawing.Size(49, 18);
            this.txt_estado.TabIndex = 28;
            this.txt_estado.Text = "Estado";
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.ItemHeight = 13;
            this.comboBoxEstado.Items.AddRange(new object[] {
            "Acre (AC)",
            "Alagoas (AL)",
            "Amapá (AP)",
            "Amazonas (AM)",
            "Bahia (BA)",
            "Ceará (CE)",
            "Espírito Santo (ES)",
            "Goiás (GO)",
            "Maranhão (MA)",
            "Mato Grosso (MT)",
            "Mato Grosso do Sul (MS)",
            "Minas Gerais (MG)",
            "Pará (PA)",
            "Paraíba (PB)",
            "Paraná (PR)",
            "Pernambuco (PE)",
            "Piauí (PI)",
            "Rio de Janeiro (RJ)",
            "Rio Grande do Norte (RN)",
            "Rio Grande do Sul (RS)",
            "Rondônia (RO)",
            "Roraima (RR)",
            "Santa Catarina (SC)",
            "São Paulo (SP)",
            "Sergipe (SE)",
            "Tocantins (TO)",
            "Distrito Federal (DF)"});
            this.comboBoxEstado.Location = new System.Drawing.Point(362, 235);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(113, 21);
            this.comboBoxEstado.TabIndex = 29;
            this.comboBoxEstado.SelectedIndexChanged += new System.EventHandler(this.comboBoxEstado_SelectedIndexChanged_1);
            this.comboBoxEstado.DragDrop += new System.Windows.Forms.DragEventHandler(this.comboBoxEstado_DragDrop);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(635, 532);
            this.Controls.Add(this.comboBoxEstado);
            this.Controls.Add(this.txt_estado);
            this.Controls.Add(this.lbl_welcome);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_alunosCadastrados);
            this.Controls.Add(this.btn_sairCadastroAluno);
            this.Controls.Add(this.dgv_aluno);
            this.Controls.Add(this.txt_emailAluno);
            this.Controls.Add(this.txt_matriculaAluno);
            this.Controls.Add(this.lbl_registerPin);
            this.Controls.Add(this.lbl_phone);
            this.Controls.Add(this.btn_salvarCadastro);
            this.Controls.Add(this.lbl_adressAluno);
            this.Controls.Add(this.txt_adressAluno);
            this.Controls.Add(this.txt_telefoneAluno);
            this.Controls.Add(this.btn_eraseCadastro);
            this.Controls.Add(this.btn_cleanCadastro);
            this.Controls.Add(this.txt_aluno);
            this.Controls.Add(this.lbl_emailAluno);
            this.Controls.Add(this.lbl_nameAluno);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_aluno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click_2(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lbl_email_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Label lbl_nameAluno;
        private System.Windows.Forms.Label lbl_emailAluno;
        private System.Windows.Forms.TextBox txt_aluno;
        private System.Windows.Forms.Button btn_cleanCadastro;
        private System.Windows.Forms.Button btn_eraseCadastro;
        private System.Windows.Forms.TextBox txt_adressAluno;
        private System.Windows.Forms.Label lbl_adressAluno;
        private System.Windows.Forms.Button btn_salvarCadastro;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.Label lbl_registerPin;
        private System.Windows.Forms.TextBox txt_matriculaAluno;
        private System.Windows.Forms.TextBox txt_emailAluno;
        private System.Windows.Forms.DataGridView dgv_aluno;
        private System.Windows.Forms.Button btn_sairCadastroAluno;
        private System.Windows.Forms.Label lbl_alunosCadastrados;
        private System.Windows.Forms.TextBox txt_telefoneAluno;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Label txt_estado;
        private System.Windows.Forms.ComboBox comboBoxEstado;
    }
}
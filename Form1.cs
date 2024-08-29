using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace faculdade
{
    public partial class Form1 : Form
    {

        //conexao com o banco
        //private MySqlConnection conexao;
        //// comando sql
        //private MySqlCommand comando;
        //// retorno do comando
        //private MySqlDataAdapter dataAdapter;

        ////string de conexao com o endereco do banco
        //string connectionString = "Server=127.0.0.1;Port=3306;Uid=root;Pwd=rfmysql123;Database=escola;";
        public Form1()
        {
            InitializeComponent();
        }

        private void lb_nomeAluno_Click(object sender, EventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(txt_loginUsuario.Text);
            form2.ShowDialog();
            this.Close();

            if ((txt_loginUsuario.Text == "") || (txt_loginUsuario.Text != "lucy"))
            {
                MessageBox.Show("Usuário inválido", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if ((txt_senhaUsuario.Text == "") || (txt_senhaUsuario.Text != "4567"))
            {
                MessageBox.Show("Senha inválida", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Form2 form = new Form2(txt_loginUsuario.Text);
                form.ShowDialog();
                this.Close();
            }

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void txt_senhaUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void linklbForgetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
            this.Close();
        }
    }
}

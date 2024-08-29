using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Google.Protobuf;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using faculdade;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using MySqlX.XDevAPI.Common;


namespace faculdade
{
    public partial class Form2 : Form
    {
        //conexao com o banco
        private MySqlConnection conexao;
        // comando sql
        private MySqlCommand comando;
        // retorno do comando
        private MySqlDataAdapter dataAdapter;

        //string de conexao com o endereco do banco
        string connectionString = "Server=;Port=;Uid=root;Pwd=;Database=escola;";

        //armazena a linha selecionada do datagridview
        int row_selected;

        public Form2(string loginUsuario)
        {
            InitializeComponent();
            lbl_welcome.Text += loginUsuario+"!";

        }

        private void exibirDados()
        {
            conexao = new MySqlConnection(connectionString);
            try
            {
                conexao.Open();

                string sql_select_dadosAluno="";
                if (txt_matriculaAluno.Text == "")
                {
                    sql_select_dadosAluno = "Select id_aluno as ID, matricula as Matricula,nome_aluno as Aluno, email_aluno as Email, whatsapp_aluno as Telefone, endereco_aluno as Endereco, estado_aluno as Estado from escola.tb_aluno ORDER BY nome_aluno;";
                    comando = new MySqlCommand(sql_select_dadosAluno, conexao);
                }
                else
                {
                    string sql_verificaSeMatriculaExiste = $"select matricula from tb_aluno where matricula = {txt_matriculaAluno.Text};";
                    comando = new MySqlCommand(sql_verificaSeMatriculaExiste, conexao);
                    var result = comando.ExecuteReader();
                    if (result.HasRows is false)
                    {
                        sql_select_dadosAluno = "Select id_aluno as ID, matricula as Matricula,nome_aluno as Aluno, email_aluno as Email, whatsapp_aluno as Telefone, endereco_aluno as Endereco, estado_aluno as Estado from escola.tb_aluno ORDER BY nome_aluno;";
                        MessageBox.Show("Matricula incorreta","Tente Novamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        sql_select_dadosAluno = $"Select id_aluno as ID, matricula as Matricula,nome_aluno as Aluno, email_aluno as Email, whatsapp_aluno as Telefone, endereco_aluno as Endereco, estado_aluno as Estado from escola.tb_aluno where matricula = { txt_matriculaAluno.Text};";
                    }
                }

                if (conexao.State == ConnectionState.Open)
                    conexao.Close();

                //cria o objeto com o comando sql e a conexao
                comando = new MySqlCommand(sql_select_dadosAluno, conexao);

                //cria o objeto que armazena o resultado do select
                DataTable dataTable = new DataTable();

                //popula o datatable como  select
                dataAdapter = new MySqlDataAdapter(comando);
                dataAdapter.Fill(dataTable);
                //atribui o datatable ao objeto interface o datagridview
                dgv_aluno.DataSource = dataTable;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message);
            }
            finally
            {
                if (conexao.State == ConnectionState.Open)
                    conexao.Close();
            }


        }

        private void btn_cleanCadastro_Click(object sender, EventArgs e)
        {
            txt_aluno.Clear();
            txt_emailAluno.Clear();
            txt_adressAluno.Clear();
            txt_telefoneAluno.Clear();
            txt_matriculaAluno.Clear();
   
            comboBoxEstado.SelectedIndex = -1;
        }

        private void btn_eraseCadastro_Click(object sender, EventArgs e)
        {

            conexao = new MySqlConnection(connectionString);


            if (MessageBox.Show("Deseja apagar este registro?", "Cadastro Aluno", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                try
                {
                    conexao.Open();
                    DataGridViewRow selectedRow;

                    if (txt_matriculaAluno.Text == "")
                    {
                        selectedRow = dgv_aluno.SelectedRows[0];

                        string sql_deleteAluno = $"delete from tb_aluno where id_aluno = {selectedRow.Cells["ID"].Value};";
                        comando = new MySqlCommand(sql_deleteAluno, conexao);
                        comando.ExecuteReader();

                        MessageBox.Show("Aluno apagado do banco de dados!");

                        dgv_aluno.Rows.RemoveAt(row_selected);
                        if (conexao.State == ConnectionState.Open)
                            conexao.Close();
                    }

                    else
                    {
                        string sql_deleteAlunoPorMatricula = $"delete from tb_aluno where matricula = {txt_matriculaAluno.Text};";
                        comando = new MySqlCommand(sql_deleteAlunoPorMatricula, conexao);
                        comando.ExecuteReader();

                        MessageBox.Show("Aluno apagado do banco de dados!");
                        if (conexao.State == ConnectionState.Open)
                            conexao.Close();


                    }

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message);
                }
                finally
                {
                    if (conexao.State == ConnectionState.Open)
                        conexao.Close();
                }
        }

        private void dgv_aluno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //SE O USUARIO CLICAR EM UMA LINHA DO DGV
            if (e.RowIndex == 0)
            {
                row_selected = e.RowIndex;

                DataGridViewRow row = dgv_aluno.Rows[e.RowIndex];

                //para preencher os campos com os valores do banco

                txt_matriculaAluno.Text = row.Cells["Matricula"].Value.ToString();
                txt_aluno.Text = row.Cells["Aluno"].Value.ToString();
                txt_telefoneAluno.Text = row.Cells["Telefone"].Value.ToString();
                txt_emailAluno.Text = row.Cells["Email"].Value.ToString();
                txt_adressAluno.Text = row.Cells["Endereco"].Value.ToString();
                comboBoxEstado.Text = row.Cells["Estado"].Value.ToString();

            }
        }


        private void btn_salvarCadastro_Click(object sender, EventArgs e)
        {
            conexao = new MySqlConnection(connectionString);

            conexao.Open();
            string sql_verificaSeAlunoExiste = $"select matricula from tb_aluno where matricula = {txt_matriculaAluno.Text};";
            comando = new MySqlCommand(sql_verificaSeAlunoExiste, conexao);
            var result = comando.ExecuteReader();
            

            if (result.HasRows is false)
            {

                // Se o aluno não existir, chama o método para incluí-lo
                incluirAluno();
                btn_cleanCadastro_Click(sender, e);
            }
            else
            {
                atualizarAluno();
            }

            if (conexao.State == ConnectionState.Open)
                conexao.Close();
            
            
        }


        private void incluirAluno()
        {
            conexao = new MySqlConnection(connectionString);
            try
            {
                conexao.Open();

                string sql_insertAluno = "INSERT INTO escola.tb_aluno (matricula, nome_aluno, email_aluno, whatsapp_aluno, endereco_aluno, estado_aluno) VALUES (@matricula, @nome_aluno, @email_aluno, @telefone_aluno, @endereco_aluno, @estado_aluno);";

                //obter os valores dos campos
              
                int matricula = Convert.ToInt32(txt_matriculaAluno.Text);
                string nome_aluno = txt_aluno.Text;
                string endereco_aluno = txt_adressAluno.Text;
                string email_aluno = txt_emailAluno.Text;
                string telefone_aluno = txt_telefoneAluno.Text;
                string estado_aluno = comboBoxEstado.Text;

                //cria o bojeto com o comando e a conexao
                comando = new MySqlCommand(sql_insertAluno, conexao);

                //adiciona os parametros com os valores dos campos
                comando.Parameters.AddWithValue("@matricula", matricula);
                comando.Parameters.AddWithValue("@nome_aluno", nome_aluno);
                comando.Parameters.AddWithValue("@endereco_aluno", endereco_aluno);
                comando.Parameters.AddWithValue("@email_aluno", email_aluno);
                comando.Parameters.AddWithValue("@telefone_aluno", telefone_aluno);
                comando.Parameters.AddWithValue("@estado_aluno", estado_aluno);

                
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro salvo com sucesso!");

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message);
            }
            finally
            {
                if (conexao.State == ConnectionState.Open)
                    conexao.Close();
            }
        }

        private void atualizarAluno()
        {
            conexao = new MySqlConnection(connectionString);
            try
            {
                conexao.Open();
                string sql_atualizaAluno = $"update escola.tb_aluno set nome_aluno= '{txt_aluno.Text}', email_aluno = '{txt_emailAluno.Text}', whatsapp_aluno = '{txt_telefoneAluno.Text}', endereco_aluno = '{txt_adressAluno.Text}', estado_aluno = '{comboBoxEstado.Text}' ;";

                comando = new MySqlCommand(sql_atualizaAluno, conexao);

                comando.ExecuteReader();

                MessageBox.Show("Registro atualizado com sucesso!");
            }
            catch (MySqlException EX)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados: " + EX.Message);

            }
            finally
            {
                if (conexao.State == ConnectionState.Open)
                    conexao.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            exibirDados();

        }

        private void btn_sairCadastroAluno_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void comboBoxEstado_DragDrop(object sender, DragEventArgs e)
        {

        }


        private void comboBoxEstado_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void txt_adressAluno_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

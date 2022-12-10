using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StudantsList
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Criando conexão com banco de dados
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "Server=localhost;Database=app;Uid=root;Pwd=root;";

            // Caso a conexão não estiver aberta abra ela
            if (conn.State != System.Data.ConnectionState.Open)
                conn.Open();

            // Query para procurar um registro com o mesmo e-mail e senha que o usuário passou
            string query = "SELECT * FROM aluno WHERE email = '" + textBox1.Text.Trim() + "' " +
                            "AND senha = '"+ textBox2.Text.Trim() +"' ";

            // Cria um dataset
            DataTable dt = new DataTable();

            // Cria um adapter para receber os dados da consulta
            MySqlDataAdapter da = new MySqlDataAdapter(query, conn);

            // Preencha o dataset com a consulta realizada
            da.Fill(dt);

            try
            {
                // Caso retorne apenas 1 registro significa que usuário está cadastrado
                if (dt.Rows.Count == 1)
                {
                    // Instancia um novo form principal
                    FrmPrincipal principal = new FrmPrincipal();
                    this.Hide(); // Oculta o form atual

                    // Exibe o form principal instanciado e encerra a conexão
                    principal.Show(); 
                    conn.Close();
                }
                else
                {
                    // Caso não encontre um registro com as informações fornecidas pelo usuário
                    MessageBox.Show("E-mail ou senha inválido(s)!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // Limpa os campos E-mail e senha
                    textBox1.Text = ""; // E-mail
                    textBox2.Text = ""; // Senha
                }
            } catch(Exception exc)
            {
                MessageBox.Show("Ocorreu um erro: " + exc);
            }
           
        }

        // Botão de cadastro caso o usuário não tiver um login
        private void button2_Click(object sender, EventArgs e)
        {
            frmCadastro cadastro = new frmCadastro();
            this.Hide();
            cadastro.Show();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

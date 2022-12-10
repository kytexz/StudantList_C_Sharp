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
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Criando conexão com o banco
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "Server=localhost;Database=app;Uid=root;Pwd=root;";
            if (conn.State != System.Data.ConnectionState.Open)
                conn.Open();

            try
            {
                // Verifica se há campos em branco
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
                {
                    MessageBox.Show("Você não pode deixar campos em branco!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Verificar se no campo E-mail possui os caracteres @ e .com
                    Boolean validarEmail = textBox2.Text.Contains("@") && textBox2.Text.Contains(".com");
                    if (validarEmail == false)
                    {
                        MessageBox.Show("Digite um e-mail válido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Verifica se as senhas são as mesmas
                    } else if(textBox3.Text.Trim() != textBox4.Text.Trim())
                    {
                        MessageBox.Show("As senhas não coincidem!", "Confira sua senha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        // Query para verificar se E-mail ou RA já foi usado
                        string consulta = "SELECT * FROM aluno WHERE ra = '" + textBox1.Text.Trim() + "' " +
                            "OR email = '" + textBox2.Text.Trim() + "' ";

                        // Cria um dataset
                        DataTable dt = new DataTable();

                        // Cria um adapter para receber os dados da consulta
                        MySqlDataAdapter da = new MySqlDataAdapter(consulta, conn);

                        // Preencha o dataset com a consulta realizada
                        da.Fill(dt);

                        // Caso encontre 1 registro significado que cadastro já existe 
                        if (dt.Rows.Count == 1)
                        {
                            MessageBox.Show("Este E-mail ou RA já está sendo utilizado! Por favor tente outro.", "Cadastro já existe!", 
                                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            // Query para inserir dados na tabela aluno
                            string query = "INSERT INTO aluno(ra, email, senha)" +
                                            "VALUES('" + textBox1.Text.Trim() + "', '" + textBox2.Text.Trim() + "', '" + textBox3.Text.Trim() + "' )";
                            MySqlCommand cmd = new MySqlCommand(query, conn);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Usuário(a) criado com sucesso!", "Conta criada");

                            // Instancia novo frmLogin
                            frmLogin login = new frmLogin();

                            // Oculta o formulário atual
                            this.Hide();

                            // Exibe o formulário que foi instanciado e encerra a conexão
                            login.Show();
                            conn.Close();
                        }
                    }
                }     
            } catch(Exception exc)
            {
                MessageBox.Show("Ocorreu um erro: " + exc);
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class frmAdicionarMateria : Form
    {
        public frmAdicionarMateria()
        {
            InitializeComponent();
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void buttonFecharForm_Click(object sender, EventArgs e)
        {
            // Fecha o formulário atual
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Criando a conexão com o banco de dados
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "Server=localhost;Database=app;Uid=root;Pwd=root";
            conn.Open();
            if (conn.State != System.Data.ConnectionState.Open)
                conn.Open();

            try
            {
                // Verifica se há campos em branco
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || maskedTextBox1.Text == "" || maskedTextBox2.Text == "")
                {
                    MessageBox.Show("Você não pode deixar campos em branco!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Converte a data do formulário de DD/MM/AAAA para AAAA/MM/DD para inserir no banco
                    String dataInicio = Convert.ToDateTime(maskedTextBox1.Text).ToString("yyyy/MM/dd");
                    String dataFim = Convert.ToDateTime(maskedTextBox2.Text).ToString("yyyy/MM/dd");

                    // Query para inserir dados na tabela materia
                    String query = "INSERT INTO materia(codigo_materia, nome_materia, nome_professor, dtInicio, dtFim) " +
                        "VALUES('" + textBox1.Text.Trim() + "', '" + textBox2.Text.Trim() + "', '" + textBox3.Text.Trim() + "', " +
                        "'" + dataInicio + "', '" + dataFim + "')";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();

                    // Mensagem para confirmar que a query foi executada com sucesso
                    MessageBox.Show("Matéria Adicionada!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Fecha o formulário atual e encerra a conexão
                    this.Close();
                    conn.Close();

                }
            } catch(Exception exc)
            {
                MessageBox.Show("Ocorreu um erro: " + exc);
            }
            

            
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void frmAdicionarMateria_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class frmAdicionarAtividade : Form
    {
        public frmAdicionarAtividade()
        {
            InitializeComponent();
        }

        private void formAdicionarTarefa_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'appDataSet1.materia'. Você pode movê-la ou removê-la conforme necessário.
            this.materiaTableAdapter.Fill(this.appDataSet1.materia);
            // TODO: esta linha de código carrega dados na tabela 'appDataSet.materia'. Você pode movê-la ou removê-la conforme necessário.
            this.materiaTableAdapter.Fill(this.appDataSet.materia);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonFecharForm_Click(object sender, EventArgs e)
        {

        }

        private void buttonFecharForm_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Criando conexão com o banco
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "Server=localhost;Database=app;Uid=root;Pwd=root";
            conn.Open();
            if (conn.State != System.Data.ConnectionState.Open)
                conn.Open();

            try
            {
                // Verifica se há campos em branco
                if (comboBox1.Text == "" || textBox1.Text == "" || maskedTextBox1.Text == "" || comboBox2.Text == "" || textBox2.Text == "")
                {
                    MessageBox.Show("Você não pode deixar campos em branco!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Converte a data do formulário de DD/MM/AAAA para AAAA/MM/DD para inserir no banco
                    String dataEntrega = Convert.ToDateTime(maskedTextBox1.Text).ToString("yyyy/MM/dd");

                    // Query para inserir na tabela atividade
                    String query = "INSERT INTO atividade(codigo_materia, titulo_atividade, data_entrega, progresso, descricao)" +
                        "VALUES('" + comboBox1.Text + "', '" + textBox1.Text + "', '" + dataEntrega + "', '" + comboBox2.Text + "', '" + textBox2.Text + "')";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();

                    // Mensagem para confirmar que a query foi executada com sucesso
                    MessageBox.Show("Atividade Adicionada!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Fecha o formulário atual e encerra a conexão
                    this.Close();
                    conn.Close();
                }
            } catch(Exception exc)
            {
                MessageBox.Show("Ocorre um erro: " + exc);
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}

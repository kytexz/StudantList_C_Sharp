using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudantsList
{
    public partial class frmConcluida : Form
    {
        public frmConcluida()
        {
            InitializeComponent();
        }

        private void frmConcluida_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'appDataSet.atividade'. Você pode movê-la ou removê-la conforme necessário.
            this.atividadeTableAdapter.Fill(this.appDataSet.atividade);
            

            // Acesse o Dataset na tabela progresso como DataView
            DataView dv = appDataSet.Tables["atividade"].AsDataView();

            // Aplica RowFilter
            dv.RowFilter = "progresso like 'Concluída'";

            // Atualiza DataSource com a nova DataView
            dataGridView1.DataSource = dv;
            dataGridView1.ClearSelection();
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void buttonFecharForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}

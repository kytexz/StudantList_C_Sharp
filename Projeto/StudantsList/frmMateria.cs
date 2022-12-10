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
    public partial class frmMateria : Form
    {


        public frmMateria()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void buttonFecharForm_Click(object sender, EventArgs e)
        {
            this.Close();           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAdicionarMateria AddMateria = new frmAdicionarMateria();
            AddMateria.Show();
        }

        private void frmMateria_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'appDataSet.materia'. Você pode movê-la ou removê-la conforme necessário.
            this.materiaTableAdapter.Fill(this.appDataSet.materia);
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

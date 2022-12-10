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
    public partial class FrmPrincipal : Form
    {
        private Form formularioAtivo;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void MostrarFormulario(Form formulario)
        {
            FecharFormularioAtivo();
            formularioAtivo = formulario;
            formularioAtivo.TopLevel = false;
            panelForm.Controls.Add(formulario);
            formularioAtivo.BringToFront();
            formularioAtivo.Show();
        }

        private void FecharFormularioAtivo()
        {
            if (formularioAtivo != null)
                formularioAtivo.Close();
        }

        // Função para mudar a cor ao clicar em um botão
        private void AtivarButton(Button ButtonAtivo)
        {
            foreach (Control recebendo in panelPrincipal.Controls)
                recebendo.ForeColor = Color.Black;

            ButtonAtivo.ForeColor = Color.FromArgb(47, 158, 65);

        }

        private void buttonAtividades_Click(object sender, EventArgs e)
        {
            AtivarButton(buttonAtividades);
            FecharFormularioAtivo();
        }

        private void buttonMaterias_Click(object sender, EventArgs e)
        {
            AtivarButton(buttonMaterias);
            MostrarFormulario(new frmMateria());
        }

        private void buttonConcluidas_Click(object sender, EventArgs e)
        {
            AtivarButton(buttonConcluidas);
            MostrarFormulario(new frmConcluida());
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            AtivarButton(buttonSair);
            FecharFormularioAtivo();
            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarFormulario(new frmAdicionarAtividade());         
        }

        private void panelForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.atividadeTableAdapter.Fill(this.appDataSet2.atividade);
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
          
        }
    }
}

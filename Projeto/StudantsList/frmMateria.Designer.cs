
namespace StudantsList
{
    partial class frmMateria
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMateria));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.buttonFecharForm = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.appDataSet = new StudantsList.appDataSet();
            this.materiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materiaTableAdapter = new StudantsList.appDataSetTableAdapters.materiaTableAdapter();
            this.dtFimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeprofessorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomemateriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigomateriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelHeader.SuspendLayout();
            this.panelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelHeader.Controls.Add(this.labelTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(784, 50);
            this.panelHeader.TabIndex = 3;
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTitle.Image = ((System.Drawing.Image)(resources.GetObject("labelTitle.Image")));
            this.labelTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(760, 32);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Cadastrar Matérias";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.panelFooter.Controls.Add(this.buttonFecharForm);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 473);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(784, 53);
            this.panelFooter.TabIndex = 4;
            // 
            // buttonFecharForm
            // 
            this.buttonFecharForm.AutoSize = true;
            this.buttonFecharForm.BackColor = System.Drawing.Color.Black;
            this.buttonFecharForm.FlatAppearance.BorderSize = 0;
            this.buttonFecharForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(158)))), ((int)(((byte)(65)))));
            this.buttonFecharForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFecharForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFecharForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonFecharForm.Location = new System.Drawing.Point(701, 9);
            this.buttonFecharForm.Name = "buttonFecharForm";
            this.buttonFecharForm.Size = new System.Drawing.Size(71, 32);
            this.buttonFecharForm.TabIndex = 0;
            this.buttonFecharForm.Text = "Fechar";
            this.buttonFecharForm.UseVisualStyleBackColor = false;
            this.buttonFecharForm.Click += new System.EventHandler(this.buttonFecharForm_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(15, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 50;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigomateriaDataGridViewTextBoxColumn,
            this.nomemateriaDataGridViewTextBoxColumn,
            this.nomeprofessorDataGridViewTextBoxColumn,
            this.dtInicioDataGridViewTextBoxColumn,
            this.dtFimDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.materiaBindingSource;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(15, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(757, 333);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // appDataSet
            // 
            this.appDataSet.DataSetName = "appDataSet";
            this.appDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materiaBindingSource
            // 
            this.materiaBindingSource.DataMember = "materia";
            this.materiaBindingSource.DataSource = this.appDataSet;
            // 
            // materiaTableAdapter
            // 
            this.materiaTableAdapter.ClearBeforeFill = true;
            // 
            // dtFimDataGridViewTextBoxColumn
            // 
            this.dtFimDataGridViewTextBoxColumn.DataPropertyName = "dtFim";
            this.dtFimDataGridViewTextBoxColumn.HeaderText = "Fim";
            this.dtFimDataGridViewTextBoxColumn.Name = "dtFimDataGridViewTextBoxColumn";
            this.dtFimDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dtInicioDataGridViewTextBoxColumn
            // 
            this.dtInicioDataGridViewTextBoxColumn.DataPropertyName = "dtInicio";
            this.dtInicioDataGridViewTextBoxColumn.HeaderText = "Início";
            this.dtInicioDataGridViewTextBoxColumn.Name = "dtInicioDataGridViewTextBoxColumn";
            this.dtInicioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeprofessorDataGridViewTextBoxColumn
            // 
            this.nomeprofessorDataGridViewTextBoxColumn.DataPropertyName = "nome_professor";
            this.nomeprofessorDataGridViewTextBoxColumn.HeaderText = "Professor";
            this.nomeprofessorDataGridViewTextBoxColumn.Name = "nomeprofessorDataGridViewTextBoxColumn";
            this.nomeprofessorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomemateriaDataGridViewTextBoxColumn
            // 
            this.nomemateriaDataGridViewTextBoxColumn.DataPropertyName = "nome_materia";
            this.nomemateriaDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomemateriaDataGridViewTextBoxColumn.Name = "nomemateriaDataGridViewTextBoxColumn";
            this.nomemateriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codigomateriaDataGridViewTextBoxColumn
            // 
            this.codigomateriaDataGridViewTextBoxColumn.DataPropertyName = "codigo_materia";
            this.codigomateriaDataGridViewTextBoxColumn.HeaderText = "Código Matéria";
            this.codigomateriaDataGridViewTextBoxColumn.Name = "codigomateriaDataGridViewTextBoxColumn";
            this.codigomateriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(784, 526);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMateria";
            this.Text = "frmMaterias";
            this.Load += new System.EventHandler(this.frmMateria_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Button buttonFecharForm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private appDataSet appDataSet;
        private System.Windows.Forms.BindingSource materiaBindingSource;
        private appDataSetTableAdapters.materiaTableAdapter materiaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigomateriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomemateriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeprofessorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtFimDataGridViewTextBoxColumn;
    }
}
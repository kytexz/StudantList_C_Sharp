
namespace StudantsList
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelForm = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.atividadeBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.appDataSet2 = new StudantsList.appDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.appDataSet = new StudantsList.appDataSet();
            this.atividadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.atividadeTableAdapter = new StudantsList.appDataSetTableAdapters.atividadeTableAdapter();
            this.appDataSet1 = new StudantsList.appDataSet();
            this.atividadeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.atividadeBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.atividadeBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonSair = new System.Windows.Forms.Button();
            this.buttonConcluidas = new System.Windows.Forms.Button();
            this.buttonMaterias = new System.Windows.Forms.Button();
            this.buttonAtividades = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.codigomateriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloatividadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataentregaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progressoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.info = new System.Windows.Forms.DataGridViewImageColumn();
            this.excluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelPrincipal.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atividadeBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDataSet2)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atividadeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atividadeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atividadeBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atividadeBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.White;
            this.panelPrincipal.Controls.Add(this.buttonSair);
            this.panelPrincipal.Controls.Add(this.buttonConcluidas);
            this.panelPrincipal.Controls.Add(this.buttonMaterias);
            this.panelPrincipal.Controls.Add(this.buttonAtividades);
            this.panelPrincipal.Controls.Add(this.panelLogo);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(200, 526);
            this.panelPrincipal.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 111);
            this.panelLogo.TabIndex = 0;
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.Transparent;
            this.panelForm.Controls.Add(this.dataGridView1);
            this.panelForm.Controls.Add(this.button1);
            this.panelForm.Controls.Add(this.panelHeader);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(200, 0);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(784, 526);
            this.panelForm.TabIndex = 1;
            this.panelForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelForm_Paint);
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
            this.tituloatividadeDataGridViewTextBoxColumn,
            this.dataentregaDataGridViewTextBoxColumn,
            this.progressoDataGridViewTextBoxColumn,
            this.editar,
            this.info,
            this.excluir});
            this.dataGridView1.DataSource = this.atividadeBindingSource4;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(15, 135);
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
            this.dataGridView1.Size = new System.Drawing.Size(757, 379);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // atividadeBindingSource4
            // 
            this.atividadeBindingSource4.DataMember = "atividade";
            this.atividadeBindingSource4.DataSource = this.appDataSet2;
            // 
            // appDataSet2
            // 
            this.appDataSet2.DataSetName = "appDataSet";
            this.appDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.button1.TabIndex = 5;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelHeader.Controls.Add(this.labelTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(784, 50);
            this.panelHeader.TabIndex = 4;
            // 
            // appDataSet
            // 
            this.appDataSet.DataSetName = "appDataSet";
            this.appDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // atividadeBindingSource
            // 
            this.atividadeBindingSource.DataMember = "atividade";
            this.atividadeBindingSource.DataSource = this.appDataSet;
            // 
            // atividadeTableAdapter
            // 
            this.atividadeTableAdapter.ClearBeforeFill = true;
            // 
            // appDataSet1
            // 
            this.appDataSet1.DataSetName = "appDataSet";
            this.appDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // atividadeBindingSource1
            // 
            this.atividadeBindingSource1.DataMember = "atividade";
            this.atividadeBindingSource1.DataSource = this.appDataSet1;
            // 
            // atividadeBindingSource2
            // 
            this.atividadeBindingSource2.DataMember = "atividade";
            this.atividadeBindingSource2.DataSource = this.appDataSet2;
            // 
            // atividadeBindingSource3
            // 
            this.atividadeBindingSource3.DataMember = "atividade";
            this.atividadeBindingSource3.DataSource = this.appDataSet2;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::StudantsList.Properties.Resources.icons8_pencil_drawing_24;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 30;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::StudantsList.Properties.Resources.icons8_info_241;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 30;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Image = global::StudantsList.Properties.Resources.icons8_excluir_24;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.Width = 30;
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
            this.labelTitle.Text = "Lista de Atividades";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonSair
            // 
            this.buttonSair.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.buttonSair.FlatAppearance.BorderSize = 0;
            this.buttonSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(158)))), ((int)(((byte)(65)))));
            this.buttonSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.buttonSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSair.ForeColor = System.Drawing.Color.Black;
            this.buttonSair.Image = ((System.Drawing.Image)(resources.GetObject("buttonSair.Image")));
            this.buttonSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSair.Location = new System.Drawing.Point(0, 261);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonSair.Size = new System.Drawing.Size(200, 50);
            this.buttonSair.TabIndex = 4;
            this.buttonSair.Text = " Sair  ";
            this.buttonSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // buttonConcluidas
            // 
            this.buttonConcluidas.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonConcluidas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.buttonConcluidas.FlatAppearance.BorderSize = 0;
            this.buttonConcluidas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(158)))), ((int)(((byte)(65)))));
            this.buttonConcluidas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.buttonConcluidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConcluidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConcluidas.ForeColor = System.Drawing.Color.Black;
            this.buttonConcluidas.Image = ((System.Drawing.Image)(resources.GetObject("buttonConcluidas.Image")));
            this.buttonConcluidas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonConcluidas.Location = new System.Drawing.Point(0, 211);
            this.buttonConcluidas.Name = "buttonConcluidas";
            this.buttonConcluidas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonConcluidas.Size = new System.Drawing.Size(200, 50);
            this.buttonConcluidas.TabIndex = 3;
            this.buttonConcluidas.Text = " Concluidas";
            this.buttonConcluidas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonConcluidas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonConcluidas.UseVisualStyleBackColor = true;
            this.buttonConcluidas.Click += new System.EventHandler(this.buttonConcluidas_Click);
            // 
            // buttonMaterias
            // 
            this.buttonMaterias.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMaterias.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.buttonMaterias.FlatAppearance.BorderSize = 0;
            this.buttonMaterias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(158)))), ((int)(((byte)(65)))));
            this.buttonMaterias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.buttonMaterias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMaterias.ForeColor = System.Drawing.Color.Black;
            this.buttonMaterias.Image = ((System.Drawing.Image)(resources.GetObject("buttonMaterias.Image")));
            this.buttonMaterias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMaterias.Location = new System.Drawing.Point(0, 161);
            this.buttonMaterias.Name = "buttonMaterias";
            this.buttonMaterias.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonMaterias.Size = new System.Drawing.Size(200, 50);
            this.buttonMaterias.TabIndex = 2;
            this.buttonMaterias.Text = " Matérias";
            this.buttonMaterias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMaterias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMaterias.UseVisualStyleBackColor = true;
            this.buttonMaterias.Click += new System.EventHandler(this.buttonMaterias_Click);
            // 
            // buttonAtividades
            // 
            this.buttonAtividades.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAtividades.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.buttonAtividades.FlatAppearance.BorderSize = 0;
            this.buttonAtividades.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(158)))), ((int)(((byte)(65)))));
            this.buttonAtividades.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.buttonAtividades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAtividades.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAtividades.ForeColor = System.Drawing.Color.Black;
            this.buttonAtividades.Image = ((System.Drawing.Image)(resources.GetObject("buttonAtividades.Image")));
            this.buttonAtividades.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAtividades.Location = new System.Drawing.Point(0, 111);
            this.buttonAtividades.Name = "buttonAtividades";
            this.buttonAtividades.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonAtividades.Size = new System.Drawing.Size(200, 50);
            this.buttonAtividades.TabIndex = 1;
            this.buttonAtividades.Text = " Atividades";
            this.buttonAtividades.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAtividades.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAtividades.UseVisualStyleBackColor = true;
            this.buttonAtividades.Click += new System.EventHandler(this.buttonAtividades_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // codigomateriaDataGridViewTextBoxColumn
            // 
            this.codigomateriaDataGridViewTextBoxColumn.DataPropertyName = "codigo_materia";
            this.codigomateriaDataGridViewTextBoxColumn.HeaderText = "Matéria";
            this.codigomateriaDataGridViewTextBoxColumn.Name = "codigomateriaDataGridViewTextBoxColumn";
            this.codigomateriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tituloatividadeDataGridViewTextBoxColumn
            // 
            this.tituloatividadeDataGridViewTextBoxColumn.DataPropertyName = "titulo_atividade";
            this.tituloatividadeDataGridViewTextBoxColumn.HeaderText = "Atividade";
            this.tituloatividadeDataGridViewTextBoxColumn.Name = "tituloatividadeDataGridViewTextBoxColumn";
            this.tituloatividadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataentregaDataGridViewTextBoxColumn
            // 
            this.dataentregaDataGridViewTextBoxColumn.DataPropertyName = "data_entrega";
            this.dataentregaDataGridViewTextBoxColumn.HeaderText = "Entrega";
            this.dataentregaDataGridViewTextBoxColumn.Name = "dataentregaDataGridViewTextBoxColumn";
            this.dataentregaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // progressoDataGridViewTextBoxColumn
            // 
            this.progressoDataGridViewTextBoxColumn.DataPropertyName = "progresso";
            this.progressoDataGridViewTextBoxColumn.HeaderText = "Status";
            this.progressoDataGridViewTextBoxColumn.Name = "progressoDataGridViewTextBoxColumn";
            this.progressoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // editar
            // 
            this.editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.editar.HeaderText = "";
            this.editar.Image = global::StudantsList.Properties.Resources.icons8_pencil_drawing_24;
            this.editar.Name = "editar";
            this.editar.ReadOnly = true;
            this.editar.Width = 30;
            // 
            // info
            // 
            this.info.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.info.HeaderText = "";
            this.info.Image = global::StudantsList.Properties.Resources.icons8_info_24;
            this.info.Name = "info";
            this.info.ReadOnly = true;
            this.info.Width = 30;
            // 
            // excluir
            // 
            this.excluir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.excluir.HeaderText = "";
            this.excluir.Image = global::StudantsList.Properties.Resources.icons8_excluir_24;
            this.excluir.Name = "excluir";
            this.excluir.ReadOnly = true;
            this.excluir.Width = 30;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(984, 526);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.panelPrincipal.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atividadeBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDataSet2)).EndInit();
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.appDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atividadeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atividadeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atividadeBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atividadeBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonAtividades;
        private System.Windows.Forms.Button buttonMaterias;
        private System.Windows.Forms.Button buttonConcluidas;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button button1;
        private appDataSet appDataSet;
        private System.Windows.Forms.BindingSource atividadeBindingSource;
        private appDataSetTableAdapters.atividadeTableAdapter atividadeTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private appDataSet appDataSet1;
        private System.Windows.Forms.BindingSource atividadeBindingSource1;
        private appDataSet appDataSet2;
        private System.Windows.Forms.BindingSource atividadeBindingSource2;
        private System.Windows.Forms.BindingSource atividadeBindingSource3;
        private System.Windows.Forms.BindingSource atividadeBindingSource4;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigomateriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloatividadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataentregaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn progressoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn editar;
        private System.Windows.Forms.DataGridViewImageColumn info;
        private System.Windows.Forms.DataGridViewImageColumn excluir;
    }
}


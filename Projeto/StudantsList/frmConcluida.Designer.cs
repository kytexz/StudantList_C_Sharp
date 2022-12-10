
namespace StudantsList
{
    partial class frmConcluida
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.appDataSet = new StudantsList.appDataSet();
            this.atividadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.atividadeTableAdapter = new StudantsList.appDataSetTableAdapters.atividadeTableAdapter();
            this.codigomateriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloatividadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataentregaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progressoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.info = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.buttonFecharForm = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atividadeBindingSource)).BeginInit();
            this.panelFooter.SuspendLayout();
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
            this.panelHeader.TabIndex = 4;
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTitle.Image = global::StudantsList.Properties.Resources.check303Bran;
            this.labelTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(760, 32);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Atividades concluídas";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
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
            this.info});
            this.dataGridView1.DataSource = this.atividadeBindingSource;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(12, 68);
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
            this.dataGridView1.Size = new System.Drawing.Size(757, 384);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // codigomateriaDataGridViewTextBoxColumn
            // 
            this.codigomateriaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.codigomateriaDataGridViewTextBoxColumn.DataPropertyName = "codigo_materia";
            this.codigomateriaDataGridViewTextBoxColumn.HeaderText = "Código Matéria";
            this.codigomateriaDataGridViewTextBoxColumn.Name = "codigomateriaDataGridViewTextBoxColumn";
            this.codigomateriaDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigomateriaDataGridViewTextBoxColumn.Width = 170;
            // 
            // tituloatividadeDataGridViewTextBoxColumn
            // 
            this.tituloatividadeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tituloatividadeDataGridViewTextBoxColumn.DataPropertyName = "titulo_atividade";
            this.tituloatividadeDataGridViewTextBoxColumn.HeaderText = "Atividade";
            this.tituloatividadeDataGridViewTextBoxColumn.Name = "tituloatividadeDataGridViewTextBoxColumn";
            this.tituloatividadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.tituloatividadeDataGridViewTextBoxColumn.Width = 170;
            // 
            // dataentregaDataGridViewTextBoxColumn
            // 
            this.dataentregaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataentregaDataGridViewTextBoxColumn.DataPropertyName = "data_entrega";
            this.dataentregaDataGridViewTextBoxColumn.HeaderText = "Entrega";
            this.dataentregaDataGridViewTextBoxColumn.Name = "dataentregaDataGridViewTextBoxColumn";
            this.dataentregaDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataentregaDataGridViewTextBoxColumn.Width = 170;
            // 
            // progressoDataGridViewTextBoxColumn
            // 
            this.progressoDataGridViewTextBoxColumn.DataPropertyName = "progresso";
            this.progressoDataGridViewTextBoxColumn.HeaderText = "Status";
            this.progressoDataGridViewTextBoxColumn.Name = "progressoDataGridViewTextBoxColumn";
            this.progressoDataGridViewTextBoxColumn.ReadOnly = true;
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
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.panelFooter.Controls.Add(this.buttonFecharForm);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 473);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(784, 53);
            this.panelFooter.TabIndex = 10;
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
            // frmConcluida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 526);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConcluida";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConcluida";
            this.Load += new System.EventHandler(this.frmConcluida_Load);
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atividadeBindingSource)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private appDataSet appDataSet;
        private System.Windows.Forms.BindingSource atividadeBindingSource;
        private appDataSetTableAdapters.atividadeTableAdapter atividadeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigomateriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloatividadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataentregaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn progressoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn info;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Button buttonFecharForm;
    }
}
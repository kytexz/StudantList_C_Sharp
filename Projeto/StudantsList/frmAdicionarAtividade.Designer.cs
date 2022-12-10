
namespace StudantsList
{
    partial class frmAdicionarAtividade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdicionarAtividade));
            this.materiaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.appDataSet = new StudantsList.appDataSet();
            this.materiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materiaTableAdapter = new StudantsList.appDataSetTableAdapters.materiaTableAdapter();
            this.appDataSet1 = new StudantsList.appDataSet();
            this.appDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materiaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonFecharForm = new System.Windows.Forms.Button();
            this.materiaTableAdapter1 = new StudantsList.appDataSetTableAdapters.materiaTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource2)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // materiaBindingSource1
            // 
            this.materiaBindingSource1.DataMember = "materia";
            this.materiaBindingSource1.DataSource = this.appDataSet;
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
            // appDataSet1
            // 
            this.appDataSet1.DataSetName = "appDataSet";
            this.appDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appDataSet1BindingSource
            // 
            this.appDataSet1BindingSource.DataSource = this.appDataSet1;
            this.appDataSet1BindingSource.Position = 0;
            // 
            // materiaBindingSource2
            // 
            this.materiaBindingSource2.DataMember = "materia";
            this.materiaBindingSource2.DataSource = this.appDataSet1;
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
            this.labelTitle.Text = "Adicionar Atividade";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matéria:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Atividade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data de Entrega:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(436, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(84, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Descrição:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(189, 148);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(468, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(189, 274);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(468, 158);
            this.textBox2.TabIndex = 9;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(190, 207);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 10;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.materiaBindingSource1;
            this.comboBox1.DisplayMember = "codigo_materia";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(189, 83);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(175, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.panelFooter.Controls.Add(this.button1);
            this.panelFooter.Controls.Add(this.buttonFecharForm);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 473);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(784, 53);
            this.panelFooter.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(158)))), ((int)(((byte)(65)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(698, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonFecharForm
            // 
            this.buttonFecharForm.AutoSize = true;
            this.buttonFecharForm.BackColor = System.Drawing.Color.Black;
            this.buttonFecharForm.FlatAppearance.BorderSize = 0;
            this.buttonFecharForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.buttonFecharForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFecharForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFecharForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonFecharForm.Location = new System.Drawing.Point(605, 9);
            this.buttonFecharForm.Name = "buttonFecharForm";
            this.buttonFecharForm.Size = new System.Drawing.Size(74, 32);
            this.buttonFecharForm.TabIndex = 0;
            this.buttonFecharForm.Text = "Cancelar";
            this.buttonFecharForm.UseVisualStyleBackColor = false;
            this.buttonFecharForm.Click += new System.EventHandler(this.buttonFecharForm_Click_1);
            // 
            // materiaTableAdapter1
            // 
            this.materiaTableAdapter1.ClearBeforeFill = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Concluída",
            "Em Progresso",
            "Para Fazer"});
            this.comboBox2.Location = new System.Drawing.Point(506, 210);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(151, 21);
            this.comboBox2.TabIndex = 13;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // frmAdicionarAtividade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(784, 526);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "frmAdicionarAtividade";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formAdicionarTarefa";
            this.Load += new System.EventHandler(this.formAdicionarTarefa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource2)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource materiaBindingSource;
        private System.Windows.Forms.BindingSource materiaBindingSource1;
        private System.Windows.Forms.BindingSource appDataSet1BindingSource;
        private System.Windows.Forms.BindingSource materiaBindingSource2;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Button buttonFecharForm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox2;
        private StudantsList.appDataSet appDataSet;
        private StudantsList.appDataSetTableAdapters.materiaTableAdapter materiaTableAdapter;
        private StudantsList.appDataSet appDataSet1;
        private StudantsList.appDataSetTableAdapters.materiaTableAdapter materiaTableAdapter1;
    }
}
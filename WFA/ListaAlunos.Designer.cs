namespace WFA
{
    partial class ListaAlunos
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NomeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TurmaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TurnoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.IdadeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeColumn,
            this.TurmaColumn,
            this.TurnoColumn,
            this.IdadeColumn,
            this.CodigoColumn});
            this.dataGridView1.Location = new System.Drawing.Point(12, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(638, 419);
            this.dataGridView1.TabIndex = 0;
            // 
            // NomeColumn
            // 
            this.NomeColumn.HeaderText = "Nome";
            this.NomeColumn.Name = "NomeColumn";
            this.NomeColumn.ReadOnly = true;
            // 
            // TurmaColumn
            // 
            this.TurmaColumn.HeaderText = "Turma";
            this.TurmaColumn.Name = "TurmaColumn";
            this.TurmaColumn.ReadOnly = true;
            // 
            // TurnoColumn
            // 
            this.TurnoColumn.HeaderText = "Turno";
            this.TurnoColumn.Name = "TurnoColumn";
            this.TurnoColumn.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Apagar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(226, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(123, 23);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 37);
            this.button3.TabIndex = 3;
            this.button3.Text = "Novo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // IdadeColumn
            // 
            this.IdadeColumn.HeaderText = "Idade";
            this.IdadeColumn.Name = "IdadeColumn";
            this.IdadeColumn.ReadOnly = true;
            // 
            // CodigoColumn
            // 
            this.CodigoColumn.HeaderText = "Codigo";
            this.CodigoColumn.Name = "CodigoColumn";
            this.CodigoColumn.ReadOnly = true;
            // 
            // ListaAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 516);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListaAlunos";
            this.Text = "ListaAlunos";
            this.Activated += new System.EventHandler(this.ListaAlunos_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TurmaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TurnoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdadeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoColumn;
    }
}
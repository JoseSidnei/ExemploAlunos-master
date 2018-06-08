using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA
{
    public partial class ListaAlunos : Form
    {
        public ListaAlunos()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            new CadastroAluno().ShowDialog();
        }

        private void ListaAlunos_Activated(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < Program.alunos.Count(); i++)
			{
                Aluno aluno = Program.alunos[i];
                dataGridView1.Rows.Add(new Object[] {
                    aluno.GetCodigo(),
                    aluno.GetNome(),
                    aluno.GetTurma(),
                    aluno.GetTurno()
                });


			}  
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selicione um registro para que seja possivel editar");
                return;
            }

            int codigo = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            new CadastroAluno(codigo).ShowDialog();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selecione um registro para que seja possivel apagar");
                return;
            }

            int codigo = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());

            for (int i = 0; i < Program.alunos.Count(); i++)
            {
                Aluno aluno = Program.alunos[i];
                if (aluno.GetCodigo() == codigo)
                {
                    Program.alunos.Remove(aluno);
                    return;
                }
            }
        }
    }
}

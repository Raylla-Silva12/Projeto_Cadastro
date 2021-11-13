using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCadastro
{
    public partial class frmPesquisaUsuario : Form
    {
        private int codigo;

        public frmPesquisaUsuario()
        {
            InitializeComponent();
        }

        public int getCodigo()
        {
            return codigo;
        }

        private void frmPesquisaUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastroDataSet.tbusuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tbusuarioTableAdapter.Fill(this.cadastroDataSet.tbusuario);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            codigo = 0;
            Close();
        }

        private void tbusuarioDataGridView_DoubleClick(object sender, EventArgs e)
        {
            codigo = Convert.ToInt32(tbusuarioDataGridView.CurrentRow.Cells[0].Value);
            Close();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                this.tbusuarioTableAdapter.Fill(this.cadastroDataSet.tbusuario);
            }
            else
            {
                this.tbusuarioTableAdapter.FillByNome(this.cadastroDataSet.tbusuario, "%" + txtNome.Text + "%");
            }
        }
    }
}

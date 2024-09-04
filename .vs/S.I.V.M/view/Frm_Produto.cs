using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S.I.V.M.view
{
    public partial class Frm_Produto : Form
    {
        public Frm_Produto()
        {
            InitializeComponent();
        }

        private void Frm_Produto_Load(object sender, EventArgs e)
        {
            dtgProduto.DataSource = bindingSource;
        }

        private void dtgProduto_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indiceColuna = e.ColumnIndex;
            lblPesquisa.Text = dtgProduto.Columns[indiceColuna].HeaderText;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

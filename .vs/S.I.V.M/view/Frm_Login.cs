using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S.I.V.M
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void lbl_Senha_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contate o administrador do sistema para alterar sua senha!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCaoncelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            view.Frm_Home home = new view.Frm_Home();
            home.Show();
            //this.Dispose();
        }
    }
}

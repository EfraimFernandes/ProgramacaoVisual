using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramacaoVisual
{
    public partial class CriacaoFuncoes : Form
    {
        int verificaMaior(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1;
            } 
            else if (num1 == num2)
            {
                return 0;
            }
            else
            {
                return num2;
            }
        }

        public CriacaoFuncoes()
        {
            InitializeComponent();
        }

        private void CriacaoFuncoes_Load(object sender, EventArgs e)
        {

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int a, b;

            a = Convert.ToInt32(txtA.Text);
            b = Convert.ToInt32(txtB.Text);

            txtMaior.Text = verificaMaior(a, b).ToString();
        }

        void limparControles()
        {
            txtA.Clear();
            txtB.Clear();
            txtMaior.Clear();
            txtA.Focus();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparControles();
        }
    }
}

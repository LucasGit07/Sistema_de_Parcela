using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeuSistema
{
    public partial class form1 : Form
    {
        //modificador//tipo//nome//
       public float valor1;
       public float valor2;
       public float res;
        public form1()
        {
            InitializeComponent();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

      

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void form1_Load(object sender, EventArgs e)
        {

        }

        private void Btnresultado_Click(object sender, EventArgs e)
        {
            valor1 = float.Parse(txtParc1.Text);
            valor2 = float.Parse(textParc2.Text);
            //+,-;*,/,%
            res = valor1 * valor2;
            txtRes.Text = Convert.ToString(res);
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
           
        }

        private void txtRes_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

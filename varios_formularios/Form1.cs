using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace varios_formularios
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textinserir1.Text == "")
            {
                MessageBox.Show("por favor insira um nome no campo!!!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textinserir1.Focus();
                return;
            }
            else
            {
                txtmulti.Text += textinserir1.Text + ",";
                textinserir1.Clear();
                textinserir1.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textinserir1.Focus();
            textinserir1.Clear();
            txtmulti.Clear();

        }

        private void bntform_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2 (txtmulti.Text);
          form2.ShowDialog();
        }
    }
}

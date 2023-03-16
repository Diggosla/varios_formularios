using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace varios_formularios
{
    public partial class Form2 : Form
    {
        public Form2(string v)
        {
            InitializeComponent();
            textBoxMultiTexto.Text = v ;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
         
        }
    }
}

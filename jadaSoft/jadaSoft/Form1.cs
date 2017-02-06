using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jadaSoft
{

   
    public partial class Form1 : Form
    {

     


        public Form1()
        {
            InitializeComponent();
        }

        private void oToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btoRegistre_Click(object sender, EventArgs e)
        {
             
        }

        private void btoOk_Click(object sender, EventArgs e)
        {
            FWorking tv = new FWorking();
            tv.Show();
           

        }
    }
}

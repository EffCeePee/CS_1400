using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        // a class level reference to a token machine
        private MyTokenMachine tm; 

        public Form1()
        {
            InitializeComponent();

            // create a token machine object
            tm = new MyTokenMachine();
            tm.Reset();

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Franklin Colton Parry \nCS1400\nLab #20");
        }
    }
}

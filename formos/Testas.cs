using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace formos
{
    public partial class Testas : Form
    {
        public Testas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TestoTemos f = new TestoTemos();
            f.Left = this.Left;
            f.Top = this.Top;
            f.Show();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

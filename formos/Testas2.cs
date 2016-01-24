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
    public partial class Testas2 : Form
    {
        List<Klausimas> klausimai;
 
        public Testas2(List<Klausimas> sarasas)
        {
            InitializeComponent();
            klausimai = sarasas;
        }

        private void JAVtestas_Load(object sender, EventArgs e)
        {

        }
        void loadquestion(int kurkl) 
       {
           Klausimas kl = klausimai[kurkl];
           atsButton1.Text = kl.ats1;
           atsButton2.Text = kl.ats2;
           atsButton3.Text = kl.ats3;
           atsButton4.Text = kl.ats4;
       }
    }

}


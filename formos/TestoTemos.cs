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
    public partial class TestoTemos : Form
    {
        public TestoTemos()
        {
            InitializeComponent();
        }

        private void JAVbutton_Click(object sender, EventArgs e)
        {
            List<Klausimas> j = new List<Klausimas>();
            Klausimas kl = new Klausimas();
            kl.klausimas = "Kada buvo pasirašyta JAV nepriklausomybės deklaracija?";
            kl.ats1 = "1776 m.";
            kl.ats2 = "1783 m.";
            kl.ats3 = "1885 m.";
            kl.ats4 = "1914 m.";
            j.Add(kl);

            Klausimas kl2 = new Klausimas();
            kl2.klausimas = "Kas vadovavo JAV kariuomenei revoliucijos metu?";
            kl2.ats1 = "Džordžas Bušas";
            kl2.ats2 = "Siedintis Jautis";
            kl2.ats3 = "Tomas Džeffersonas";
            kl2.ats4 = "Džordžas Vašingtonas";
            j.Add(kl2);

            Klausimas kl3 = new Klausimas();
            kl3.klausimas = "Kaip vadinosi JAV čiabuviai?";
            kl3.ats1 = "Indėnai";
            kl3.ats2 = "Arabai";
            kl3.ats3 = "Aborigenai";
            kl3.ats4 = "Negrai";

            Testas2 f = new Testas2(j);
            f.Left = this.Left;
            f.Top = this.Top;
            f.Show();
        }

        private void OSMbutton_Click(object sender, EventArgs e)
        {
            List<Klausimas> o = new List<Klausimas>();
            Klausimas kl = new Klausimas();
            kl.klausimas = "Kiek metų Osmanų Imperijai vadovavo sultonas Sulejmanas Didysis?";
            kl.ats1 = "50 m.";
            kl.ats2 = "62 m.";
            kl.ats3 = "46 m.";
            kl.ats4 = "75 m.";
            o.Add(kl);

            Testas2 f = new Testas2(o);
            f.Left = this.Left;
            f.Top = this.Top;
            f.Show();
        }

        private void WWIIbutton_Click(object sender, EventArgs e)
        {
            List<Klausimas> w = new List<Klausimas>();
            Klausimas kl = new Klausimas();
            kl.klausimas = "Kada prasidėjo Antrasis Pasaulinis karas?";
            kl.ats1 = "1920 m.";
            kl.ats2 = "1939 m.";
            kl.ats3 = "1945 m.";
            kl.ats4 = "1918 m.";
            w.Add(kl);

            Testas2 f = new Testas2(w);
            f.Left = this.Left;
            f.Top = this.Top;
            f.Show();
        }

        private void TestoTemos_Load(object sender, EventArgs e)
        {

        }
    }
}

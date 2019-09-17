using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GraLib;

namespace GraGUI
{
    public partial class Form1 : Form
    {
        private ModelGry gra;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonNowaGra_Click(object sender, EventArgs e)
        {
            groupboxLosowanie.Visible = true;
            buttonNowaGra.Enabled = false;
            buttonPoddaj.Visible = true;
        }

        private void buttonPoddaj_Click(object sender, EventArgs e)
        {
            buttonPoddaj.Visible = false;
            buttonNowaGra.Enabled = true;
        }

        private void buttonLosuj_Click(object sender, EventArgs e)
        {
            int x;
            try
            {
                x = int.Parse(textboxOd.Text);
                
            }
            catch (FormatException)
            {
                textboxOd.BackColor = Color.Red;
                return;
            }
            textboxOd.BackColor = Color.White;

            int y = int.Parse(textboxDo.Text);
        
            groupboxLosowanie.Enabled = false;
            groupBoxOdgadywanie.Visible = true;
            

            gra = new ModelGry(x, y);
            
        }

        private void textboxDo_TextChanged(object sender, EventArgs e)
        {
            int wynik;
            if (int.TryParse(textboxDo.Text, out wynik))
                textboxDo.BackColor = Color.LightGreen;
            else
                textboxDo.BackColor = Color.LightPink;
        }
    }
}

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
            buttonLosuj.Enabled = false;
            groupBoxStatystyki.Visible = false;
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
            statystyki();
        }

        private void buttonLosuj_Click(object sender, EventArgs e)
        {
            int x, y;
            try
            {
                x = int.Parse(textboxOd.Text);
                y = int.Parse(textboxDo.Text);
            }
            catch (FormatException)
            {
                textboxOd.BackColor = Color.Red;
                return;
            }
            textboxOd.BackColor = textboxDo.BackColor = Color.White;

            groupboxLosowanie.Enabled = false;
            groupBoxOdgadywanie.Visible = true;

            gra = new ModelGry(x, y);

        }
        
        
        private bool blokada()
        {
            int wynik1, wynik2;
            if (int.TryParse(textboxDo.Text, out wynik1)
                &&
                int.TryParse(textboxOd.Text, out wynik2))
                return true;
            else
                return false;

        }
       

        private void textboxDo_TextChanged(object sender, EventArgs e)
        {
            
            int wynik;
            if (int.TryParse(textboxDo.Text, out wynik))
            {
                textboxDo.BackColor = Color.LightGreen;
                
            }
            else
            {
                textboxDo.BackColor = Color.LightPink;
               
            }
            buttonLosuj.Enabled = blokada();
           
        }



        private void textboxOd_TextChanged(object sender, EventArgs e)
        {

            int wynik;
            if (int.TryParse(textboxOd.Text, out wynik))
            {
                textboxOd.BackColor = Color.LightGreen;

            }
            else
            {
                textboxOd.BackColor = Color.LightPink;

            }

            buttonLosuj.Enabled = blokada();
             
        }

        private void statystyki()
        {
            groupBoxStatystyki.Visible = true;
            labelLiczbaRuchow.Text = $"Liczba ruchów = {gra.Historia.Count}";
            TimeSpan czas = gra.Historia[gra.Historia.Count - 1].Czas - gra.Historia[0].Czas;
            //  ^ odejmujemy od ostatniego czasu czas początkowy ^ 
            labelCzasGry.Text = $"Czas gry = {czas}";
        }

        private void buttonWyslij_Click(object sender, EventArgs e)
        {
            int propozycja = int.Parse(textBoxPropozycja.Text);
            var odpowiedz= gra.Ocena(propozycja);
            switch (odpowiedz)
            {
                case ModelGry.Odp.ZaMalo:
                    labelOcena.Text = "Za mało";
                    labelOcena.ForeColor = Color.Red;
                    break;
                case ModelGry.Odp.Trafione:
                    labelOcena.Text = "Trafione!";
                    labelOcena.ForeColor = Color.Green;
                    buttonWyslij.Enabled = false;
                    groupBoxStatystyki.Visible = true;
                    statystyki();
                    break;
                case ModelGry.Odp.ZaDuzo:
                    labelOcena.Text = "Za dużo";
                    labelOcena.ForeColor = Color.Red;
                    break;
                default:
                    break;
            }
        }
    }
}

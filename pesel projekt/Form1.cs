using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pesel_projekt.Model;


namespace pesel_projekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Sprawdz_Click(object sender, EventArgs e)
        {
            try
            {
                Pesel pesel = new Pesel(textBox1.Text);
                plec.Text = @"Płeć: " + pesel.Plec;

                data_urodzenia.Text = @"Data urodzenia:  " + pesel.DzienData +"." +pesel.MiesiacData +"."+ pesel.DataData;




            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, @"Błąd");


            }

            string peselNapis = textBox1.Text;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                Sprawdz.PerformClick();

            }



        }

        private void buttonEnter(object sender, KeyEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

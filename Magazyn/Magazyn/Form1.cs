using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazyn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            label2.Text = "Kliknij ponownie na guzik\naby rozpoczac test.";
            label3.Text = "Koniec Czasu";
            button1.Text = "Kliknij tutaj aby rozpoczac!";
            label4.Text = label4.Text + "\n" + wynik + ". " + klik / 10 + " CPS";
            if(klik/10 > naj)
            {
                naj = klik / 10;
                label5.Text = "Najlepszy wynik: \n" + naj + " CPS";
                MessageBox.Show("Udalo ci pobic rekord!!!\nNowy wynik: " + klik / 10 + " CPS");
            }
            else
            {
                MessageBox.Show("Udalo ci sie uzyskac: " + klik / 10 + " CPS");
            }
            wynik++;
            klik = 0;
            czas = 10;
        }
        float klik = 0;
        int czas = 10;
        int wynik = 1;
        float naj = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            klik = klik + 1;
            label2.Text = "Klikniecia: " + klik.ToString();
            button1.Text = "Klik!";
            timer1.Start();
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            czas = czas - 1;
            label3.Text = "Pozostalo: " + czas + "s";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

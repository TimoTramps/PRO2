using System.Collections;
using static System.Net.Mime.MediaTypeNames;

namespace TestiranjeArrayLista
{
    public partial class Form1 : Form
    {
        ArrayList a = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            a.Add(txtVnesi.Text);
            txtKonzola.Text = "Dodan element v seznam " + txtVnesi.Text;
        }

        private void btnIzpisi_Click(object sender, EventArgs e)
        {
            //dolžina seznama je lastnost Count

            string rezultat = "";
            for (int k = 0; k < a.Count; k++)
                rezultat += a[k] + "\r\n";
            txtKonzola.Text = rezultat;

        }

        private void btnStatistika_Click(object sender, EventArgs e)
        {
            txtKonzola.Text = "Dolžina seznama " + a.Count + "\r\n" + "Kapaciteta seznama " + a.Capacity;
        }

        private void btnPrvi_Click(object sender, EventArgs e)
        {
            txtKonzola.Text = "Prvi element seznama je " + a[0];
        }

        private void btnZadnji_Click(object sender, EventArgs e)
        {
            int cap = a.Count - 1;
            txtKonzola.Text = "Zadnji element seznama je " + a[cap];
        }

        private void btnOdstrani_Click(object sender, EventArgs e)
        {
            string text = txtVnesi.Text;

            a.Remove(text);
            txtKonzola.Text = "Odstranjeno - " + text;
        }

        private void btnPrazna_Click(object sender, EventArgs e)
        {
            if (a.Count == 0)
                txtKonzola.Text = "Array JE prazen.";
            else
                txtKonzola.Text = "Array NI prazen.";
        }

        private void btnTrim_Click(object sender, EventArgs e)
        {
            a.TrimToSize();
            txtKonzola.Text = "Zmanjšana kapaciteta";
        }

        private void btnVsebuje_Click(object sender, EventArgs e)
        {
            string text = txtVnesi.Text;

            if(a.Contains(text);
        }
    }
}

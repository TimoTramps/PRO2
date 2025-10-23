using System.Collections;
using System.Collections.Generic;

namespace TestSklad
{
    public partial class Form1 : Form
    {
        Stack<string> s = new Stack<string>();
        string k = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            k = txtVnos.Text;
            s.Push(k);
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            if (s.Count > 0)
                lblStatus.Text += s.Pop() + " ";
            else
                lblStatus.Text = "Sklad je prazen!";
        }


        private void btnPeek_Click(object sender, EventArgs e)
        {
            lblStatus.Text = s.Peek();
        }

       

        private void btnPrazen_Click(object sender, EventArgs e)
        {
            if (s.Count == 0)
                lblStatus.Text = "Je prazen";
            else
                lblStatus.Text = "Ni prazen";
        }

        

        private void btnIšèi_Click(object sender, EventArgs e)
        {
            if (s.Contains(txtVnos.Text))
                lblStatus.Text = "Sklad vsebuje " + txtVnos.Text;
            else
                lblStatus.Text = "Sklad ne vsebuje " + txtVnos.Text;
        }

        private void btnIzpis_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "";

            while (s.Count > 0)
            {
                lblStatus.Text = string.Join(", ", s.ToArray());

            }
        }
    }
}

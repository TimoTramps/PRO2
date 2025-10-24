using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace IgraSKartami
{

    public partial class Form1 : Form
    {
        Random r = new Random();
        Kup kup1;
        Kup kup2;
        public Form1()
        {
            InitializeComponent();
        }

        private void RedrawKupa(int št)
        {
            if (št == 1)
            {
                lstNak.Items.Clear();
                foreach (string im in kup1.ImenaKart())
                {
                    lstNak.Items.Add(im);
                }
                label1.Text = "Kup #1 (" + kup1.Count + " kart)";
            }
            else
            {
                lstCel.Items.Clear();
                foreach (string im in kup2.ImenaKart())
                {
                    lstCel.Items.Add(im);
                }
                label2.Text = "Kup #2 (" + kup2.Count + " kart)";
            }
        }


        private void btnPonastavi1_Click(object sender, EventArgs e)
        {
            //koliko kart prikažem hmm
            int štKart = r.Next(1, 11);
            Kup[] prazen = { };
            kup1 = new Kup(new Karta[] { }); //kup 1 = prazen

            for (int k = 0; k < štKart; k++)
            {
                kup1.Add(
                    new Karta((Barve)r.Next(4),
                    (Vrednosti)r.Next(1, 14)
                ));
            }

            kup1.Sort();
            lstNak.Items.Clear();
            for (int k = 0; k < kup1.Count; k++)
            {
                lstNak.Items.Add(kup1.ImenaKart()[k]);
            }
        }

        private void btnPonastavi2_Click(object sender, EventArgs e)
        {
            int štKart = r.Next(1, 11);
            Kup[] prazen = { };
            kup2 = new Kup(new Karta[] { });

            for (int k = 0; k < štKart; k++)
            {
                kup2.Add(
                    new Karta((Barve)r.Next(4),
                    (Vrednosti)r.Next(1, 14)
                ));
            }

            kup2.Sort();
            lstCel.Items.Clear();
            for (int k = 0; k < kup2.Count; k++)
            {
                lstCel.Items.Add(kup2.ImenaKart()[k]);
            }
        }

        private void btnMesaj1_Click(object sender, EventArgs e)
        {
            kup1.Mešaj();
            RedrawKupa(1);

        }

        private void btnMesaj2_Click(object sender, EventArgs e)
        {

        }



        //private void button1_Click(object sender, EventArgs e)
        //{
        //    string rez = "";
        //    List<Karta> kup = new List<Karta>();
        //    for(int k=0; k<5; k++)
        //    {
        //        Karta nakljuèna = 
        //            new Karta((Barve)r.Next(4), (Vrednosti)r.Next(1, 14));
        //        kup.Add(nakljuèna);
        //        rez += nakljuèna.Ime + Environment.NewLine;
        //    }
        //    kup.Sort(new Primerjava());
        //    rez += Environment.NewLine + "Urejen kup" + Environment.NewLine;
        //    for (int k = 0; k < 5; k++) 
        //    {
        //        rez += kup[k].Ime + Environment.NewLine;
        //    }

        //    MessageBox.Show(rez);
        //}
    }
}

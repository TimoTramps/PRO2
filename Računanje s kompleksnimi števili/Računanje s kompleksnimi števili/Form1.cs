namespace Računanje_s_kompleksnimi_števili
{
    public partial class Form1 : Form
    {
        Kompleksno prvo;
        Kompleksno drugo;
        Kompleksno rezultat;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            double a1 = double.Parse(prvoR.Text);
            double b1 = double.Parse(prvoI.Text);

            double a2 = double.Parse(drugoR.Text);
            double b2 = double.Parse(drugoI.Text);

            prvo = new Kompleksno(a1, b1);
            drugo = new Kompleksno(a2, b2);
            rezultat = prvo + drugo;

            string r = "" + rezultat + "";

            textRezultat.Text = r;

        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            double a1 = double.Parse(prvoR.Text);
            double b1 = double.Parse(prvoI.Text);

            double a2 = double.Parse(drugoR.Text);
            double b2 = double.Parse(drugoI.Text);

            prvo = new Kompleksno(a1, b1);
            drugo = new Kompleksno(a2, b2);
            rezultat = prvo - drugo;

            string r = "" + rezultat + "";

            textRezultat.Text = r;
        }

        private void buttonTimes_Click(object sender, EventArgs e)
        {
            double a1 = double.Parse(prvoR.Text);
            double b1 = double.Parse(prvoI.Text);

            double a2 = double.Parse(drugoR.Text);
            double b2 = double.Parse(drugoI.Text);

            prvo = new Kompleksno(a1, b1);
            drugo = new Kompleksno(a2, b2);
            rezultat = prvo * drugo;

            string r = "" + rezultat + "";

            textRezultat.Text = r;
        }
    }
}

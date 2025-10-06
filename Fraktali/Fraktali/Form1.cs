namespace Fraktali
{
    public partial class Form1 : Form
    {
        //želva ima pozicijo in smer, kodi po kvadratu 1,1

        private double x;
        private double y;
        private double a; //kot pomikanja glede na os X

        private int UmeriX(double xr)
        {
            return (int)Math.Round(xr * pictureBox1.Width);
        }

        private int UmeriY(double yr)
        {
            return (int)Math.Round(pictureBox1.Height - yr * pictureBox1.Height);
        }

        public void ObratLevo(double kot)
        {
            a += kot;
        }

        public void Premik(double d, Graphics g)
        {
            double xstar = x;
            double ystar = y;

            x = d * Math.Cos(a * Math.PI / 180) + xstar;
            y = d * Math.Sin(a * Math.PI / 180) + ystar;
            Pen p = new Pen(Color.Black);
            g.DrawLine(p, UmeriX(xstar), UmeriY(ystar), UmeriX(x), UmeriY(y));
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            x = 0.3; y = 0; a = 30;

            Premik(0.3, g);
            ObratLevo(60);
            Premik(0.3, g);
            ObratLevo(60);
            Premik(0.3, g);
            ObratLevo(60);
            Premik(0.3, g);
            ObratLevo(60);
            Premik(0.3, g);
            ObratLevo(60);
            Premik(0.3, g);
        }
    }
}

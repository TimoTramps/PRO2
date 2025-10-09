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
        public void Koch(int n, double korak, Graphics g)
        {
            if (n == 0)
            {
                Premik(korak, g);
                return;
            }
            Koch(n - 1, korak, g);
            ObratLevo(60);
            Koch(n - 1, korak, g);
            ObratLevo(-120);
            Koch(n - 1, korak, g);
            ObratLevo(60);
            Koch(n - 1, korak, g);
        }

        

        public void FraktalnoDrevo(int n, double x, double y, double a, double korak, Graphics g)
        {
            double cx = x + Math.Cos(a * Math.PI / 180) * korak;
            double cy = y + Math.Sin(a * Math.PI / 180) * korak;
            g.DrawLine(new Pen(Color.Black), UmeriX(x), UmeriY(y), UmeriX(cx), UmeriY(cy));

            if (n == 0)
            {
                //Premik(korak, g);
                return;
            }

            FraktalnoDrevo(n - 1, cx, cy, a + 45, korak * 0.65, g);
            FraktalnoDrevo(n - 1, cx, cy, a, korak * (1-0.65), g);
            FraktalnoDrevo(n - 1, cx, cy, a - 45, korak * 0.65, g);
        }



        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            //KOCH
            //x = 0.2; y = 0.7;a = 0;
            //int n = 6;
            //double korak = 1 / Math.Pow(3.25, n);
            //Koch(n, korak, g);

            //a = -120;
            //Koch(n, korak, g);
            //a = -240;
            //Koch(n, korak, g);

            //FRAKTALNO DREVO
            x = 0.5;y = 0;
            a = 90;

            int n = 10; // globina rekurzije, veèja = bolj kompleksno drevo
            double korak = 1 / Math.Pow(1.15, n);
            FraktalnoDrevo(n, x, y, a, korak, g);
        }
    }
}

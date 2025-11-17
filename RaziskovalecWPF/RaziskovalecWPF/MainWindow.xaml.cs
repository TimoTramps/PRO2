using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RaziskovalecWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window{
        public MainWindow(){
            InitializeComponent();

            //Imena koren = new Imena() { Ime = "A" };
            //Imena otrok = new Imena() { Ime = "o1" };
            //otrok.Elementi.Add(new Imena() { Ime = "o1.1" });
            //otrok.Elementi.Add(new Imena() { Ime = "o1.2" });
            //koren.Elementi.Add(otrok);
            //koren.Elementi.Add(new Imena() { Ime = "o2" });
            //trvDrevo.Items.Add(koren);

            Imena koren = new Imena() { Ime = @"C:\pro2" };
            NapolniVeje(@"C:\pro2", koren);
            IzpišiDatoteke(@"C:\pro2", koren);
            trvDrevo.Items.Add(koren);
        }

        private void NapolniVeje(string ime, Imena x){
            try{
                string[] mape = Directory.GetDirectories(ime);
                if (mape.Length != 0){
                    foreach(string imeMape in mape) {
                        DirectoryInfo d = new DirectoryInfo(imeMape);
                        string brezPoti = d.Name;
                        Imena mojV = new Imena() { Ime = brezPoti };
                        IzpišiDatoteke(imeMape, mojV);
                        NapolniVeje(imeMape, mojV);
                        x.Elementi.Add(mojV);
                    }
                }

            }catch(Exception y){

            }
        }

        private void IzpišiDatoteke(string imeMape, Imena mojV){
            DirectoryInfo d = new DirectoryInfo(imeMape);
            foreach(FileInfo f in d.GetFiles())
            {
                mojV.Elementi.Add(new Imena() { Ime = f.Name });
            }
        }
    }
}
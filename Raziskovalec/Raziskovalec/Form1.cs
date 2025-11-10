namespace Raziskovalec
{

    enum Tip { Datoteka, Mapa}
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NaložiDrevo();
        }

        private void NaložiDrevo()
        {
            trvDrevo.Nodes.Clear();
            foreach (string imeD in Directory.GetLogicalDrives())
            {
                TreeNode vozel = trvDrevo.Nodes.Add(imeD);
                vozel.Nodes.Add("Dummy");
            }
        }

        private void trvDrevo_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            try
            {
                e.Node.Nodes.Clear();
                DodajMape(e.Node);
                DodajDatoteke(e.Node);
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Napaka");
            }
        }

        private void DodajMape(TreeNode node)
        {
            string pot = node.FullPath;
            foreach (string imeM in Directory.GetDirectories(pot))
            {
                TreeNode novi = node.Nodes.Add(Path.GetFileName(imeM));
                novi.Tag = Tip.Mapa;
                novi.Nodes.Add("Dummy");
            }
        }

        private void DodajDatoteke(TreeNode node)
        {
            string pot = node.FullPath;
            foreach (string imeD in Directory.GetFiles(pot))
            {
                TreeNode novi = node.Nodes.Add(Path.GetFileName(imeD));
                novi.Tag = Tip.Datoteka;
                node.Nodes.Add(Path.GetFileName(imeD));
            }
        }

        private void trvDrevo_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag is Tip)
            {
                switch ((Tip)e.Node.Tag)
                {
                    case Tip.Datoteka:
                        FileInfo f = new FileInfo(e.Node.FullPath);
                        txtA.Text = "Datoteka";
                        txtUstvarjena.Text = f.CreationTime.ToShortDateString();
                        break;
                    case Tip.Mapa:
                        DirectoryInfo d = new DirectoryInfo(e.Node.FullPath);
                        txtA.Text = "Mapa";
                        txtUstvarjena.Text = d.CreationTime.ToShortDateString();
                        break;
                }
            }
    }
}

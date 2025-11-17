using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaziskovalecWPF
{
    internal class Imena
    {
        public string Ime { get; set; }

        public ObservableCollection<Imena> Elementi { get; set; }

        public Imena()
        {
            Elementi = new ObservableCollection<Imena>();
        }
    }
}

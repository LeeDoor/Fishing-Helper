using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fishing_Helper.Model;
using Fishing_Helper.Model.Db_configurations;
using Prism;

namespace Fishing_Helper.ViewModel
{
    public class FishViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private List<Fish> fishes;
        public List<Fish> Fishes
        {
            get { return fishes; }
            set
            {
                fishes = value;
                NotifyPropertyChanged(nameof(Fishes));
            }
        }

        public FishViewModel()
        {
            //Fishes = FishDataBase.Fishes.Select(n => n.Variations[0]).ToList();
        }

        private void NotifyPropertyChanged(string v)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(v));
        }
    }
}

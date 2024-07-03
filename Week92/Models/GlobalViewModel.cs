using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week92.Models
{
    public class GlobalViewModel : INotifyPropertyChanged
    {
        private double _total;

        public double Total
        {
            get { return _total; }
            set
            {
                if (_total != value)
                {
                    _total = value;
                    OnPropertyChanged(nameof(Total));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // Singleton pattern
        private static GlobalViewModel _instance;
        public static GlobalViewModel Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new GlobalViewModel();
                return _instance;
            }
        }
    }
}

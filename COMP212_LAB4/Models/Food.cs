using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP212_LAB4.Models
{
    class Food : INotifyPropertyChanged
    {
        public string Item { get; set; }
        public double Price { get; set; }
        private int quantity;
        public double TotalPrice { get{ return Price * Quantity; } }
        public int Quantity {
            get {
                return quantity;
            }
            set {
                quantity = value;
                OnPropertyChanged("TotalPrice");
            }
        }
    
       
        public string MenuWithPrice 
        {
            get {
                return $"{Item} {Price.ToString("C", CultureInfo.CurrentCulture)}";
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null) {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}

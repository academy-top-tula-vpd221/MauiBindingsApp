using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MauiBindingsApp
{
    public class Flight : INotifyPropertyChanged
    {
        string name;
        string from;
        string to;
        int day;

        public string Name 
        { 
            get => name; 
            set
            {
                if(value != name)
                {
                    name = value;
                    OnPropertyChanged();
                }
            }
        }
        public string From
        {
            get => from;
            set
            {
                if (value != from)
                {
                    from = value;
                    OnPropertyChanged();
                }
            }
        }
        public string To
        {
            get => to;
            set
            {
                if (value != to)
                {
                    to = value;
                    OnPropertyChanged();
                }
            }
        }
        public int Day
        {
            get => day;
            set
            {
                if (value != day)
                {
                    day = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string property = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}

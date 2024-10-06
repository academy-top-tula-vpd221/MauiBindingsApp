using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiBindingsApp
{
    public class EntryTag : Entry
    {
        public static readonly BindableProperty TagProperty =
            BindableProperty.Create("Tag", typeof(string), typeof(string), "");

        public string Tag
        {
            set => SetValue(TagProperty, value);
            get => (string)GetValue(TagProperty);
        }
    }

}

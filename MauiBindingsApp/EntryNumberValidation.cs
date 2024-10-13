﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiBindingsApp
{
    public class EntryNumberValidation : TriggerAction<Entry>
    {
        protected override void Invoke(Entry sender)
        {
            if (Int32.TryParse(sender.Text, out int value))
                sender.TextColor = Colors.Green;
            else
                sender.TextColor = Colors.Red;
        }
    }
}

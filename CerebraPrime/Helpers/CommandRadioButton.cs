using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace CerebraPrime.Helpers
{
    public class CommandRadioButton : RadioButton
    {
        protected override void OnChecked(RoutedEventArgs e)
        {
            base.OnChecked(e);
            Command?.Execute(CommandParameter);
        }
    }
}

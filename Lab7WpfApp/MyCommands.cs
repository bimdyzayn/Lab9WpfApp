using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Lab7WpfApp
{
    class MyCommands
    {
        public static RoutedUICommand Exit { get; set; }

        static MyCommands()
        {
            InputGestureCollection inputs = new InputGestureCollection();
            inputs.Add(new KeyGesture(Key.T, ModifierKeys.Control, "Ctrl+T"));
            Exit = new RoutedUICommand("Закрыть","Exit",typeof(MyCommands),inputs);
        }
    }
}
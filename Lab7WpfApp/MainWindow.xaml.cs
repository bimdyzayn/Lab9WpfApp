using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab7WpfApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<string> styles = new List<string>() { "Светлая тема", "Тёмная тема" };
            styleBox.ItemsSource = styles;
            styleBox.SelectedIndex = 0;
            styleBox.SelectionChanged += ThemeChange;
        }

        private void ThemeChange(object sender, SelectionChangedEventArgs e)
        {
            int styleIndex = styleBox.SelectedIndex;
            Uri uri = new Uri("Light.xaml", UriKind.Relative);
            if (styleIndex == 1)
            {
                uri = new Uri("Dark.xaml", UriKind.Relative);
            }

            ResourceDictionary resource = Application.LoadComponent(uri) as ResourceDictionary;
            Application.Current.Resources.Clear();
            Application.Current.Resources.MergedDictionaries.Add(resource);
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы(*.*)|*.*";
            //if (openFileDialog.ShowDialog() == true)
            //{
            //    textBox.Text = File.ReadAllText(openFileDialog.FileName);
            //}
        }

        private void fonlist_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int i = 1;
            i = i + 2;
            i = i + 1;


        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы(*.*)|*.*";
            //if (saveFileDialog.ShowDialog() == true)
            //{
            //    File.WriteAllText(saveFileDialog.FileName, textBox.Text);
            //}
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ExitExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void OpenExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Документ открыт");
        }

        private void SaveExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Документ сохранён");
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Tema_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            var tmp = sender;
            var tmp1 = e;
            var tmp2 = sender;
        }


        private void fonlist_ContextMenuClosing(object sender, ContextMenuEventArgs e)
        {

        }
    }
}

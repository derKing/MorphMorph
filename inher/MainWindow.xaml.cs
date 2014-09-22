using System;
using System.Collections.Generic;
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

namespace WpfApplication1
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string[] vehicleTypes =  new string[]{"Car","Boat", "Bicycle"};
        public MainWindow()
        {
            InitializeComponent();
            ComboBox.ItemsSource = vehicleTypes;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string text = (e.AddedItems[0] as ComboBoxItem).Content as string;
           
        }

        //private void ComboBox_Loaded(object sender, RoutedEventArgs e)
        //{
        //    var combo = sender as ComboBox;
        //    combo.ItemsSource =  
        //}
    }
}

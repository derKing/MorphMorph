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
using inher.Classes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string[] vehicleTypes = new string[] { "Car", "Boat", "Bicycle" };
        private List<Vehicle> vehicleList = new List<Vehicle>();
        private Vehicle underConstruction_Vehicle = new Vehicle();
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
            switch (text)
            {
                case "Car":
                {
                    break;
                }
                case "Boat":
                {
                    break;
                }
                case "Bicycle":
                {
                    break;
                }
            }

           
        }

        

        private void SaveClick(object sender, RoutedEventArgs e)
        {
            vehicleList.Add(underConstruction_Vehicle);
        }

       
    }
}

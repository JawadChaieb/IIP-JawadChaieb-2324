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

namespace Wpfsliderkleur
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SliderKleur_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double value = SliderKleur.Value;
            int roundedValue = (int)Math.Round(value);

            if (roundedValue < 30)
            {
                LabelKleur.Content = roundedValue.ToString();  // Display rounded numerical value
                LabelKleur.Background = Brushes.Yellow;
            }
            else if (roundedValue < 50)
            {
                LabelKleur.Content = roundedValue.ToString();  // Display rounded numerical value
                LabelKleur.Background = Brushes.DarkOrange;
            }
            else if (roundedValue < 80)
            {
                LabelKleur.Content = roundedValue.ToString();  // Display rounded numerical value
                LabelKleur.Background = Brushes.DarkRed;
            }
            else
            {
                LabelKleur.Content = roundedValue.ToString();  // Display rounded numerical value
                LabelKleur.Background = Brushes.Green;
            }

        }
    }
}

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

namespace Wpfbmi
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

        private void BerekenButton_Click(object sender, RoutedEventArgs e)
        {
                double lengte = Convert.ToDouble(LengteTextBox.Text);
                double gewicht = Convert.ToDouble(GewichtTextBox.Text);

                double bmi = gewicht / Math.Pow(lengte / 100, 2);

            BmiLabel.Content = String.Format("BMI: {0:0.0}", bmi);
        }
    }
}

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

namespace Wpfbieden
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double _hoogsteBod = 0;
        private string _hoogsteBieder = string.Empty;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonBod_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNaam.Text) || string.IsNullOrEmpty(textBoxBod.Text))
            {
                statustextblock.Text = "Vul a.u.b. de naam en het bod in.";
                return;
            }

            double bod;
            if (!double.TryParse(textBoxBod.Text, out bod))
            {
                statustextblock.Text = "Vul a.u.b. een geldig bedrag in voor het bod.";
                return;
            }

            if (bod > _hoogsteBod)
            {
                _hoogsteBod = bod;
                _hoogsteBieder = textBoxNaam.Text;
                statustextblock.Text = $"{_hoogsteBieder} heeft met {_hoogsteBod} euro nu het hoogste bod!";
            }
            else
            {
                statustextblock.Text = "Er is nog geen bod uitgebracht of het hoogste bod is nog steeds geldig.";
            }

            textBoxNaam.Text = string.Empty;
            textBoxBod.Text = string.Empty;
        }
        }
}

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

namespace WpfComplexiteit
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string invoerTekst = Textbox.Text;
            AnalyseerComplexiteit(invoerTekst);
        }

        private void AnalyseerComplexiteit(string invoerTekst)
        {
            if (string.IsNullOrWhiteSpace(invoerTekst))
            {
                Textblock.Text = "Geen tekst ingevoerd.";
                return;
            }

            double complexiteit = BerekenComplexiteit(invoerTekst);

            Textblock.Text = $"Aantal karakters: {invoerTekst.Length}\n" +
                             $"Aantal lettergrepen: {TelLettergrepen(invoerTekst)}\n" +
                             $"Complexiteit: {complexiteit:F1}";
        }

        private int TelLettergrepen(string woord)
        {
            var klinkers = new[] { 'a', 'e', 'i', 'o', 'u', 'y' };
            int lettergrepen = 0;
            bool laatsteWasKlinker = false;

            foreach (char c in woord.ToLower())
            {
                if (klinkers.Contains(c))
                {
                    if (!laatsteWasKlinker)
                    {
                        lettergrepen++;
                    }
                    laatsteWasKlinker = true;
                }
                else
                {
                    laatsteWasKlinker = false;
                }
            }

            return lettergrepen;
        }

        private double BerekenComplexiteit(string woord)
        {
            return Math.Round((woord.Length / 3.0) + TelLettergrepen(woord) + (woord.ToLower().Any(c => "xyq".Contains(c)) ? 1 : 0), 1);
        }
    }
}

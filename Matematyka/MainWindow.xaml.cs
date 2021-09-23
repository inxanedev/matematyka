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

namespace Matematyka
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

        private void change_operation(object sender, RoutedEventArgs e)
        {
            if (numberA == null || numberB == null || dodawanie == null || odejmowanie == null || mnozenie == null || dzielenie == null || wynik == null) return;
            try
            {
                double a = double.Parse(numberA.Text);
                double b = double.Parse(numberB.Text);

                if ((bool)dodawanie.IsChecked)
                {
                    wynik.Text = (a + b).ToString();
                }
                else if ((bool)odejmowanie.IsChecked)
                {
                    wynik.Text = (a - b).ToString();
                }
                else if ((bool)mnozenie.IsChecked)
                {
                    wynik.Text = (a * b).ToString();
                }
                else if ((bool)dzielenie.IsChecked)
                {
                    wynik.Text = (a / b).ToString();
                }
            }
            catch (FormatException)
            {
                wynik.Text = "0";
            }
            catch (NullReferenceException)
            {
                wynik.Text = "0";
            }
            catch (DivideByZeroException)
            {
                wynik.Text = "ERROR";
            }
            catch (InvalidCastException)
            {
                wynik.Text = "ERROR";
            }
        }
    }
}

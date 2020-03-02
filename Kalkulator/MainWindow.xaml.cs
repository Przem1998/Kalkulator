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

namespace Kalkulator
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AddRemove activity = new AddRemove();
        multiply_divide ab = new multiply_divide();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            double valueA = 0;
            double valueB = 0;
            try
            {
                valueA = double.Parse(aField.Text);
                valueB = double.Parse(bField.Text);

            }
            catch (System.FormatException) { }
  
            resultActivity.Text = "="+activity.add(valueA, valueB);

        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            double valueA = 0;
            double valueB = 0;
            try
            {
                valueA = double.Parse(aField.Text);
                valueB = double.Parse(bField.Text);

            }
            catch (System.FormatException) { }

            resultActivity.Text = "=" + activity.remove(valueA, valueB);
        }

        private void Multiple_Click(object sender, RoutedEventArgs e)
        {
            double valueA = 0;
            double valueB = 0;
            try
            {
                valueA = double.Parse(aField.Text);
                valueB = double.Parse(bField.Text);

            }
            catch (System.FormatException) { }
            resultActivity.Text = "=" + ab.multiply(valueA, valueB);

        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            double valueA = 0;
            double valueB = 0;
            try
            {
                valueA = double.Parse(aField.Text);
                valueB = double.Parse(bField.Text);

            }
            catch (System.FormatException) { }
            resultActivity.Text = "=" + ab.divide(valueA, valueB);
        }
     

    }
}

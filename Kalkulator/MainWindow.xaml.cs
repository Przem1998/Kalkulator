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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        stas st = new stas();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            result.Text = Convert.ToString(st.podziel(Convert.ToDouble(pierwszaliczba.Text), Convert.ToDouble(drugaliczba.Text)));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            result.Text=Convert.ToString(st.mnoz(Convert.ToDouble(pierwszaliczba.Text), Convert.ToDouble(drugaliczba.Text)));
        }
    }
}

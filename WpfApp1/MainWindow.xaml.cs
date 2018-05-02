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

namespace WpfApp1
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        frontend front = new frontend();

        public MainWindow()
        {
            InitializeComponent();
        }
        private void vypocti_Click(object sender, RoutedEventArgs e)
        {
            RLC obv = new RLC(grid2);

            try
            {
                obv.Initialize();
            }
            catch(InvalidValueException ex)
            {
                Console.WriteLine("Nesprávná hodnota: " + ex);
            }

            obv.setValueTB(RLC.TYPES.INDEX_C, obv.GetC());
        }

        private void new_Click(object sender, RoutedEventArgs e)
        {

        }

        private void open_Click(object sender, RoutedEventArgs e)
        {

        }

        private void save_Click(object sender, RoutedEventArgs e)
        {

        }
  
        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void horni_Click(object sender, RoutedEventArgs e)
        {
            grid2.Children.Clear();
            front.makehor(grid2);
        }

        private void dolni_Click(object sender, RoutedEventArgs e)
        {
            grid2.Children.Clear();
            front.makedol(grid2);
        }

        private void log_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

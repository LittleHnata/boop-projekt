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
                if (!(grid2.Children[1] as TextBox).IsEnabled)
                {
                    try
                    {
                        obv.Initialize();
                    }
                    catch (InvalidValueException ex)
                    {
                        Console.WriteLine("Nesprávná hodnota: " + ex);
                    }

                    obv.setValueTB(RLC.TYPES.INDEX_F, obv.GetF());
                }
                if (!(grid2.Children[5] as TextBox).IsEnabled)
                {
                    try
                    {
                        obv.Initialize();
                    }
                    catch (InvalidValueException ex)
                    {
                        Console.WriteLine("Nesprávná hodnota: " + ex);
                    }

                    obv.setValueTB(RLC.TYPES.INDEX_R, obv.GetR());
                }
                if (!(grid2.Children[9] as TextBox).IsEnabled)
                {
                    try
                    {
                        obv.Initialize();
                    }
                    catch (InvalidValueException ex)
                    {
                        Console.WriteLine("Nesprávná hodnota: " + ex);
                    }

                    obv.setValueTB(RLC.TYPES.INDEX_C, obv.GetC());
                }
            }catch(Exception err)
            {
                Console.Write(err);
            }
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

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if ((Boolean)rad_f.IsChecked)
            {
                try
                {
                    (grid2.Children[1] as TextBox).IsEnabled = false;
                    (grid2.Children[5] as TextBox).IsEnabled = true;
                    (grid2.Children[9] as TextBox).IsEnabled = true;
                }
                catch (Exception err)
                {
                    Console.Write(err);
                }
            }
            else
            {
                if ((Boolean)rad_R.IsChecked)
                {
                    try
                    {
                        (grid2.Children[1] as TextBox).IsEnabled = true;
                        (grid2.Children[5] as TextBox).IsEnabled = false;
                        (grid2.Children[9] as TextBox).IsEnabled = true;
                    }
                    catch (Exception err)
                    {
                        Console.Write(err);
                    }
                }
                if ((Boolean)rad_C.IsChecked)
                {
                    try
                    {
                        (grid2.Children[1] as TextBox).IsEnabled = true;
                        (grid2.Children[5] as TextBox).IsEnabled = true;
                        (grid2.Children[9] as TextBox).IsEnabled = false;
                    }
                    catch (Exception err)
                    {
                        Console.Write(err);
                    }
                }
            }
        }
    }
}

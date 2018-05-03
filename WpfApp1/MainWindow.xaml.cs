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
                if ((Boolean)rad_f.IsChecked)
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
                else
                {
                    if ((Boolean)rad_R.IsChecked)
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
                    else
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
                }
                vysledky.Content +="f: " + (grid2.Children[1] as TextBox).Text.ToString() + " Hz\nR:" + (grid2.Children[5] as TextBox).Text.ToString() + " Ω\nC:" + (grid2.Children[9] as TextBox).Text.ToString() + "uF\n--------------------------\n";
            }
            catch(Exception err)
            {
                Console.Write(err);
            }
        }
        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void horni_Click(object sender, RoutedEventArgs e)
        {
            grid2.Children.Clear();
            front.makehor(grid2);
            settextbox();
        }

        private void dolni_Click(object sender, RoutedEventArgs e)
        {
            grid2.Children.Clear();
            front.makedol(grid2);
            settextbox();
        }

        private void log_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            settextbox();
        }
        private void settextbox()
        {
            try
            {
                if ((Boolean)rad_f.IsChecked)
                {

                    (grid2.Children[1] as TextBox).IsEnabled = false;
                    (grid2.Children[5] as TextBox).IsEnabled = true;
                    (grid2.Children[9] as TextBox).IsEnabled = true;

                }
                else
                {
                    if ((Boolean)rad_R.IsChecked)
                    {

                        (grid2.Children[1] as TextBox).IsEnabled = true;
                        (grid2.Children[5] as TextBox).IsEnabled = false;
                        (grid2.Children[9] as TextBox).IsEnabled = true;

                    }
                    else
                    {
                        (grid2.Children[1] as TextBox).IsEnabled = true;
                        (grid2.Children[5] as TextBox).IsEnabled = true;
                        (grid2.Children[9] as TextBox).IsEnabled = false;
                    }
                }
            }
            catch (Exception err)
            {
                Console.Write(err);
            }
        }
    }
         
}

/* Name: John Martin
   Date: September 12, 2015
   Class: CSc 4380: Windowing Systems Programming
   Homework 2

   Description:
   
   This GUI displays several radio buttons, a check-box, and a push button. Three radio buttons are shown in the top-left
   corner of the window, three radio buttons in the top-right corner, the checkbox in the bottom-left, and the button in the
   bottom-right.

   When the checkbox is checked, the button is enabled, meaning that the user can click on it. If the checkbox is not 
   checked, the button is disabled.

   When the user clicks on the button, the program prints out to the console which radio button(s) is/are selected.

*/

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

namespace JohnMartinHW2
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

        /* This callback determines whether the checkbox is checked or not. If it is checked, then the button is
           enabled, and you can click on it. Otherwise, if the checkbox is not checked, then the user cannot click 
           on the button. This callback is attached to the checkbox. */
        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (checkBox.IsChecked == true)
                button.IsEnabled = true;
            else
                button.IsEnabled = false;
        }

        /* This callback is attached to the button. When the button is clicked, it prints out to the console which 
           radio button(s) is (or are) checked (if any). */
        private void print_radio_buttons(object sender, RoutedEventArgs e)
        {
            if (button.IsEnabled) // Button is enabled
            {
                Console.WriteLine("\nChecked radio button(s): ");
                if (radioButton1.IsChecked == false && radioButton2.IsChecked == false && radioButton3.IsChecked == false
                    && radioButton4.IsChecked == false && radioButton5.IsChecked == false && radioButton6.IsChecked == false)
                    Console.WriteLine("none");
                if (radioButton1.IsChecked == true)
                    Console.WriteLine("RadioButton 1");
                if (radioButton2.IsChecked == true)
                    Console.WriteLine("RadioButton 2");
                if (radioButton3.IsChecked == true)
                    Console.WriteLine("RadioButton 3");
                if (radioButton4.IsChecked == true)
                    Console.WriteLine("RadioButton 4");
                if (radioButton5.IsChecked == true)
                    Console.WriteLine("RadioButton 5");
                if (radioButton6.IsChecked == true)
                    Console.WriteLine("RadioButton 6");
            }
        }
    }
}

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

namespace SimpleCalc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        string currentOp;
        public int opResult;
        public int num1;
        public int num2;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void onClick(object sender, RoutedEventArgs e)
        {
            resultBox.Text = "";
        }

        private void opBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void num1Input(object sender, TextCompositionEventArgs e)
        {
            try
            {
                num1 = Int32.Parse(num1Box.Text);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Not a valid number");
            };
        }

        private void num2Input(object sender, TextCompositionEventArgs e)
        {
            try
            {
                num2 = Int32.Parse(num2Box.Text);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Not a valid number");
            };
        }
        private void goButton_Click(object sender, RoutedEventArgs e)
        {
            switch (opBox.SelectedIndex)
            {
                case 0:
                    opResult = num1 + num2;
                    break;
                case 1:
                    opResult = num1 - num2;
                    break;
                case 2:
                    opResult = num1 * num2;
                    break;
                case 3:
                    opResult = num1 / num2;
                    break;
            }

            resultBox.Text = opResult.ToString();
        }
    };      
}

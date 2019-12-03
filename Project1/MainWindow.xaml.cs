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

namespace Project1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double FirstNumber;
        String Operation;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Display_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Z_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = Display.Text + "0";
        }
        private void One_Click(object sender, RoutedEventArgs e)
        {
            if (Display.Text == "0" && Display.Text != null)
            {
                Display.Text = "1";
            }
            else
            {
                Display.Text = Display.Text + "1";
            }
        }
        private void Two_Click(object sender, RoutedEventArgs e)
        {
            if (Display.Text == "0" && Display.Text != null)
            {
                Display.Text = "2";
            }
            else
            {
                Display.Text = Display.Text + "2";
            }
        }
        private void Three_Click(object sender, RoutedEventArgs e)
        {
            if (Display.Text == "0" && Display.Text != null)
            {
                Display.Text = "3";
            }
            else
            {
                Display.Text = Display.Text + "3";
            }
        }
        private void Four_Click(object sender, RoutedEventArgs e)
        {
            if (Display.Text == "0" && Display.Text != null)
            {
                Display.Text = "4";
            }
            else
            {
                Display.Text = Display.Text + "4";
            }
        }
        private void Five_lick(object sender, RoutedEventArgs e)
        {
            if (Display.Text == "0" && Display.Text != null)
            {
                Display.Text = "5";
            }
            else
            {
                Display.Text = Display.Text + "5";
            }
        }
        private void Six_Click(object sender, RoutedEventArgs e)
        {
            if (Display.Text == "0" && Display.Text != null)
            {
                Display.Text = "6";
            }
            else
            {
                Display.Text = Display.Text + "6";
            }
        }
        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            if (Display.Text == "0" && Display.Text != null)
            {
                Display.Text = "7";
            }
            else
            {
                Display.Text = Display.Text + "7";
            }
        }
        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            if (Display.Text == "0" && Display.Text != null)
            {
                Display.Text = "8";
            }
            else
            {
                Display.Text = Display.Text + "8";
            }
        }
        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            if (Display.Text == "0" && Display.Text != null)
            {
                Display.Text = "9";
            }
            else
            {
                Display.Text = Display.Text + "9";
            }
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(Display.Text);
            Display.Text = "0";
            Operation = "+";
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(Display.Text);
            Display.Text = "0";
            Operation = "-";

        }

        private void Times_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(Display.Text);
            Display.Text = "0";
            Operation = "*";
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(Display.Text);
            Display.Text = "0";
            Operation = "/";
        }
        private void Module_Click(object sender, RoutedEventArgs e)
        {
            FirstNumber = Convert.ToDouble(Display.Text);
            Display.Text = "0";
            Operation = "%";
        }

        private void Clear_Click(object sender, EventArgs e)
        { 
            Display.Text = "0";
        }

        private void Dot_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + ".";
        }


        private void Equal_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble(Display.Text);

            if (Operation == "+")
            {
                Result = (FirstNumber + SecondNumber);
                Display.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                Display.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                Display.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    Display.Text = "Cannot divide by zero";

                }
                else
                {
                    Result = (FirstNumber / SecondNumber);
                    Display.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }
            if (Operation == "%")
            {
                //int ret = a % b;
                //if (ret < 0)
                //    ret += b;
                //return ret;

                Result = (FirstNumber % SecondNumber);
                Display.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
        }

        
        private void Negative_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}

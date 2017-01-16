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

namespace Red_Black_gambling_game
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

        private void button_Click(object sender, RoutedEventArgs e)
        {

            redorblack.Clear();
            bankTotal.Clear();

            giveCards();
            
        }

        int red = 26;
        int black = 26;
        int total ;
        int bank = 0;
        

        

        private void giveCards()
        {

            Random rnd = new Random();

            int number = rnd.Next(1, 52);
            total = red + black;

            oddOrEven(number);

            resetBank(ref bank);
            resetBank(ref black);
            resetBank(ref red);
            resetCards(ref total);
           

            blackCards.Content = "Black cards remaining: " + black.ToString();
            redCards.Content = "Red cards remaining: " + red.ToString();
            bankTotal.Text +=  bank.ToString();
        }

        public int resetBank(ref int number)
        {
            if (number < 0)
            {
                number = 0;
            }
            return number;
        }

        public int resetCards(ref int number)
        {
            if (number <= 0)
            {
                red = 26;
                black = 26;
            }
            return number;
            
        }

        public void oddOrEven(int number)
        {
            //if (red > 0 && black >0)
            //{
                if (isOdd(number))
                {
                    redorblack.Text += "black";
                    redorblack.Background = Brushes.Black;
                    redorblack.Foreground = Brushes.White;
                    black--;
                    bank++;


                }
                else
                {
                    redorblack.Text += "red";
                    redorblack.Background = Brushes.Red;
                    red--;
                    bank--;

                }
            //}
            
        }

             public static bool isOdd(int value)
        {
            return value % 2 != 0;
        }

        private void cashout_Click(object sender, RoutedEventArgs e)
        {
            red = 26;
            black = 26;
            blackCards.Content = "Black cards remaining: " + black.ToString();
            redCards.Content = "Red cards remaining: " + red.ToString();
        }
    }
 }


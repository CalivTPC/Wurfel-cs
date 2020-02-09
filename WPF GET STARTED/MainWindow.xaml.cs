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
using System.Timers;

namespace WPF_GET_STARTED
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
        private void bnt24_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 7);
            Console.WriteLine("number: " + number);
            txb14.Text = Convert.ToString(number);
            //effect()
            if (number == 1)
            {
                btn11.Visibility = Visibility.Hidden;
                btn12.Visibility = Visibility.Hidden;
                btn13.Visibility = Visibility.Hidden;
                btn21.Visibility = Visibility.Hidden;
                btn22.Visibility = Visibility.Visible;
                btn23.Visibility = Visibility.Hidden;
                btn31.Visibility = Visibility.Hidden;
                btn32.Visibility = Visibility.Hidden;
                btn33.Visibility = Visibility.Hidden;
            };
            if (number == 2)
            {
                btn11.Visibility = Visibility.Hidden;
                btn12.Visibility = Visibility.Hidden;
                btn13.Visibility = Visibility.Visible;
                btn21.Visibility = Visibility.Hidden;
                btn22.Visibility = Visibility.Hidden;
                btn23.Visibility = Visibility.Hidden;
                btn31.Visibility = Visibility.Visible;
                btn32.Visibility = Visibility.Hidden;
                btn33.Visibility = Visibility.Hidden;
            };
            if (number == 3)
            {
                btn11.Visibility = Visibility.Hidden;
                btn12.Visibility = Visibility.Hidden;
                btn13.Visibility = Visibility.Visible;
                btn21.Visibility = Visibility.Hidden;
                btn22.Visibility = Visibility.Visible;
                btn23.Visibility = Visibility.Hidden;
                btn31.Visibility = Visibility.Visible;
                btn32.Visibility = Visibility.Hidden;
                btn33.Visibility = Visibility.Hidden;
            };
            if (number == 4)
            {
                btn11.Visibility = Visibility.Visible;
                btn12.Visibility = Visibility.Hidden;
                btn13.Visibility = Visibility.Visible;
                btn21.Visibility = Visibility.Hidden;
                btn22.Visibility = Visibility.Hidden;
                btn23.Visibility = Visibility.Hidden;
                btn31.Visibility = Visibility.Visible;
                btn32.Visibility = Visibility.Hidden;
                btn33.Visibility = Visibility.Visible;
            };
            if (number == 5)
            {
                btn11.Visibility = Visibility.Visible;
                btn12.Visibility = Visibility.Hidden;
                btn13.Visibility = Visibility.Visible;
                btn21.Visibility = Visibility.Hidden;
                btn22.Visibility = Visibility.Visible;
                btn23.Visibility = Visibility.Hidden;
                btn31.Visibility = Visibility.Visible;
                btn32.Visibility = Visibility.Hidden;
                btn33.Visibility = Visibility.Visible;
            }
            if (number == 6)
            {
                btn11.Visibility = Visibility.Visible;
                btn12.Visibility = Visibility.Hidden;
                btn13.Visibility = Visibility.Visible;
                btn21.Visibility = Visibility.Visible;
                btn22.Visibility = Visibility.Hidden;
                btn23.Visibility = Visibility.Visible;
                btn31.Visibility = Visibility.Visible;
                btn32.Visibility = Visibility.Hidden;
                btn33.Visibility = Visibility.Visible;
            };
        }
        }
    }
}

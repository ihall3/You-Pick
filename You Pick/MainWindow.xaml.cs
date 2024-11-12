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

namespace YOU_PICK
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            int a = rnd.Next(1,6);
           Window1 objWindow1 = new Window1();
           Window2 objWindow2 = new Window2();
           Window3 objwindow3 = new Window3();
           Window4 objwindow4 = new Window4();
           Window5 objwindow5 = new Window5();
            this.Visibility = Visibility.Hidden;
            switch(a)
            {
                case 1: objWindow1.Show(); 
                    break;
                case 2: objWindow2.Show();
                    break;
                case 3: objwindow3.Show();
                    break;
                case 4: objwindow4.Show();
                    break;
                case 5: objwindow5.Show();
                    break;
            }
            
        }

        }
    }


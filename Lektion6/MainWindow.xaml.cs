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

namespace Lektion6
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
            myKnap.Content = "Weee!!";
        }

        private void isChecked(object sender, RoutedEventArgs e)
        {
            if ((bool)myCheckbox.IsChecked)
            {
                myKnap.Visibility = Visibility.Visible;
            }
            else
            {
                myKnap.Visibility = Visibility.Hidden;
            }
        }
    }
}

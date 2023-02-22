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

namespace SwitchButtons
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

        private void switchTop(object sender, RoutedEventArgs e)
        {
            string temp = topRight.Content.ToString();
            topRight.Content = topLeft.Content;
            topLeft.Content = temp;
        }

        private void switchBottom(object sender, RoutedEventArgs e)
        {
            string temp = bottomRight.Content.ToString();
            bottomRight.Content = bottomLeft.Content;
            bottomLeft.Content = temp;
        }
    }
}

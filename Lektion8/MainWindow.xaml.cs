using DAL;
using Lektion8.Model;
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

namespace Lektion8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private PerformerContext context = new PerformerContext();
        public MainWindow()
        {
            InitializeComponent();

            bool created = context.Database.EnsureCreated();
            if (created)
            {
                MessageBox.Show("Database Created");
            }
        }

        private void showPerformers(object sender, RoutedEventArgs e)
        {
            performerList.Items.Clear();
            foreach (Performer p in context.Performers)
            {
                performerList.Items.Add(p);
            }
        }

        private void add(object sender, RoutedEventArgs e)
        {
            context.Performers.Add(new Performer("Stevie Ray Vaughan", false));
            context.Performers.Add(new Performer("Foo Fighters", true));

            context.SaveChanges();
        }
    }
}

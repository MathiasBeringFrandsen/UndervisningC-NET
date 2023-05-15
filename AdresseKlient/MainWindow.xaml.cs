using AdresseKlient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
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

namespace AdresseKlient
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

        private void GetButton_Click(object sender, RoutedEventArgs e)
        {
            String vejnavn = Vejnavn.Text;
            String husnummer = Husnummer.Text;

            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Accept.Clear();
            Task<string> task = client.GetStringAsync($"https://api.dataforsyningen.dk/adgangsadresser?vejnavn={vejnavn}&husnr={husnummer}&struktur=mini");
            String msg = task.Result;

            List<Adresse> adresser = JsonSerializer.Deserialize<List<Adresse>>(msg);

            VejListe.ItemsSource = adresser;                
                          
        }

    }
}
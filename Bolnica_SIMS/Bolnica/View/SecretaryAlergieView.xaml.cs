using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Model;
using Bolnica.Service;

namespace Bolnica.View
{
    /// <summary>
    /// Interaction logic for SecretaryAlergieView.xaml
    /// </summary>
    public partial class SecretaryAlergieView : Window
    {
        public static ObservableCollection<Alergie> Alergies { get; set; }
        public SecretaryAlergieView()
        {
            InitializeComponent();
            InitializeComponent();



            this.DataContext = this;

            Alergies = new ObservableCollection<Alergie>();

            GridDataSecretaryAlergieView.ItemsSource = Alergies;
            //AlergieService as = new AlergieService();

            foreach (Alergie a in AlergieService.GetAll())
            {
                Alergies.Add(a);
            }
        }

        //ADD
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CreateAlergieSecretaryView create = new CreateAlergieSecretaryView();
            create.Show();
        }

        //UPDATE
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        //REMOVE
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (GridDataSecretaryAlergieView.SelectedIndex != -1)
            {
                Alergie pom = AlergieService.GetAlergieByName(((Alergie)GridDataSecretaryAlergieView.SelectedItem).Name);
                AlergieService.DeleteAlergie(((Alergie)GridDataSecretaryAlergieView.SelectedItem).Name);
                Alergies.Remove(pom);
            }
            else
            {
                MessageBox.Show("You must select a Patient");
            }
        }
        
        //BACK
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            SecretaryView sw = new SecretaryView();
            sw.Show();
            this.Close();
        }
    }
}

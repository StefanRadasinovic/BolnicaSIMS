using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Bolnica.Service;
using Model;
using Service;

namespace Bolnica.View
{
    /// <summary>
    /// Interaction logic for CreateAlergieSecretaryView.xaml
    /// </summary>
    public partial class CreateAlergieSecretaryView : Window
    {
        public CreateAlergieSecretaryView()
        {
            InitializeComponent();
        }

        //SUBMIT
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String name2 = name.Text;
            Alergie a = new Alergie(name2);
            AlergieService.CreateAlergie(a);
            SecretaryAlergieView.Alergies.Add(a);

            this.Close();
        }

        //CANCEL
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SecretaryAlergieView s = new SecretaryAlergieView();
            s.Show();
            this.Close();
        }
    }
}

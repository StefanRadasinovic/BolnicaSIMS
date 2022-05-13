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

namespace Bolnica.View
{
    /// <summary>
    /// Interaction logic for SecretaryView.xaml
    /// </summary>
    public partial class SecretaryView : Window
    {
        public SecretaryView()
        {
            InitializeComponent();
        }

        //PATIENTS CRUD
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SecretaryPatientView sp = new SecretaryPatientView();
            sp.Show();
            this.Close();
        }

        //APPOINTMENTS MANAGEMENT
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SecretaryAppointmentView sa = new SecretaryAppointmentView();
            sa.Show();
            this.Close();
        }

        //ALERGIES CRUD
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            SecretaryAlergieView sa = new SecretaryAlergieView();
            sa.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }
    }
}

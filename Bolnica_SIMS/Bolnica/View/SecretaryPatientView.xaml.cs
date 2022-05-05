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
using Service;

namespace Bolnica.View
{
    /// <summary>
    /// Interaction logic for SecretaryPatientView.xaml
    /// </summary>
    public partial class SecretaryPatientView : Window
    {
        public static ObservableCollection<Patient> Patients { get; set; }
        public SecretaryPatientView()
        {
            InitializeComponent();
            InitializeComponent();



            this.DataContext = this;

            Patients = new ObservableCollection<Patient>();

            GridDataSecretaryView.ItemsSource = Patients;
            PatientService ps = new PatientService();

            foreach (Patient p in ps.GetAll())
            {
                Patients.Add(p);
            }


        }

        //REGISTER
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RegisterPatientSecretaryView register = new RegisterPatientSecretaryView();
            register.Show();
        }

        //UPDATE
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            PatientService ps = new PatientService();
            if (GridDataSecretaryView.SelectedIndex != -1)
            {
                Patient pom = ps.GetPatientByJMBG(((Patient)GridDataSecretaryView.SelectedItem).Jmbg);
                ps.DeletePatient(((Patient)GridDataSecretaryView.SelectedItem).Jmbg);
                UpdatePatientSecretaryView up = new UpdatePatientSecretaryView(pom);
                up.Show();
                GridDataSecretaryView.Items.Refresh();
            }
            else
            {
                MessageBox.Show("You must select a Patient");
            }
        }

        //DELETE
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            PatientService ps = new PatientService();
            if (GridDataSecretaryView.SelectedIndex != -1)
            {
                Patient pom = ps.GetPatientByJMBG(((Patient)GridDataSecretaryView.SelectedItem).Jmbg);
                ps.DeletePatient(((Patient)GridDataSecretaryView.SelectedItem).Jmbg);
                Patients.Remove(pom);
            }
            else
            {
                MessageBox.Show("You must select a Patient");
            }
        }

        //BACK
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }
    }
}

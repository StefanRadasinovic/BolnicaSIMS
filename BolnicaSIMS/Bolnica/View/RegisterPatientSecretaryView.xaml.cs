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
using Model;
using Service;

namespace Bolnica.View
{
    /// <summary>
    /// Interaction logic for RegisterPatientSecretaryView.xaml
    /// </summary>
    public partial class RegisterPatientSecretaryView : Window
    {
        public RegisterPatientSecretaryView()
        {
            InitializeComponent();
        }

        //SUBMIT
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String name2 = name.Text;
            String surname2 = surname.Text;
            int JMBG = Convert.ToInt32(jmbg.Text);
            String date = birthDate.Text;
            String phone2 = phone.Text;
            String email2 = email.Text;
            String username2 = username.Text;
            String password2 = password.Text;



            Patient p = new Patient(name2, surname2, JMBG, date, phone2, email2, username2, password2);
            PatientService ps = new PatientService();
            ps.RegisterPatient(p);
            SecretaryPatientView.Patients.Add(p);

            this.Close();
        }

        //CANCEL
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SecretaryPatientView s = new SecretaryPatientView();
            s.Show();
            this.Close();
        }
    }
}

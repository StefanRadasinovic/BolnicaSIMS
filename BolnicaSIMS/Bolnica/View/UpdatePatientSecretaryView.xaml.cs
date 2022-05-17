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
    /// Interaction logic for UpdatePatientSecretaryView.xaml
    /// </summary>
    public partial class UpdatePatientSecretaryView : Window
    {
        private int trenutniJMBG;
        public UpdatePatientSecretaryView(Patient p)
        {
            InitializeComponent();
            name.Text = p.Name;
            surname.Text = p.Surname;
            jmbg.Text = Convert.ToString(p.Jmbg);
            birthDate.Text = p.BirthDate;
            phone.Text = p.BirthDate;
            email.Text = p.Email;
            username.Text = p.Username;
            password.Text = " ";
            TrenutniJMBG = p.Jmbg;
        }
        public int TrenutniJMBG { get => trenutniJMBG; set => trenutniJMBG = value; }

        //SUBMIT
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PatientService ps = new PatientService();
            Patient pom = new Patient(name.Text, surname.Text, trenutniJMBG, birthDate.Text, phone.Text, email.Text, username.Text, password.Text);
            ps.UpdatePatient(pom);


            this.Close();
        }

        //CANCEL
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

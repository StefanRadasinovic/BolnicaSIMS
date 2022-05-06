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
    /// Interaction logic for UpdateAppointmentSecretaryView.xaml
    /// </summary>
    public partial class UpdateAppointmentSecretaryView : Window
    {
        private String trenutniAppID;
        private String trenutniName;
        private int trenutniJMBG;
        public UpdateAppointmentSecretaryView(Appointment a)
        {
            InitializeComponent();
            jmbg.Text = Convert.ToString(a.PatientJMBG);
            name.Text = a.PatientNAME;
            doctorID.Text = a.DoctorID;
            date.Text = a.Datee;
            time.Text = a.Tiime;
            trenutniJMBG = a.PatientJMBG;
            trenutniAppID = a.AppID;
            trenutniName = a.PatientNAME;



        }

        public string TrenutniAppID { get => trenutniAppID; set => trenutniAppID = value; }
        public string TrenutniName { get => trenutniName; set => trenutniName = value; }
        public int TrenutniJMBG { get => trenutniJMBG; set => trenutniJMBG = value; }

        //SUBMIT
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Appointment pom = new Appointment(trenutniAppID, time.Text, trenutniJMBG, trenutniName, doctorID.Text, date.Text, false);
            AppointmentService.UpdateAppointment(pom);
            
            this.Close();
        }

        //CANCEL
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

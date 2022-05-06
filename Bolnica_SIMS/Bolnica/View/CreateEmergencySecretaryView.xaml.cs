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
    /// Interaction logic for CreateEmergencySecretaryView.xaml
    /// </summary>
    public partial class CreateEmergencySecretaryView : Window
    {
        public static int num = 1;
        public CreateEmergencySecretaryView()
        {
            InitializeComponent();
        }
        public int increase()
        {
            return num++;
        }

        //CREATE EMERGENCY
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String appointmentID = "EA" + (increase().ToString());
            int JMBG = Convert.ToInt32(jmbg.Text);
            String name2 = name.Text;
            String doctorID2 = doctorID.Text;
            String time2 = time.Text;
            String date2 = date.Text;

            Appointment a = new Appointment(appointmentID, time2, JMBG, name2, doctorID2, date2, true);
            AppointmentService.Create2(a);
            SecretaryAppointmentView.Appointments.Add(a);

            Patient p = new Patient(name2, " ", JMBG, " ", " ", " ", " ", " ");
            PatientService ps = new PatientService();
            ps.RegisterPatient(p);
            //SecretaryPatientView.Patients.Add(p);

            this.Close();
        }

        //CANCEL
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

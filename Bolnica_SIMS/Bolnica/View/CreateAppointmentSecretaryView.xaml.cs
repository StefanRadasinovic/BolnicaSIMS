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
    /// Interaction logic for CreateAppointmentSecretaryView.xaml
    /// </summary>
    public partial class CreateAppointmentSecretaryView : Window
    {
        public static int num = 1;
        public CreateAppointmentSecretaryView()
        {
            InitializeComponent();
        }

        public int increase()
        {
            return num++;
        }

        //SUBMIT
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String appointmentID = "A" + (increase().ToString());
            int JMBG = Convert.ToInt32(jmbg.Text);
            String name2 = name.Text;
            String doctorID2 = doctorID.Text;
            String time2 = time.Text;
            String date2 = date.Text;

            Appointment a = new Appointment(appointmentID, time2, JMBG, name2, doctorID2, date2, false);
            AppointmentService.Create2(a);
            SecretaryAppointmentView.Appointments.Add(a);
            this.Close();

        }

        //CANCEL
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

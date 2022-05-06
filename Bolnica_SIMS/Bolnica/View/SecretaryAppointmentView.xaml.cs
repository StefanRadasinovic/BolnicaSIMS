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
    /// Interaction logic for SecretaryAppointmentView.xaml
    /// </summary>
    public partial class SecretaryAppointmentView : Window
    {
        public static ObservableCollection<Appointment> Appointments { get; set; }
        public SecretaryAppointmentView()
        {
            InitializeComponent();
            this.DataContext = this;

            Appointments = new ObservableCollection<Appointment>();

            GridDataSecretaryAppointmentView.ItemsSource = Appointments;
            

            foreach (Appointment a in AppointmentService.GetAll2())
            {
                Appointments.Add(a);
            }
        }

        //CREATE
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CreateAppointmentSecretaryView create = new CreateAppointmentSecretaryView();
            create.Show();
        }

        //UPDATE
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AppointmentService appointmentService = new AppointmentService();
            if (GridDataSecretaryAppointmentView.SelectedIndex != -1)
            {

                String promena = (((Appointment)GridDataSecretaryAppointmentView.SelectedItem).AppID);


                Appointment appointment = AppointmentService.GetAppID(promena);
                UpdateAppointmentSecretaryView usv = new UpdateAppointmentSecretaryView(appointment);
                usv.Show();


            }
            else
                MessageBox.Show("You must click on existing Appointment");
        }

        //CANCEL
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            AppointmentService appointmentService = new AppointmentService();
            if (GridDataSecretaryAppointmentView.SelectedIndex != -1)
            {
                Appointment pom = AppointmentService.GetAppID(((Appointment)GridDataSecretaryAppointmentView.SelectedItem).AppID);
                AppointmentService.DeleteAppointment(((Appointment)GridDataSecretaryAppointmentView.SelectedItem).AppID);
                
                Appointments.Remove(pom);
            }
            else
            {
                MessageBox.Show("You must click on existing Appointment");
            }
        }

        //EMERGENCY
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            CreateEmergencySecretaryView create = new CreateEmergencySecretaryView();
            create.Show();
        }

        //BACK
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            SecretaryView sw = new SecretaryView();
            sw.Show();
            this.Close();
        }
    }
}

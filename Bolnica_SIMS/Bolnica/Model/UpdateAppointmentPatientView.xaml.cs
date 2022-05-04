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

namespace Bolnica.Model
{
    /// <summary>
    /// Interaction logic for UpdateAppointmentPatientView.xaml
    /// </summary>
    public partial class UpdateAppointmentPatientView : Window
    {
        public String ID = null;
        public UpdateAppointmentPatientView(Appointment appointment)
        {
            InitializeComponent();
            ID = appointment.AppointmentID;
            date.SelectedDate = appointment.Date;
            time.Text = appointment.TimeStart.ToString();
            // time.Text = appointment.TimeStart.ToString();
        }


        private void Button_Click(object sender, RoutedEventArgs e) ///OVDE KUCAS IZMENE 
        {

            AppointmentService appointmentService = new AppointmentService();

            DateTime? date = this.date.SelectedDate;
            String format = null;

            if (date.HasValue)
            {
                format = date.Value.ToString("dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            }

            ///  appointmentService.Update(ID,  date.Value, time.Text); NESTO ZEZA KOD VREMENA ZA TEXT BOX U DATETIME - I KOD AppointentService argumenata!
            ///  
            //NAPRAVIO SI PRIVREMENI UPDATE SAMO DA RADI - update2 u servicu koji prima druge argumente-ONDA RADI  

            appointmentService.Update2(ID, date.Value);

            this.Close();



        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}

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
using Controller;
using Service;
using Bolnica.Model;
using Bolnica.Service;

namespace Bolnica.View
{
    /// <summary>
    /// Interaction logic for CreateAppointmentPatientView.xaml
    /// </summary>
    public partial class CreateAppointmentPatientView : Window
    {

        public static int num = 1;

        public static int counter = 1;
        public static List<Therapy> allTherapys = new List<Therapy>();

        public CreateAppointmentPatientView()
        {
            InitializeComponent();
        }
        public int increase()
        {

            return num++;
            
        }


        public int INCREASE()
        {

            return counter++;

        }
        private void Button_Confirm(object sender, RoutedEventArgs e)
        {


            String appointmentID = "A" + (increase().ToString());

            DateTime? date = this.date.SelectedDate;  //// OVDE FORMATIRAS DATUM 

            String format = null;

            if (date.HasValue)
            {
                format = date.Value.ToString("MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture);  
            }

            String? Time = time.Text;

           
            Appointment a = new Appointment(appointmentID, date, Time);



            String therapyID = "T" + (INCREASE().ToString());
            String medication = "Paracetamol";
            String amount = "5mg";
            String timeeStart = "12.07.2022";
            String timeeEnd = "22.09.2022";


         //   Therapy t1 = new Therapy(therapyID, medication, amount, timeeStart, timeeEnd);






           // TherapyService.Create(t1);
            AppointmentController.Create(a);


            

      




            this.Close();

        }






        private void Button_Back(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


    }
}

using System;
using System.Windows;



namespace Bolnica.Model
{
    /// <summary>
    /// Interaction logic for CreateAppointmentPatientView.xaml
    /// </summary>
    public partial class CreateAppointmentPatientView : Window
    {

        public static int num = 1;
        public CreateAppointmentPatientView()
        {
            InitializeComponent();
        }

        public int increase()
        {

            return num++;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            String appointmentID = "A" + (increase().ToString());

            //OVAKO : izmenio si u Patient klasi objekat patient da ti unosi samo ime kako da unesem ime + prezime ?? ?  ? ? ?  


            //   Patient p = new Patient(patient.Text);








            DateTime? date = this.date.SelectedDate;  //// OVDE FORMATIRAS DATUM 

            String format = null;

            if (date.HasValue)
            {
                format = date.Value.ToString("MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture); ///OVO ZA DATUM SAM SKONTAO 
            }


            String Time = time.Text;


            //   String roomNumber = null;





            //Appointment a = new Appointment(appointmentID, p, date, Time);

            //  Appointment a = new Appointment(appointmentID, date, Time);



            // AppointmentService.Create(a);

            this.Close();

        }





        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }



    }





}


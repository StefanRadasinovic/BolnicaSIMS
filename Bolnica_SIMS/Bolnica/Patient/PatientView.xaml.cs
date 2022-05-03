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

namespace Bolnica.Patient
{
    /// <summary>
    /// Interaction logic for PatientView.xaml
    /// </summary>
    public partial class PatientView : Window
    {

        public static ObservableCollection<Appointment> Appointments { get; set; }
        public PatientView()
        {
            InitializeComponent();

            InitializeComponent();

            this.DataContext = this;

            Appointments = new ObservableCollection<Appointment>();

            foreach (Appointment appointment in AppointmentService.GetAll())
            {  ////TREBALO BI VAMO DA BUDE GetAll() metoda umesto allAppointments  al nzm sto nece
                ///Vamo sam morao GetAll() metodu u AppointmentServicu da promenim u  public static Listu<> iz obicne public List<>
                ///sta je razlika izmedju public i public static liste  ?  Kaze objekat  reference je potreban za ne staticko polje/metod.......
                ///



                Appointments.Add(appointment);
            }


        }

        /*
        private void Button_Click(object sender, RoutedEventArgs e) //OVO JE CREATE  
        {
            CreateAppointmentPatientView create = new CreateAppointmentPatientView();
            create.Show();


        }
        


        
        private void Button_Click_1(object sender, RoutedEventArgs e) //////////OVDE IDE DUGME ZA UPDATE 
        {

            AppointmentService appointmentService = new AppointmentService();
            if (GridDataPatientView.SelectedIndex != -1)
            {

                String promena = (((Appointment)GridDataPatientView.SelectedItem).AppointmentID);


                Appointment appointment = appointmentService.GetAppointmentID(promena);
                UpdatePatientView updatePatientView = new UpdatePatientView(appointment);
                updatePatientView.Show();


            }
            else
                MessageBox.Show("You must click on existing Appointment");






        }
        */


        /*
        private void Button_Click_2(object sender, RoutedEventArgs e) //////////OVDE IDE DUGME ZA delete 
        {
            AppointmentService appointmentService = new AppointmentService();
            if (GridDataPatientView.SelectedIndex != -1)
            {
                appointmentService.Delete(((Appointment)GridDataPatientView.SelectedItem).AppointmentID);
            }
            else
            {
                MessageBox.Show("You must click on existing Appointment");
            }

        }
        

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            this.Close();
            mw.Show();

        }

        
        */

    }
        
}

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
using Bolnica.View;
using Model;

namespace Bolnica
{
    /// <summary>
    /// Interaction logic for Proba3.xaml
    /// </summary>
    public partial class Proba3 : Window
    {
        private static Proba3 instance=null;

        public static ObservableCollection<Appointment> Appointments { get; set; }
        public Proba3()
        {
            InitializeComponent();

            this.DataContext = this;

            Appointments = new ObservableCollection<Appointment>();
        }



        private void Button_Create(object sender, RoutedEventArgs e) //OVO JE CREATE  
        {
            CreateAppointmentPatientView create = new CreateAppointmentPatientView();
            create.Show();


        }




        private void Button_Click_1(object sender, RoutedEventArgs e) //////////OVDE IDE DUGME ZA UPDATE 
        {
            /*
            AppointmentService appointmentService = new AppointmentService();
            if (GridDataPatientView.SelectedIndex != -1)
            {

                String promena = (((Appointment)GridDataPatientView.SelectedItem).AppointmentID);


                Appointment appointment = appointmentService.GetAppointmentID(promena);
                UpdateAppointmentPatientView updatePatientView = new UpdateAppointmentPatientView(appointment);
                updatePatientView.Show();


            }
            else
                MessageBox.Show("You must click on existing Appointment");

            */




        }




        private void Button_Click_2(object sender, RoutedEventArgs e) //////////OVDE IDE DUGME ZA delete 
        {
            /*
            AppointmentService appointmentService = new AppointmentService();
            if (GridDataPatientView.SelectedIndex != -1)
            {
                appointmentService.Delete(((Appointment)GridDataPatientView.SelectedItem).AppointmentID);
            }
            else
            {
                MessageBox.Show("You must click on existing Appointment");
            }
            */
        }


        private void Button_Back(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            this.Close();
            mw.Show();

        }



        private void Button_Forward(object sender, RoutedEventArgs e)
        {


        }


        private void Button_Reload(object sender, RoutedEventArgs e)
        {


        }



        private void Button_Search(object sender, RoutedEventArgs e)
        {


        }

        private void Button_Profile(object sender, RoutedEventArgs e)
        {


        }



        private void Button_Therapy(object sender, RoutedEventArgs e)
        {
           

        }

        private static object getInstance()
        {
            if (instance == null)
            {
                instance = new Proba3();
            }
            return instance;
        }

       


    }
}

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
using Service;

namespace Bolnica.View
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

        
        private void Button_Create(object sender, RoutedEventArgs e) //OVO JE CREATE  
        {
            CreateAppointmentPatientView create = new CreateAppointmentPatientView();
            create.Show();


        }
        


        
        private void Button_Update(object sender, RoutedEventArgs e) //////////OVDE IDE DUGME ZA UPDATE 
        {

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






        }
        


        
        private void Button_Delete(object sender, RoutedEventArgs e) //////////OVDE IDE DUGME ZA delete 
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
        

        private void Button_Back(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            this.Close();
            mw.Show();

        }

        

        



        private void Button_Forward(object sender, RoutedEventArgs e)
        {


        }

        private void Button_Therapy(object sender, RoutedEventArgs e)
        {
               TherapyView therapy = new TherapyView();
                therapy.Show();

        }

        private void Button_Notes(object sender, RoutedEventArgs e)
        {
            NotesView notes = new NotesView();
            notes.Show();

        }

        private void Button_Medical_Record(object sender, RoutedEventArgs e)
        {
            MedicalRecordView medicalRecordView = new MedicalRecordView();  
            medicalRecordView.Show();

        }

        private void Button_Home(object sender, RoutedEventArgs e)
        {
            HomeView homeView = new HomeView(); 
            homeView.Show();    
        }

        private void Button_Help(object sender, RoutedEventArgs e)
        {
            HelpView helpView = new HelpView(); 
            helpView.Show();    
        }

        private void Button_About(object sender, RoutedEventArgs e)
        {
            AboutView aboutView = new AboutView();  
            aboutView.Show();

        }

        private void Button_Review(object sender, RoutedEventArgs e)
        {
            ReviewView reviewView = new ReviewView();   
            reviewView.Show();  
        }

        private void Button_Contact(object sender, RoutedEventArgs e)
        {
            ContactView contactView = new ContactView();    
            contactView.Show(); 
        }

        private void ComboBoxItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void ComboBoxItem_MouseDoubleClick_1(object sender, MouseButtonEventArgs e)
        {
            MainWindow mw = new MainWindow();
            this.Close();
            mw.Show();

        }
    }
        
}

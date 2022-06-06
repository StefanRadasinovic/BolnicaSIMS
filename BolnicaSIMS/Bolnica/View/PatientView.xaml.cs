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
using Bolnica.Model;
using Bolnica.Service;
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
        public int counter1 = 0;
        public static ObservableCollection<Appointment> Appointments { get; set; }
        public static ObservableCollection<Therapy> Therapys { get; set; }
        public static Grid MainContent { get; private set; }

        public static Patient logIN = null;   /// <summary> !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        ///  OVO TI SLUZI ZA LOG in-mozda bude zezao oko SurveyView Linija 35 PatientView.logIN
        /// </summary>

        public PatientView(String PatientID)
        {
            InitializeComponent();

            logIN = PatientService.SearchID(PatientID);

            this.DataContext = this;

            Appointments = new ObservableCollection<Appointment>();
            Therapys = new ObservableCollection<Therapy>();


            foreach (Appointment appointment in AppointmentService.GetAll())
            { 


                Appointments.Add(appointment);
            }

            
            foreach (Therapy therapy in TherapyService.GetAll())
            {


                Therapys.Add(therapy);
            }
            
        }

      

        private void Button_Create(object sender, RoutedEventArgs e) 
        {
            CreateAppointmentPatientView create = new CreateAppointmentPatientView();
            create.Show();


        }
        
        
        private void Button_Update(object sender, RoutedEventArgs e) 
        {

            AppointmentService appointmentService = new AppointmentService();
            if (GridDataPatientView.SelectedIndex != -1)
            {

                String change = (((Appointment)GridDataPatientView.SelectedItem).AppointmentID);


                Appointment appointment = appointmentService.GetAppointmentID(change);
                UpdateAppointmentPatientView updatePatientView = new UpdateAppointmentPatientView(appointment);
                updatePatientView.Show();


            }
            else
                MessageBox.Show("You must click on existing Appointment");


        }
        
        
        private void Button_Delete(object sender, RoutedEventArgs e) 
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
        




        private void Button_RateDoctor(object sender, RoutedEventArgs e)
        {

            AppointmentService appointmentService = new AppointmentService();
            if (GridDataPatientView.SelectedIndex != -1)
            {

                String promena2 = (((Appointment)GridDataPatientView.SelectedItem).AppointmentID);


                Appointment Forappointment = appointmentService.GetAppointmentID(promena2);
                RATEDOCTOR2 rATEDOCTOR2 = new RATEDOCTOR2(Forappointment);
                rATEDOCTOR2.Show();


            }
            else
                MessageBox.Show("You must click on existing Appointment");





            
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

        private void Manage_Profile(object sender, RoutedEventArgs e)
        {
            ManageProfileView manageProfileView = new ManageProfileView();  
        
            this.Close();
            manageProfileView.Show();

        }


        private void Button_LogOut(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            this.Close();
            mw.Show();

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


        private void Button_Survey(object sender, RoutedEventArgs e)
        {

            counter1++;
            if (counter1 >= 2)

            //   if (!SurveyService.FreeSurveyAboutBolnica(PatientView.logIN))

            {
                MessageBox.Show("You already Rated Bolnica!");
                return;
            }
            else
            {

                RateBolnicaView rateBolnica = new RateBolnicaView();
                rateBolnica.Show();

            }
           // SurveyView surveyView = new SurveyView();
           // surveyView.Show();
        }

/*
        public void ChnageView(UserControl userControl)
        {
            MainPanel.Children.Clear();
            MainPanel.Children.Add(userControl);
        }
*/

        private void ComboBoxItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void ComboBoxItem_MouseDoubleClick_1(object sender, MouseButtonEventArgs e)
        {
            MainWindow mw = new MainWindow();
            this.Close();
            mw.Show();

        }


        public static Grid GetMainContent()
        {
            return MainContent;
        }


       

    }
        
}

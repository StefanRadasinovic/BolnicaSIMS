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
    /// Interaction logic for SurveyView.xaml
    /// </summary>
    public partial class SurveyView : Window
    {


        public static ObservableCollection<Operation> OldOperations { get; set; }
        public int counter1 = 0;

        public SurveyView()
        {
            InitializeComponent();

            

            OldOperations = new ObservableCollection<Operation>();
            foreach (Operation operation in OperationService.allNeededOperations)
            {
                if (operation.Appointment.Patient.Username.Equals(PatientView.logIN.Username) && operation.Held && !operation.RatedSurvey)
                    OldOperations.Add(operation);
            }
            PatientSurvey.ItemsSource = OldOperations;
        }


        private void FillSurvey_Click(object sender, RoutedEventArgs e)
        {
            if (PatientSurvey.SelectedIndex == -1)
            {
                MessageBox.Show("Choose Survey!");
                return;
            }
            PatientView.GetMainContent().Children.Clear();
            PatientView.GetMainContent().Children.Add(new FillSurveyView(((Operation)PatientSurvey.SelectedItem)));
        }
        private void Button_Back(object sender, RoutedEventArgs e)
        {
            
            this.Close();
           

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



        private void Button_Forward(object sender, RoutedEventArgs e)
        {
        

        }


        private void RateBolnica_Click(object sender, RoutedEventArgs e)
        {
            

            counter1++;
            if (counter1 >= 2)

            //   if (!SurveyService.FreeSurveyAboutBolnica(PatientView.logIN))

            {
                MessageBox.Show("You already Rated Bolnica!");
                return;
            }
            // SurveyService.AddSurvey (new RateBolnicaView);



            // PatientView.GetMainContent().Children.Clear();
            // PatientView.GetMainContent().Children.Add(new RateBolnicaView());

            else
            {
                
                /*****************/
                RateBolnicaView rateBolnicaView = new RateBolnicaView();
                rateBolnicaView.Show();
                
            }

            


        }



    }

}


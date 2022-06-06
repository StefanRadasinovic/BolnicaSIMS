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
using Bolnica.View;
using Model;
using Service;

namespace Bolnica
{
    /// <summary>
    /// Interaction logic for RATEDOCTOR2.xaml
    /// </summary>
    public partial class RATEDOCTOR2 : Window
    {
        public static Operation operationSurvey;
        public RATEDOCTOR2(Appointment Forappointment)
        {
            InitializeComponent();
            
        }

        public RATEDOCTOR2(Operation Forappointment)
        {
            InitializeComponent();
            operationSurvey = Forappointment;

            
        }
        


        private void MarkQuestion(int indexCombo, int indexquestion)
        {
            switch (indexCombo)
            {

                case 0:
                    SurveyService.questionsAboutOperation[indexquestion].Mark = Model.Mark.jedan;
                    break;
                case 1:
                    SurveyService.questionsAboutOperation[indexquestion].Mark = Model.Mark.dva;
                    break;
                case 2:
                    SurveyService.questionsAboutOperation[indexquestion].Mark = Model.Mark.tri;
                    break;
                case 3:
                    SurveyService.questionsAboutOperation[indexquestion].Mark = Model.Mark.cetiri;
                    break;
                case 4:
                    SurveyService.questionsAboutOperation[indexquestion].Mark = Model.Mark.pet;
                    break;
            }
        }


        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < SurveyService.questionsAboutOperation.Count; i++)
            {

                int indexCombo = i + 1;
                MarkQuestion(((ComboBox)this.FindName("question" + indexCombo)).SelectedIndex, i);

            }
           // operationSurvey.RatedSurvey = true;
            SurveyService.AddSurvey(new Model.Survey(PatientView.logIN, DateTime.Now, operationSurvey, SurveyService.questionsAboutOperation, MoreComment.Text));
            SurveyService.ReadSurvey();

            // PatientView.GetMainContent().Children.Clear();
            // PatientView.GetMainContent().Children.Add(new SurveyView());

            MessageBox.Show("You Successfully Rated Doctor!");
            this.Close();
           

        }



        private void Button_Forward(object sender, RoutedEventArgs e)
        {

        }


        private void Button_Back(object sender, RoutedEventArgs e)
        {
            this.Close();
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



    }
}

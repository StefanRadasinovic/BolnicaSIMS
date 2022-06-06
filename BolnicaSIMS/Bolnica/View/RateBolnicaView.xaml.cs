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
using Bolnica.Model;
using Service;

namespace Bolnica.View
{
    /// <summary>
    /// Interaction logic for RateBolnicaView.xaml
    /// </summary>
    public partial class RateBolnicaView : Window
    {
        public RateBolnicaView()
        {
            InitializeComponent();
        }



        private void MarkQuestion(int indexCombo, int questionIndex)
        {
            switch (indexCombo)
            {

                case 0:
                    SurveyService.questionsAboutBolnica[questionIndex].Mark = Model.Mark.jedan;
                    break;
                case 1:
                    SurveyService.questionsAboutBolnica[questionIndex].Mark = Model.Mark.dva;
                    break;
                case 2:
                    SurveyService.questionsAboutBolnica[questionIndex].Mark = Model.Mark.tri;
                    break;
                case 3:
                    SurveyService.questionsAboutBolnica[questionIndex].Mark = Model.Mark.cetiri;
                    break;
                case 4:
                    SurveyService.questionsAboutBolnica[questionIndex].Mark = Model.Mark.pet;
                    break;
            }
        }


        private void RateBolnica_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < SurveyService.questionsAboutBolnica.Count; i++)
            {

                int indexCombo = i + 1;
                MarkQuestion(((ComboBox)this.FindName("question" + indexCombo)).SelectedIndex, i);

            }
            SurveyService.AddSurvey(new Survey(PatientView.logIN, DateTime.Now, null, SurveyService.questionsAboutBolnica, MoreComment.Text));
            SurveyService.ReadSurvey();



            //    PatientView.GetMainContent().Children.Clear();
            //     PatientView.GetMainContent().Children.Add(new SurveyView());

            //SurveyView sv = new SurveyView();
            MessageBox.Show("You Successfully Rated Bolnica!");
            this.Close();
           // sv.Show();

            
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








    }
}

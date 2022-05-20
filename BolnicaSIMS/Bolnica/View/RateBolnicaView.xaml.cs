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
            this.Close();
           // sv.Show();

            
        }



        /*
        private void Button_Back(object sender, RoutedEventArgs e)
        {
            SurveyView sv = new SurveyView();
            this.Close();
            sv.Show();

        }
        <Button Height="35" Content="Back" FontSize="20" Background="#FF31577E" Click="Button_Back" Width="311" Foreground="AntiqueWhite"></Button>

        */










    }
}

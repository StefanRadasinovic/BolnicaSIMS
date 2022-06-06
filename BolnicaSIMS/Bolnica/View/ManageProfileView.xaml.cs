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

namespace Bolnica.View
{
    /// <summary>
    /// Interaction logic for ManageProfileView.xaml
    /// </summary>
    public partial class ManageProfileView : Window
    {
        public ManageProfileView()
        {
            InitializeComponent();
        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {

            this.Close();


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










    }
}

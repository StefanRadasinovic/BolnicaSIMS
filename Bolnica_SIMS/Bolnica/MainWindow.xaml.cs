using Bolnica.Manager;
using Bolnica.Patient;
using System.Windows;

namespace Bolnica
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            PatientView patientView = new PatientView();

            patientView.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

            MainWindowManager mainWindowManager = new MainWindowManager();
            mainWindowManager.Show();
            this.Close();

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

        }








    }
}

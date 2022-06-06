using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Bolnica.Manager;
using Bolnica.Service;
using Bolnica.View;
using Model;

namespace Bolnica
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string PatientID { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {

            String user = txtUsername.Text;
            String pass = txtPassword.Password.ToString();

            User u = UserService.getbyUserPass(user, pass);
            if (u == null)
            {
                MessageBox.Show("User does not exist !");
            }
            else
            {
                if (u.Role == Role.UPRAVNIK)
                {
                    //
                    //this.Close();
                }
                else if (u.Role == Role.DOKTOR)
                {
                    DoctorViewMain d = new DoctorViewMain();
                    d.Show();
                    this.Close();
                }
                else if (u.Role == Role.PACIJENT)
                {
                    PatientView pw = new PatientView(PatientID);
                    pw.Show();
                    this.Close();
                    if(u.Role == Role.PACIJENT && u.Blocked)
                    {
                        System.Windows.MessageBox.Show("BLOCKED!");
                        return;
                    }
                }
                else if (u.Role == Role.SEKRETAR)
                {
                    SecretaryView sw = new SecretaryView();
                    sw.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("User does now have an account!");
                }
            }
        }
        /*
        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();    DODAJ POSLE AKO TREBA U XAML-U
        }
        */

        private void ForgotPassword_Click(object sender, RoutedEventArgs e)
        {
            ForggotPassword fg = new ForggotPassword();
            fg.Show();
        }

        //EXIT APP
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        /*
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DoctorSelectWindowView mainWindowDoc = new DoctorSelectWindowView();
            mainWindowDoc.Show();
            this.Close();
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
            SecretaryPatientView s = new SecretaryPatientView();
            s.Show();
            this.Close();
        }





        */



    }
}

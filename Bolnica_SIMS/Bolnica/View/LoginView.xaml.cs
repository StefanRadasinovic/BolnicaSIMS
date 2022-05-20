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
using Model;
using Bolnica.Serialization;
using Service;
using Bolnica.Service;

namespace Bolnica.View
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : Window
    {
        public LoginView()
        {
            InitializeComponent();
        }

        //LOGIN
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            //kuraccc
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
                    PatientView pw = new PatientView();
                    pw.Show();
                    this.Close();
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

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        //EXIT APP
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}

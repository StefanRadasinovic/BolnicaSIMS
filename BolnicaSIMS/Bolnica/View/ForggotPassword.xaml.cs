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
    /// Interaction logic for ForggotPassword.xaml
    /// </summary>
    public partial class ForggotPassword : Window
    {
        public ForggotPassword()
        {
            InitializeComponent();
        }



        private void Close_Click(object sender, RoutedEventArgs e)
        {

            this.Close();
        }



        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Verification code has been send to your email");

            this.Close();
        }





    }


}

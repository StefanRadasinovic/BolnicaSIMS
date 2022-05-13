using Model;
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
    /// Interaction logic for DoctorApointmentInProgressView.xaml
    /// </summary>
    public partial class DoctorApointmentInProgressView : Window
    {
        int id;
        public DoctorApointmentInProgressView(Operation op)
        {
            this.id = op.OperationID;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Operation op = OperationService.GetOperation(id);
            DoctorAddNewAppointmentInAppointmentView newApp = new DoctorAddNewAppointmentInAppointmentView(op);
            newApp.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            //DoctorViewMain mw = new DoctorViewMain();
            this.Close();
            
        }
    }
  
}

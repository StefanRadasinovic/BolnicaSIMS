using Bolnica.Controller;
using Bolnica.Model;
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
    /// Interaction logic for DoctorDaysOffWindow.xaml
    /// </summary>
    public partial class DoctorDaysOffWindow : Window
    {
        public DoctorDaysOffWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            DaysOffRequest request = new DaysOffRequest("Mister Doctor", datePicker1.Text, datePicker2.Text);
            DoctorDayOffRequestController.Create(request);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            DoctorSelectWindowView mw = new DoctorSelectWindowView();
            this.Close();
            mw.Show();
        }
    }
}

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
    /// Interaction logic for DoctorCheckDrugsView.xaml
    /// </summary>
    public partial class DoctorCheckDrugsView : Window
    {
        public DoctorCheckDrugsView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            if (GridDataDoctorView.SelectedIndex != -1)
            {

            }
            else
            {
                MessageBox.Show("You must click on existing Drug");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DoctorSelectWindowView mw = new DoctorSelectWindowView();
            this.Close();
            mw.Show();
        }
    }
}

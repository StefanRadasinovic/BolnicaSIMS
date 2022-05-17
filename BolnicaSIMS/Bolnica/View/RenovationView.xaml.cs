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

namespace Bolnica.Manager
{
    /// <summary>
    /// Interaction logic for RenovationView.xaml
    /// </summary>
    public partial class RenovationView : Window
    {

        RenovationController renovationController = new RenovationController();


        public RenovationView()
        {
            InitializeComponent();


            DGR.ItemsSource = renovationController.ReadAll();
            //cbox.ItemsSource = renovationController.ReadAll();
            //date_r.DataContext = renovationController.ReadAll();


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String RoomID = Convert.ToString(tb_id.Text);
            DateTime Time = Convert.ToDateTime(DateTime.Now);
            Renovation r = new Renovation(RoomID, Time);
            renovationController.Create(r);
            DGR.Items.Refresh();
            this.Show();


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            String RoomID = Convert.ToString(tb_id.Text);
            renovationController.Delete(RoomID);
            DGR.Items.Refresh(); ;


        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

      /*  private void cbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }*/
    }
}

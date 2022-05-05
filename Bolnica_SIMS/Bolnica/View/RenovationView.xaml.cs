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
           // date_r.DataContext = renovationController.ReadAll();


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String roomID = Convert.ToString(tb_id.Text);
            DateTime dateTime = (DateTime)date_r.SelectedDate;
            Renovation r = new Renovation(roomID, dateTime);
            renovationController.Create(r);
            DGR.Items.Refresh();
            //this.Show();


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            String roomID = Convert.ToString(tb_id.Text);
            renovationController.Delete(roomID);
            DGR.Items.Refresh(); 


        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            EquipmentView equipmentView = new EquipmentView();
            equipmentView.Show();
            this.Close();
        }
    }
}

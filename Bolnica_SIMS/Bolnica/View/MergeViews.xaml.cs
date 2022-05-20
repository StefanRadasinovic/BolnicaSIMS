using Bolnica.Controller;
using Bolnica.Manager;
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
    /// Interaction logic for MergeViews.xaml
    /// </summary>
    public partial class MergeViews : Window
    {
        MergeController mergeController = new MergeController();
        RoomsController rc = new RoomsController();
        public MergeViews()
        {
            
            InitializeComponent();
            DGM.ItemsSource = mergeController.ReadAll();
            
           /* cbox1.ItemsSource = mergeController.ReadAll();
            cbox1.DisplayMemberPath = "RoomID1";
            cbox2.ItemsSource = mergeController.ReadAll();
            cbox2.DisplayMemberPath = "RoomID1";/*/        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String roomID1 = Convert.ToString(tbox.Text);
            DateTime Date = (DateTime)date_r.SelectedDate;
            String roomID2 = Convert.ToString(tbox2.Text);
            Merge m = new Merge(roomID1,Date,roomID2);
            if (roomID1 == roomID2)
            {
                MessageBox.Show("ne");
            }
            else
            {
               
                mergeController.Create(m);
                DGM.Items.Refresh();
            }


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            RenovationView renovationView = new RenovationView();
            renovationView.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            String roomID1 = Convert.ToString(tbox.Text);
            mergeController.Delete(roomID1);
            DGM.Items.Refresh();
        }
    }
}

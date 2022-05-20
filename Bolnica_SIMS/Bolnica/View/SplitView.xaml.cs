using Bolnica.Controller;
using Bolnica.Manager;
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
    /// Interaction logic for SplitView.xaml
    /// </summary>
    public partial class SplitView : Window
    {
        SplitController sc = new SplitController();
        public static List<Split> splits = new List<Split>();
        public SplitView()
        {
            InitializeComponent();
            DGS.ItemsSource = sc.ReadAll();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String roomID1 = Convert.ToString(tbox.Text);
            DateTime Date = (DateTime)date_r.SelectedDate;
            String roomID2 = Convert.ToString(tbox2.Text);
            Split s = new Split(roomID1, Date, roomID2);
            if (roomID1 == roomID2)
            {
                MessageBox.Show("ne");
            }
            else
            {
                sc.Create(s);
                DGS.Items.Refresh();
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
            sc.Delete(roomID1);
            DGS.Items.Refresh();
        }
    }
}

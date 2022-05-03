using Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for ManagerView.xaml
    /// </summary>
    public partial class RoomView : Window

       
    {
       public RoomsController rc = new RoomsController();

       public static ObservableCollection<Rooms> Room { get; set; }
        public RoomView()
        {
            InitializeComponent();

            DGR.ItemsSource = rc.GetAll();


             this.DataContext = this;

             DGR.ItemsSource = Room;

             foreach(Rooms r in rc.GetAll())
             {
                 Room.Add(r);
             }

             DGR.ItemsSource = new List<Rooms>();

            // DGR.Items.Add(Room);


        }

 

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RoomRegister roomRegister = new RoomRegister();
            roomRegister.Show();
            DGR.Items.Refresh();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            if (DGR.SelectedIndex != -1)
            {
               Rooms r = rc.GetRoomID(((Rooms)DGR.SelectedItem).RoomID1);
                UpdateRoom updateRoom = new UpdateRoom();
                updateRoom.Show();
                DGR.Items.Refresh();
            }
            

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            if (DGR.SelectedIndex != 1)
            {
               rc.Delete(((Rooms)DGR.SelectedItem).RoomID1);

            }
            else {
                MessageBox.Show("You must click on exsiisting Rooms");
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MainWindowManager mainWindowManager = new MainWindowManager();
            mainWindowManager.Show();
            
            this.Close();
        }
    }
}

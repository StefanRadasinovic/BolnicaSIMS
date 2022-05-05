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

        public static ObservableCollection<Rooms> Room = new ObservableCollection<Rooms>();
        public RoomView()
        {
            InitializeComponent();
            this.DataContext = this;
            /* foreach (Rooms r in rc.GetAll())
             {
                 Room.Add(r);


                // MessageBox.Show(r.RoomName);
             }

             DGR.ItemsSource = rc.GetAll();*/

            DGR.ItemsSource = rc.GetAll();
            


        }
        public void Refresh() {
            DGR.Items.Refresh();
                }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RoomRegister roomRegister = new RoomRegister(this);
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
               Rooms r = rc.GetRoomID(((Rooms)DGR.SelectedItem).RoomID1);
                rc.Delete(r.RoomID1);
                DGR.Items.Refresh();


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

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MainWindowManager mainWindowManager = new MainWindowManager();
            mainWindowManager.Show();

            this.Close();
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            MainWindowManager mainWindowManager = new MainWindowManager();
            mainWindowManager.Show();

            this.Close();
        }
    }
}

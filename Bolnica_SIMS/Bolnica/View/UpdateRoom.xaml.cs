using Model;
using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace Bolnica.Manager
{
    /// <summary>
    /// Interaction logic for UpdateManagerView.xaml
    /// </summary>


    public partial class UpdateRoom : Window
    {
        public RoomsController rc = new RoomsController();
        private ObservableCollection<Rooms> Room;
        private Rooms r;

        public UpdateRoom(Rooms r)
        {
            InitializeComponent();


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


            String RoomID = Convert.ToString(tb_id.Text);
            int floor = Convert.ToInt32(tb_floor.Text);
            String roomName = Convert.ToString(tb_name.Text);
            RoomsType roomsType = (RoomsType)cbox.SelectedIndex;
            Rooms rooms = new Rooms(RoomID, floor, roomName, roomsType);
            rc.Update(rooms);
            //RoomView.Room.Add(rooms);
            this.Close();


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            this.Close();

        }



    }
}

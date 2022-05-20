using Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;

namespace Bolnica.Manager
{
    /// <summary>
    /// Interaction logic for RegisterMenager.xaml
    /// </summary>
    /// 
    public partial class RoomRegister : Window
    {
        RoomView rv;
        public RoomsController roomsController = new RoomsController();
        private List<Rooms> rooms = new List<Rooms>();
        private ObservableCollection<Rooms> soba;
        private Rooms room = new Rooms();

        public RoomRegister()
        {
            InitializeComponent();
            //this.rv=rv;



        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string RoomID = Convert.ToString(tb_id.Text);
            int floor = Convert.ToInt32(tb_floor.Text);
            String roomName = Convert.ToString(tb_name.Text);
            RoomsType roomsType = (RoomsType)cbox.SelectedIndex;
            Rooms rooms = new Rooms(RoomID, floor, roomName, roomsType);
            roomsController.Create(rooms);
            RoomView.Room.Add(rooms);
            this.Close();





        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


    }
}

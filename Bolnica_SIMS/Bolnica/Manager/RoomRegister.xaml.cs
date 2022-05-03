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

namespace Bolnica.Manager
{
    /// <summary>
    /// Interaction logic for RegisterMenager.xaml
    /// </summary>
    /// 
    public partial class RoomRegister : Window
    {
        public RoomsController roomsController = new RoomsController();
        private List<Rooms> rooms = new List<Rooms>();
       // Rooms room = new Rooms();

        public RoomRegister()
        {
            InitializeComponent();
            
            
        }


      

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string RoomID = Convert.ToString(tb_id.Text);
            int floor = Convert.ToInt32(tb_floor.Text);
            String roomName = Convert.ToString(tb_name);
            RoomsType roomsType = (RoomsType)cbox.SelectedIndex;
            Rooms rooms = new Rooms(RoomID, floor, roomName, roomsType);
            roomsController.Create(rooms);

            this.Close();
            



        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

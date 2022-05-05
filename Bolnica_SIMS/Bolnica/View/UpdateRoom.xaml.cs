using Model;
using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Interaction logic for UpdateManagerView.xaml
    /// </summary>


    public partial class UpdateRoom : Window
    {
        public RoomsController rc = new RoomsController();
        public UpdateRoom()
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
            
            this.Close();


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            this.Close();

        }

     
       
    }
}

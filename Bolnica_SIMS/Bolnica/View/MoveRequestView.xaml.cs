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
    /// Interaction logic for MoveRequestView.xaml
    /// </summary>
    public partial class MoveRequestView : Window
    {
        EquipmentController equipmentController = new EquipmentController();
        //quipment e = new Equipment(string id,EquipmentType,roomID);
       // RequestEquipmentcs requestEquipmentcs = new RequestEquipmentcs(roomID,equipment,dateMove);
        public MoveRequestView()
        {
            InitializeComponent();
            DGM.ItemsSource = equipmentController.ReadAll();
            cbox.ItemsSource = equipmentController.ReadAll();
            cbox.DisplayMemberPath = ("id");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            String RoomID = Convert.ToString(tb_id);
            Equipment equipment = (Equipment)cbox.SelectedItem;
            DateTime dateTime = (DateTime)date_move.SelectedDate;
            //if (equipmentController.MoveEq(RoomID, equipment.Id, dateTime)) { }
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }
    }
}

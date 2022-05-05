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
    /// Interaction logic for MoveRequestView.xaml
    /// </summary>
    public partial class MoveRequestView : Window
    {
        EquipmentController equipmentController = new EquipmentController();
        //quipment e = new Equipment(string id,EquipmentType,roomID);
        // RequestEquipmentcs requestEquipmentcs = new RequestEquipmentcs(roomID,equipment,dateMove);
        RequestController requestController = new RequestController();
        RoomsController roomsController = new RoomsController();

        public MoveRequestView()
        {
            InitializeComponent();
            DGM.ItemsSource = requestController.ReadAll();
            //cbox.ItemsSource = equipmentController.ReadAll();
            //cbox.DisplayMemberPath = ("id");
            cbox.ItemsSource = roomsController.GetAll();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
             
            
                String eqName = Convert.ToString(tb_id);
                RoomsType roomsType = (RoomsType)cbox.SelectedItem;
                DateTime dateTime = (DateTime)date_move.SelectedDate;
            //if (equipmentController.MoveEq(RoomID, equipment.Id, dateTime)) { }
            // if(requestController.)
            RequestEquipmentcs requestEquipmentcs = new RequestEquipmentcs(eqName,roomsType,dateTime);
            requestController.Create(requestEquipmentcs);
            DGM.Items.Refresh();


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            String eqName = Convert.ToString(tb_id);
            requestController.Delete(eqName);
            DGM.Items.Refresh();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            EquipmentView equipmentView = new EquipmentView();
            equipmentView.Show();
            this.Close();
        }
    }
}

using Bolnica.Manager;
using Model;
using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace Bolnica.View
{
    /// <summary>
    /// Interaction logic for EquipmentRegister.xaml
    /// </summary>
    public partial class EquipmentRegister : Window
    {
        EquipmentView ev;

        EquipmentController equipmentController = new EquipmentController();
        RoomsController roomsController = new RoomsController();


        public static ObservableCollection<Equipment> Equipment { get; set; }

        public EquipmentRegister()
        {
            InitializeComponent();
            rid.ItemsSource = roomsController.GetAll();
            rid.DisplayMemberPath = "RoomID1";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String id = Convert.ToString(tb_id.Text);
            EquipmentType et = (EquipmentType)cbox_et.SelectedIndex;
            String roomID = (rid.SelectedItem as Rooms).RoomID1;
            Equipment eq = new Equipment(id, et, roomID);
            equipmentController.Create(eq);
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

using Bolnica.Controller;
using Bolnica.Manager;
using Model;
using System;
using System.Windows;

namespace Bolnica.View
{
    /// <summary>
    /// Interaction logic for RequestRegister.xaml
    /// </summary>
    public partial class RequestRegister : Window
    {
        EquipmentController equipmentController = new EquipmentController();
        RequestController requestController = new RequestController();
        RoomsController roomsController = new RoomsController();

        public RequestRegister()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            String eqID = Convert.ToString(tb_id);
            RoomsType roomsType = (RoomsType)cbox.SelectedItem;
            DateTime dateTime = (DateTime)date_move.SelectedDate;
            RequestEquipmentcs requestEquipmentcs = new RequestEquipmentcs(eqID, roomsType, dateTime);
            requestController.Create(requestEquipmentcs);
            // DGM.Items.Refresh();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

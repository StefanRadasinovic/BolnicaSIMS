using Bolnica.Controller;
using Bolnica.Manager;
using Model;
using System.Windows;

namespace Bolnica.View
{
    /// <summary>
    /// Interaction logic for MoveRequestView.xaml
    /// </summary>
    public partial class MoveRequestView : Window
    {
        EquipmentController equipmentController = new EquipmentController();
        RequestController requestController = new RequestController();
        RoomsController roomsController = new RoomsController();

        public MoveRequestView()
        {
            InitializeComponent();
            DGM.ItemsSource = requestController.ReadAll();
            //cbox.ItemsSource = equipmentController.ReadAll();
            //cbox.DisplayMemberPath = ("id");
            // cbox.ItemsSource= Enum.GetValues(typeof(RoomsType));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            RequestRegister requestRegister = new RequestRegister();
            requestRegister.Show();
            this.Close();


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            /* String eqName = Convert.ToString(tb_id);
             requestController.Delete(eqName);
             DGM.Items.Refresh();*/

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            EquipmentView equipmentView = new EquipmentView();
            equipmentView.Show();
            this.Close();
        }

        private void Soba(object sender, RoutedEventArgs e)
        {

            RoomsController roomsController = new RoomsController();
            RoomView roomView = new RoomView();
            roomView.Show();
            this.Close();
        }

        private void Oprema(object sender, RoutedEventArgs e)
        {
            EquipmentController equipmentController = new EquipmentController();
            EquipmentView equipmentView = new EquipmentView();
            equipmentView.Show();
            this.Close();
        }

        private void Lekovi(object sender, RoutedEventArgs e)
        {

        }

        private void Anketa(object sender, RoutedEventArgs e)
        {

        }

    }
}

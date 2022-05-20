using Bolnica.View;
using Model;
using System.Collections.ObjectModel;
using System.Windows;

namespace Bolnica.Manager
{
    /// <summary>
    /// Interaction logic for ManagerView.xaml
    /// </summary>
    public partial class RoomView : Window
    {

        private RoomRepository room = new RoomRepository();
        private RoomsController rc = new RoomsController();

        public static ObservableCollection<Rooms> Room { get; set; }
        public RoomView()
        {
            InitializeComponent();
            //this.DataContext = this;
            /* foreach (Rooms r in rc.GetAll())
             {
                 Room.Add(r);


                // MessageBox.Show(r.RoomName);
             }

             DGR.ItemsSource = rc.GetAll();*/

            this.DataContext = this;

            Room = new ObservableCollection<Rooms>();

            DGR.ItemsSource = Room;
            //RoomsController roomsController = new RoomsController();

            foreach (Rooms r in rc.GetAll())
            {
                Room.Add(r);
            }

            DGR.Items.Refresh();




        }
        public void Refresh()
        {
            DGR.Items.Refresh();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RoomRegister roomRegister = new RoomRegister();
            roomRegister.Show();
            // DGR.Items.Refresh();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            if (DGR.SelectedIndex != -1)

            {
                Rooms r = rc.GetRoomID(((Rooms)DGR.SelectedItem).RoomID1);
                rc.Delete(((Rooms)DGR.SelectedItem).RoomID1);
                UpdateRoom up = new UpdateRoom(r);
                up.Show();
                DGR.Items.Refresh();


            }
            else
            {
                MessageBox.Show("You must click on exsiisting Rooms");
            }


        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            if (DGR.SelectedIndex != 1)
            {
                Rooms r = rc.GetRoomID(((Rooms)DGR.SelectedItem).RoomID1);
                rc.Delete(((Rooms)DGR.SelectedItem).RoomID1);
                Room.Remove(((Rooms)DGR.SelectedItem));
                // DGR.Items.Refresh();


            }
            else
            {
                MessageBox.Show("You must click on exsiisting Rooms");
            }


        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
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

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MainWindowManager mainWindowManager = new MainWindowManager();
            mainWindowManager.Show();
            this.Close();

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            ManagerView managerView = new ManagerView();
            managerView.Show();
            this.Close();

        }


    }
}

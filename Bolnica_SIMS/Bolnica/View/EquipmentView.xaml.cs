using Bolnica.View;
using Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Windows;

namespace Bolnica.Manager
{
    /// <summary>
    /// Interaction logic for EquipmentView.xaml
    /// </summary>
    /// 
    public partial class EquipmentView : Window
    {
        EquipmentController equipmentController = new EquipmentController();
        RoomsController roomsController = new RoomsController();


        public static ObservableCollection<Equipment> Equipment { get; set; }
        private static List<Equipment> EquipmentList = new List<Equipment>();

        public EquipmentView()
        {
            InitializeComponent();


            this.DataContext = this;

            Equipment = new ObservableCollection<Equipment>();

            DGE.ItemsSource = Equipment;
            //RoomsController roomsController = new RoomsController();

            foreach (Equipment e in equipmentController.ReadAll())
            {
                Equipment.Add(e);
            }

            DGE.Items.Refresh();



        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {

            EquipmentRegister equipmentRegister = new EquipmentRegister();
            equipmentRegister.Show();
            this.Close();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {


            /* String id = Convert.ToString(tb_id.Text);
             equipmentController.Delete(id);
             DGE.Items.Refresh();*/

            /*
            String id = (String)cbox_e.SelectedItem;
            equipmentController.Delete(id);
            DGE.Items.Refresh();*/
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainWindowManager mainWindowManager = new MainWindowManager();
            mainWindowManager.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MoveRequestView moveRequestView = new MoveRequestView();
            moveRequestView.Show();
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            RenovationView renovation = new RenovationView();
            renovation.Show();
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

        private void Button_Click_6(object sender, RoutedEventArgs e)
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


       /* private void Search_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (filterCombo.SelectedIndex == -1 || filterCombo.SelectedIndex == 2)
            {
                if (searchBox.Text != "")
                {
                    DGE.ItemsSource = equipmentController.ReadAll().Where(x => x.Id.ToLower().Contains(searchBox.Text.ToLower()));
                }
                else
                    DGE.ItemsSource = Equipment;
                    


            }
            else
            {
                if (searchBox.Text != "")
                {
                     DGE.ItemsSource = equipmentController.ReadAll().Where(x => x.Id.ToLower().Contains(searchBox.Text.ToLower()) && (int)x.EquipmentType == filterCombo.SelectedIndex);

                }
                else 
                {
                    DGE.ItemsSource = equipmentController.ReadAll().Where(x => (int)x.EquipmentType == filterCombo.SelectedIndex);


                }
            }

        }*/

        private void filterCombo_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            searchBox.Clear();
            if (filterCombo.SelectedIndex != -1 && filterCombo.SelectedIndex != 2)
            {
                DGE.ItemsSource = equipmentController.ReadAll().Where(x => (int)x.EquipmentType == filterCombo.SelectedIndex);
            }
            else 
            {
                DGE.ItemsSource = Equipment;
            }
        }

        private void SearchBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (filterCombo.SelectedIndex == -1 || filterCombo.SelectedIndex == 2)
            {
                if (searchBox.Text != "")
                {
                    DGE.ItemsSource = equipmentController.ReadAll().Where(x => x.Id.ToLower().Contains(searchBox.Text.ToLower()));
                }
                else
                    DGE.ItemsSource = Equipment;



            }
            else
            {
                if (searchBox.Text != "")
                {
                    DGE.ItemsSource = equipmentController.ReadAll().Where(x => x.Id.ToLower().Contains(searchBox.Text.ToLower()) && (int)x.EquipmentType == filterCombo.SelectedIndex);

                }
                else
                {
                    DGE.ItemsSource = equipmentController.ReadAll().Where(x => (int)x.EquipmentType == filterCombo.SelectedIndex);


                }
            }

        }
    }
}

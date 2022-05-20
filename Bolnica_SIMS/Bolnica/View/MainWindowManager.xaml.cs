using Bolnica.View;
using Model;
using System.Windows;

namespace Bolnica.Manager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindowManager : Window
    {

        public MainWindowManager()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RoomsController roomsController = new RoomsController();
            RoomView roomView = new RoomView();
            roomView.Show();
            this.Close();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            EquipmentController equipmentController = new EquipmentController();
            EquipmentView equipmentView = new EquipmentView();
            equipmentView.Show();
            this.Close();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MedicamentView medicamenView = new MedicamentView();
            medicamenView.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}

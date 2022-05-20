using Bolnica.Controller;
using Bolnica.Manager;
using Bolnica.Repository;
using System.Collections.ObjectModel;
using System.Windows;

namespace Bolnica.View
{
    /// <summary>
    /// Interaction logic for MedicamentView.xaml
    /// </summary>
    public partial class MedicamentView : Window
    {
        private MedicamentRepository medicament = new MedicamentRepository();
        private MedicamentController mc = new MedicamentController();
        NevalidationMedicaments nevalidationMedicaments = new NevalidationMedicaments();

        public static ObservableCollection<Medicament> Medicaments { get; set; }

        public MedicamentView()
        {
            InitializeComponent();

            this.DataContext = this;

           Medicaments = new ObservableCollection<Medicament>();

            DGM.ItemsSource = Medicaments;
          

            foreach (Medicament m in mc.GetAll())
            {
                Medicaments.Add(m);
            }

          


        }

        //napraviti listu za nevalidirane lekove koji postaju onda kada se izmeni validirani lek
        //automatski se prebqaci u nevalidirane
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MedicamentRegister medicamentRegister = new MedicamentRegister();
            medicamentRegister.Show();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (DGM.SelectedIndex != -1)

            {
                Medicament m = mc.GetMedicamenID(((Medicament)DGM.SelectedItem).MedicamentID1);
                mc.Delete(((Medicament)DGM.SelectedItem).MedicamentID1);
                UpdateMedicament up = new UpdateMedicament(m);
                up.Show();
                nevalidationMedicaments.DGNVM.Items.Refresh();
                // DGM.Items.Refresh();
                

            }
            else
            {
                MessageBox.Show("You must click on exsiisting Medicaments");
            }

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (DGM.SelectedIndex != -1)

            {
                Medicament m = mc.GetMedicamenID(((Medicament)DGM.SelectedItem).MedicamentID1);
                mc.Delete(((Medicament)DGM.SelectedItem).MedicamentID1);
                Medicaments.Remove(m);
              //  MessageBox.Show(m.MedicamentName1);
                // DGM.Items.Refresh();

            }
            else
            {
                MessageBox.Show("You must click on exsiisting Medicaments");
            }

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MainWindowManager mainWindowManager = new MainWindowManager();
            mainWindowManager.Show();
            this.Close();

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            NevalidationMedicaments nevalidationMedicaments = new NevalidationMedicaments();
            nevalidationMedicaments.Show();
            this.Close();
        }
    }
}

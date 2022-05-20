using Bolnica.Controller;
using Bolnica.Manager;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for UpdateMedicament.xaml
    /// </summary>
    public partial class UpdateMedicament : Window
    {
        MedicamentController medicamentController = new MedicamentController();
        // public RoomsController rc = new RoomsController();
        // private ObservableCollection<Medicament> Medicament;
       

        
        public UpdateMedicament(Medicament m)
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


            string MedicamentID = Convert.ToString(tb_id.Text);
            String MedicamentName = Convert.ToString(tb_floor.Text);
            MedicamentsType MedicamentType = (MedicamentsType)cbox.SelectedIndex;
            String Substances = Convert.ToString(tb_sub.Text);
            MedicamentCategoria MedicamentsCategoria = (MedicamentCategoria)cbox_categoria.SelectedIndex;
            Medicament medicaments = new Medicament(MedicamentID, MedicamentName, MedicamentType, Substances, MedicamentsCategoria);
            medicamentController.Update(medicaments);
           // MessageBox.Show("Prikazi");
            this.Close();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

using Bolnica.Controller;
using Bolnica.Manager;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;

namespace Bolnica.View
{
    /// <summary>
    /// Interaction logic for MedicamentRegister.xaml
    /// </summary>
    public partial class MedicamentRegister : Window
    {
        MedicamentController medicamentController = new MedicamentController();
        private List<Medicament> medicaments = new List<Medicament>();
        private ObservableCollection<Medicament> medicament;
        //private Medicament medicament  = new Medicament();

        public MedicamentRegister()
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
            medicamentController.Create(medicaments);
            MedicamentView.Medicaments.Add(medicaments);
            this.Close();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

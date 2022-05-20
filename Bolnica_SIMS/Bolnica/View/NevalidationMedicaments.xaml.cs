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
    /// Interaction logic for NevalidationMedicaments.xaml
    /// </summary>
    public partial class NevalidationMedicaments : Window
    {
        private ObservableCollection<NoValidation> Medicament;
        MedicamentController mc = new MedicamentController();
        NoValidationController noValidation = new NoValidationController();
        public NevalidationMedicaments()
        {
            InitializeComponent();
            DGNVM.ItemsSource = noValidation.GetAll();

            this.DataContext = this;

            Medicament = new ObservableCollection<NoValidation>();

            DGNVM.ItemsSource = Medicament;


            foreach (NoValidation m in noValidation.GetAll())
            {
                Medicament.Add(m);
            }

        }





        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MedicamentView medicamentView = new MedicamentView();
            medicamentView.Show();
            this.Close();
        }
    }
}

using Model;
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
    /// Interaction logic for DoctorViewMain.xaml
    /// </summary>
    public partial class DoctorViewMain : Window
    {
        private static ObservableCollection<Operation> operations;

        public static ObservableCollection<Operation> Operations { get; set; }




        public DoctorViewMain()
        {
            InitializeComponent();

            InitializeComponent();

            this.DataContext = this;

            Operations = new ObservableCollection<Operation>();

            GridDataDoctorView.ItemsSource = Operations;

            foreach (Operation op in OperationService.GetAll())
            {



                Operations.Add(op);
            }


        }



        private void Button_Click(object sender, RoutedEventArgs e) //OVO JE CREATE  
        {
            CreateOperationView create = new CreateOperationView();
            create.Show();


        }

        private void Button_Click_1(object sender, RoutedEventArgs e) //////////OVDE IDE DUGME ZA UPDATE 
        {

            OperationService opService = new OperationService();
            if (GridDataDoctorView.SelectedIndex != -1)
            {

                int id = (((Operation)GridDataDoctorView.SelectedItem).OperationID);


                Operation op = OperationService.GetOperation(id);
                UpdateOperationView updateOperationView = new UpdateOperationView(op);
                updateOperationView.Show();


            }
            else
                MessageBox.Show("You must click on existing Operation");






        }



        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            OperationService operationService = new OperationService();
            if (GridDataDoctorView.SelectedIndex != -1)
            {
                Operation op = OperationService.GetOperation(((Operation)GridDataDoctorView.SelectedItem).OperationID);
                OperationService.Delete(((Operation)GridDataDoctorView.SelectedItem).OperationID);
                Operations.Remove(op);

            }
            else
            {
                MessageBox.Show("You must click on existing Appointment");
            }

        }



        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

            DoctorSelectWindowView mw = new DoctorSelectWindowView();
            this.Close();
            mw.Show();

        }
    }
}

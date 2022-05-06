using Model;
using System;
using System.Collections.Generic;
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
    /// Interaction logic for CreateOperationView.xaml
    /// </summary>
    public partial class CreateOperationView : Window
    {
        //private static int operationID = 0;
        public CreateOperationView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            /* DateTime? date = this.dateStart.SelectedDate;  //// OVDE FORMATIRAS DATUM 

             String format = null;

             if (date.HasValue)
             {
                 format = date.Value.ToString("MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture); ///OVO ZA DATUM SAM SKONTAO 
             }
            */

            Random rnd = new Random();
            int operationID = rnd.Next(1, 200);
            int patientID = Int32.Parse(patient.Text);
            int doctorID = Int32.Parse(doctor.Text);
            int roomID = Int32.Parse(room.Text);

            Operation op = new Operation(operationID, doctorID, dateStart.Text, dateEnd.Text, roomID, patientID);
            OperationController.Create(op);

            DoctorViewMain.Operations.Add(op);

            this.Close();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

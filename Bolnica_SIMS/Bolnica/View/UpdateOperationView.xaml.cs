using Model;
using Service;
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
    /// Interaction logic for UpdateOperationView.xaml
    /// </summary>
    public partial class UpdateOperationView : Window
    {
        private int operationID;

        public UpdateOperationView()
        {
            InitializeComponent();
        }

        public int OperationID { get => operationID; set => operationID = value; }

        
        public UpdateOperationView(Operation op)
        {
            
            patient.Text = op.PatientID.ToString();
            doctor.Text = op.DoctorID.ToString();
            dateStart.Text = op.TimeStart.ToString();
            dateEnd.Text = op.TimeEnd;
            room.Text = op.RoomID.ToString();
            operationID = op.OperationID;
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e) //ovako bi trebalo za update Ali imam problem sa prosledjivanjem parametar u konstruktoru UpdateOperationView(Operation op) koji ne znam da resim(nisam se nikad sretao sa tim)
        {
            
            OperationService ps = new OperationService();
            Operation pom = new Operation(operationID, Int32.Parse(patient.Text), dateStart.Text ,dateEnd.Text, Int32.Parse(doctor.Text), Int32.Parse(room.Text));
            OperationController.Update(pom);

            this.Close();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

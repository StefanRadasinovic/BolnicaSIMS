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

        /*
        public UpdateOperationView(Model.Operation op)
        {
            
            InitializeComponent();
            patient.Text = op.PatientID
            doctor.Text = op.DoctorID
            dateStart.Text = op.DateStart
            dateEnd.Text = op.DateEnd
            room.Text = op.RoomID
            operationID = op.OperationID
        }


        private void Button_Click(object sender, RoutedEventArgs e) //ovako bi trebalo za update Ali imam problem sa prosledjivanjem parametar u konstruktoru UpdateOperationView(Operation op) koji ne znam da resim(nisam se nikad sretao sa tim)
        {
            
            PatientService ps = new PatientService();
            Patient pom = new Patient(name.Text, surname.Text, trenutniJMBG, birthDate.Text, phone.Text, email.Text, username.Text, password.Text);
            ps.UpdatePatient(pom);

            this.Close();

        }
        */
        private void Button_Click(object sender, RoutedEventArgs e)
        {


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

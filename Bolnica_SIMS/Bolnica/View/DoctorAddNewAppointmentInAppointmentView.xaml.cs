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
    /// Interaction logic for DoctorAddNewAppointmentInAppointmentView.xaml
    /// </summary>
    public partial class DoctorAddNewAppointmentInAppointmentView : Window
    {
        PatientService ps = new PatientService();
        Operation currentOp = new Operation(0, 0, "", "", 0, 0);
        Patient currentP;
        public DoctorAddNewAppointmentInAppointmentView(Operation op)
        {
            InitializeComponent();
            currentOp.OperationID = op.OperationID;
            currentOp.PatientID = op.PatientID;
            currentP = ps.GetPatientByJMBG(currentOp.PatientID);
        }
        public int makeID()
        {
            return CreateOperationView.operationID++;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //int patientID = Int32.Parse(patient.Text);
            int doctorID = Int32.Parse(doctor.Text);
            int roomID = Int32.Parse(room.Text);

            Operation op = new Operation(makeID(), doctorID, dateStart.Text, dateEnd.Text, roomID, currentP.Jmbg);
            OperationController.Create(op);

            DoctorViewMain.Operations.Add(op);

            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //DoctorApointmentInProgressView dAiPView = new DoctorApointmentInProgressView();
            this.Close();
        }
    }
}

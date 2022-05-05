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
using Model;
using Service;

namespace Bolnica.View
{
    /// <summary>
    /// Interaction logic for SecretaryAppointmentView.xaml
    /// </summary>
    public partial class SecretaryAppointmentView : Window
    {
        public static ObservableCollection<Appointment> Appointments { get; set; }
        public SecretaryAppointmentView()
        {
            InitializeComponent();
        }
    }
}

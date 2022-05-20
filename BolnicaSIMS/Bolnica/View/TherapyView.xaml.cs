﻿using System;
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
    /// Interaction logic for TherapyView.xaml
    /// </summary>
    public partial class TherapyView : Window
    {
        public TherapyView()
        {
            InitializeComponent();
        }

        public string PatientID { get; private set; }

        private void Button_Back(object sender, RoutedEventArgs e)
        {
           // PatientView patientView = new PatientView(PatientID);
            this.Close();
          //  patientView.Show();

        }

    }
}

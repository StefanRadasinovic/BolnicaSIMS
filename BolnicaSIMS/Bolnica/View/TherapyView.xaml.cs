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
using Bolnica.Model;
using Bolnica.Service;

namespace Bolnica.View
{
    /// <summary>
    /// Interaction logic for TherapyView.xaml
    /// </summary>
    public partial class TherapyView : Window
    {

        public static ObservableCollection<Therapy> Therapys { get; set; }
        public TherapyView()
        {
           

            InitializeComponent();
          //  TherapyService therapyService1 = new TherapyService();
            //List<Therapy> therapies = therapyService1.GetAll();

        
            foreach (Therapy therapy in TherapyService.GetAll())
            {
                Therapys.Add(therapy);
            }
                
            

        }
        
       


        public string PatientID { get; private set; }

        private void Button_Back(object sender, RoutedEventArgs e)
        {
           // PatientView patientView = new PatientView(PatientID);
            this.Close();
          //  patientView.Show();

        }





        



        private void Button_AddNotes(object sender, RoutedEventArgs e)
        {
/*
            TherapyService therapyService = new TherapyService();
            if (GridDataTherapyView.SelectedIndex != -1)
            {

                String change = (((Therapy)GridDataTherapyView.SelectedItem).TherapyID);


                Therapy therapy = therapyService.GetTherapyID(change);

                // AddNotesView addNotesView = new AddNotesView(therapy);
                AddNotesView addNotesView = new AddNotesView();
                addNotesView.Show();


             

            }
            else
                MessageBox.Show("You must click on existing Appointment");
*/

        }











    }
}

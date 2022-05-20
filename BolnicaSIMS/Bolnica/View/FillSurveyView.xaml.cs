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
using Model;

namespace Bolnica.View
{
    /// <summary>
    /// Interaction logic for FillSurveyView.xaml
    /// </summary>
    public partial class FillSurveyView : Window
    {
        public FillSurveyView(Operation forSurvey)
        {
            InitializeComponent();
        }
    }
}

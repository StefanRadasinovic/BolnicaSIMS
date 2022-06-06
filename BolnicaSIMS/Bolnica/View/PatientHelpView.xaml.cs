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
    /// Interaction logic for HelpView.xaml
    /// </summary>
    public partial class HelpView : Window
    {
        public HelpView()
        {
            InitializeComponent();
        }
    }
}


/*
 * <ComboBox   HorizontalAlignment="Center" Name="Combobox" Height="23" Width="40" Background="LightGray">
                <ComboBoxItem Width="125" Background="Transparent">
                    <Button Content="Manage Profile" HorizontalContentAlignment="Center" Width="120" Background="LightGray" Click="Button_Back"></Button>

                </ComboBoxItem>

                <Separator Width="143"  />
                <ComboBoxItem Width="125" Background="Transparent">
                    <Button Content="Log Out" HorizontalContentAlignment="Center" Click="Button_Back" Width="120" Background="LightGray"></Button>
                </ComboBoxItem>

            </ComboBox>
 * */
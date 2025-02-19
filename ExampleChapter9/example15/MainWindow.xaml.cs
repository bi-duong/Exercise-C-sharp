﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace example15
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cboColor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var stackPanel = (StackPanel)cboColor.SelectedItem;
            var label = stackPanel.Children[1] as Label;
                string color = label.Content.ToString();
                lbMsg.Content = "Your color is "+color;
        }
    }
}

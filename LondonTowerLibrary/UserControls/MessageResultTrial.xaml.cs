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
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LondonTowerLibrary.UserControls
{
    /// <summary>
    /// Logique d'interaction pour MessageResultTrial.xaml
    /// </summary>
    public partial class MessageResultTrial : UserControl
    {
        public MessageResultTrial()
        {
            InitializeComponent();
            this.VerticalAlignment=VerticalAlignment.Bottom;
            Margin = new Thickness(0, 0, 0, 50);
        }
    }
}

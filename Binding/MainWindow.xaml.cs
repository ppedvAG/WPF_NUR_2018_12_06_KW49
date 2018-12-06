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

namespace Binding
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Für die explizite Aktualisierung muss eine BindingExpression im CodeBehind erstellt werden und über die Methode
            //UpdateSource() angefordert werden
            BindingExpression be = this.tbxFünf.GetBindingExpression(TextBox.TextProperty);
            be.UpdateSource();
            be.UpdateTarget();
        }
    }
}

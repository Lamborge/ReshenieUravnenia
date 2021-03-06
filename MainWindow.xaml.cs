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

namespace ReshenieUravnenia
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ResButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double a = Convert.ToSingle(Abox.Text);
                double b = Convert.ToSingle(Bbox.Text);
                double c = Convert.ToSingle(Cbox.Text);
                double D = (b * b) - 4 * a * c;
                double X1 = (-b + Math.Sqrt(D)) / (2 * a);
                double X2 = (-b - Math.Sqrt(D)) / (2 * a);

                Dres.Text = Convert.ToString(D);
                X1res.Text = Convert.ToString(X1);
                X2res.Text = Convert.ToString(X2);
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так");
            }

        }
    }
}

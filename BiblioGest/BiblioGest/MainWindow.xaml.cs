﻿using System.Windows;

namespace BiblioGest
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Tu as cliqué le bouton 🚀", "Message");
        }
    }
}
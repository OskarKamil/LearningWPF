﻿using DataBindingStudy.src.ViewModels;
using System.Windows;

namespace DataBindingStudy
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }

        private void AddEmployee_Click(object sender, RoutedEventArgs e)
        {
        }

        private void ButtonChangeDetails_Click(object sender, RoutedEventArgs e)
        {
        }

        private void ButtonDeleteEmployee_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
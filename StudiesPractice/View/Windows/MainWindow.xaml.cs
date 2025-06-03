﻿using StudiesPractice.Core;
using StudiesPractice.View.Pages;
using StudiesPractice.ViewModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StudiesPractice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly MainWindowViewModel _viewModel;
        public MainWindow()
        {
            InitializeComponent();

            DataContext = _viewModel = new();

            FrameManager.MainFrame = mainFrame;
            FrameManager.SetSource(new CalculatePage());
        }
    }
}
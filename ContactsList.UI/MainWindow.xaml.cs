﻿using System.Windows;
using ContactsList.UI.ViewModels;

namespace ContactsList.UI;

public partial class MainWindow : Window
{
    private MainViewModel _viewModel;
    public MainWindow(MainViewModel viewModel)
    {
        InitializeComponent();
        _viewModel = viewModel;
        DataContext = _viewModel;
        Loaded += MainWindow_Loaded;
    }

    private void MainWindow_Loaded(object sender, RoutedEventArgs e)
    {
        _viewModel.LoadPersons();
    }
}
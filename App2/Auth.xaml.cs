﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using DataVisualization.Views;
using Windows.UI;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml.Media.Imaging;

namespace DataVisualization
{


    public sealed partial class Auth : Page
    {
        public Auth()
        {
            this.InitializeComponent();
        }

        public void Login_Click(object sender, RoutedEventArgs e)
        {
            if (UserName.Text=="" && PassWord.Password == "")
            {
                txtWarning.Text = "Please enter username and password.";
            } else if(UserName.Text == "") {
                txtWarning.Text = "Please enter username";
            } else if (PassWord.Password == "")
            {
                txtWarning.Text = "Please enter password.";
            } else
            {
                this.Frame.Navigate(typeof(MainIndex));
            }

        }


        private void UserName_GotFocus(object sender, RoutedEventArgs e)
        {
            UserName.Text = "";
            SolidColorBrush Brush1 = new SolidColorBrush();
            Brush1.Color = Windows.UI.Colors.Black;
            UserName.Foreground = Brush1;
        }

        private void UserName_LostFocus(object sender, RoutedEventArgs e)
        {
            if (UserName.Text == String.Empty)
            {
                UserName.Text = "Enter username.. ";
                SolidColorBrush Brush2 = new SolidColorBrush();
                Brush2.Color = Windows.UI.Colors.Gray;
                UserName.Foreground = Brush2;
            }
        }

        private void PassWord_GotFocus(object sender, RoutedEventArgs e)
        {
            PassWord.Password = "";
            SolidColorBrush Brush1 = new SolidColorBrush();
            Brush1.Color = Windows.UI.Colors.Black;
            PassWord.Foreground = Brush1;
        }

        private void PassWord_LostFocus(object sender, RoutedEventArgs e)
        {
            if (PassWord.Password == String.Empty)
            {
                PassWord.Password = "Enter Password..";
            }
        }
    }
}

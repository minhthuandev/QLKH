﻿using QLKH.Business;
using System;
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

namespace QLKH
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            var result = BusinessLogin.Instance.UserLogin(tbxUsername.Text, tbxPassword.Password);
            if (result.Success)
            {

            }
            else
            {
                MessageBox.Show(result.Message, result.Caption, result.MessageButton, result.MessageImage);
            }
        }
    }
}

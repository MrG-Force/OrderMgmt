﻿using System.Windows;
using System.Windows.Controls;

namespace OrderMgmtSystem.Views
{
    /// <summary>
    /// Interaction logic for OrderDetailsView.xaml
    /// </summary>
    public partial class OrderDetailsView : UserControl
    {
        public OrderDetailsView()
        {
            InitializeComponent();
        }

        private void BackToOrders_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new OrdersMainView());
        }
    }
}

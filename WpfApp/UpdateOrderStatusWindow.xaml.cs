using BusinessLogic;
using Repositories;
using Responsitories;
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
using System.Windows.Shapes;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for ChangePasswordWindow.xaml
    /// </summary>
    public partial class UpdateOrderStatusWindow : Window
    {
        private readonly IOrderResponsitoriescs _orderResponsitoriescs;
        private int orderId { get; set; }
        public UpdateOrderStatusWindow(int orderId)
        {
            InitializeComponent();
            _orderResponsitoriescs = new OrderResponsitories();
            this.orderId = orderId;
            txtOrderId.Text = orderId.ToString();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cboStatus.ItemsSource = Enum.GetValues(typeof(OrderStatus));
        }
        private async void Confirm_Click(object sender, RoutedEventArgs e)
        {
            var order = await _orderResponsitoriescs.GetOrder(orderId);
            if (cboStatus.SelectedItem == null)
            {
                bool? Result = new MessageBoxCustom("Please select a status", MessageType.Error, MessageButtons.Ok).ShowDialog();
            }

            if (Enum.TryParse(cboStatus.SelectedValue.ToString(), out OrderStatus selectedStatus))
            {
                order.OrderStatus = selectedStatus;
                await _orderResponsitoriescs.UpdateOrder(order);
                this.Close();

                bool? result = new MessageBoxCustom("Change status successfully", MessageType.Info, MessageButtons.Ok).ShowDialog();
            }
            else
            {
                bool? result = new MessageBoxCustom("Invalid status selected", MessageType.Error, MessageButtons.Ok).ShowDialog();
            }
        }
        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

      
    }
}

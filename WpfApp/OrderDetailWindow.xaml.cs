using BusinessLogic;
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
    /// Interaction logic for OrderDetailWindow.xaml
    /// </summary>
    public partial class OrderDetailWindow : Window
    {
        private readonly IOrderResponsitoriescs _orderResponsitories;
        private int _orderId;
        public OrderDetailWindow(int OrderId)
        {
            InitializeComponent();
            _orderResponsitories = new OrderResponsitories();
            _orderId = OrderId;
        }

       private async void LoadOrder()
        {
            var order = await _orderResponsitories.GetOrder(_orderId);
            DataContext = order;
        }

       
        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadOrder();
        }
    }
}

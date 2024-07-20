using BusinessLogic;
using Repositories;
using Responsitories;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly ICategoryResponsitories _categoryResponsitories;
        private readonly IOrderResponsitoriescs _orderResponsitories;
        private readonly IProductResponsitories _productResponsitories;
        private readonly ICategoryResponsitories categoryResponsitories;

        public AdminWindow()
        {
            InitializeComponent();
            _customerRepository = new CustomerRepository();
            _categoryResponsitories = new CategoryResponsitories();
            _orderResponsitories = new OrderResponsitories();
            _productResponsitories = new ProductResponsitories();
            _categoryResponsitories = new CategoryResponsitories();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadCustomer();
            LoadCategories();
            LoadOrders();
            LoadProducts();
        }

        private async void LoadCustomer()
        {
            dtg_allCustomer.ItemsSource = await _customerRepository.GetCustomers();
        }

        private async void LoadCategories()
        {
            dtg_allCategories.ItemsSource = await _categoryResponsitories.GetCategorys();
        }

        private async void LoadProducts()
        {
            dtg_allProduct.ItemsSource = await _productResponsitories.GetProducts();
        }

        private async void LoadOrders()
        {
            dtgAllOrders.ItemsSource = await _orderResponsitories.GetOrders();
        }
        private void ViewDetail_Click(object sender, RoutedEventArgs e)
        {
            var selectedOrder = ((Button)sender).DataContext as Order; // Replace YourOrderClass with your actual order class

            if (selectedOrder != null)
            {
                OrderDetailWindow orderDetailsWindow = new OrderDetailWindow(selectedOrder.OrderId);


                orderDetailsWindow.Show();
            }
        }

        private void LogOut_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }

        private async void Disable_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            bool? Result = new MessageBoxCustom("Confirm to disable this user? ", MessageType.Confirmation, MessageButtons.YesNo).ShowDialog();
            if (Result == true)
            {
                if (button != null)
                {
                    // Access the product from the button's DataContext
                    var customer = button.DataContext as Customer; // Replace YourProductType with your actual product type
                    if (customer != null)
                    {
                        var customerFind = await _customerRepository.GetCustomer(customer.CustomerId);
                        customerFind.IsDisabled = !customer.IsDisabled;
                        await _customerRepository.UpdateCustomer(customer);
                    }
                    LoadCustomer();
                }
            }
        }
     
        private void UpdateOrderStatus_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                // Access the product from the button's DataContext
                var order = button.DataContext as Order; // Replace YourProductType with your actual product type
                if (order != null)
                {
                    UpdateOrderStatusWindow updateOrderStatusWindow = new UpdateOrderStatusWindow(order.OrderId);
                    updateOrderStatusWindow.Closed += UpdateOrderStatusWindow_Closed;
                    updateOrderStatusWindow.ShowDialog();
                }
            }
        }

        private void UpdateOrderStatusWindow_Closed(object? sender, EventArgs e)
        {
            LoadOrders();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void AddProduct_Click(object sender, RoutedEventArgs e)
        {
                    AddProductWindow addProductWindow = new AddProductWindow();
                    addProductWindow.Closed += AddProductWindow_Closed;
                    addProductWindow.ShowDialog();
              
        }

        private void AddProductWindow_Closed(object? sender, EventArgs e)
        {
            LoadProducts();
        }

        private void UpdateProduct_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                var product = button.DataContext as Product; 
                if (product != null)
                {
                    UpdateProductWindow updateProduct = new UpdateProductWindow(product.ProductId);
                    updateProduct.Closed += AddProductWindow_Closed;
                    updateProduct.ShowDialog();
                }
            }
        }

        private async void DeleteProduct_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                bool? Result = new MessageBoxCustom("Confirm to delete this product? ", MessageType.Confirmation, MessageButtons.YesNo).ShowDialog();
                if (Result == true)
                {
                    var product = button.DataContext as Product;
                    var productFind = _productResponsitories.GetProduct(product.ProductId);
                    await _productResponsitories.DeleteProduct(product);
                }
               LoadProducts();
            }
        }

        private void AddCateWindow_Closed(object? sender, EventArgs e)
        {
            LoadCategories();
        }
        private void AddCate_Click(object sender, RoutedEventArgs e)
        {
            AddCategoryWindow addProductWindow = new AddCategoryWindow();
            addProductWindow.Closed += AddCateWindow_Closed;
            addProductWindow.ShowDialog();
        }

        private void UpdateCate_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                var product = button.DataContext as Category;
                if (product != null)
                {
                    UpdateCategoryWindow updateProduct = new UpdateCategoryWindow(product.CategoryId);
                    updateProduct.Closed += AddCateWindow_Closed;
                    updateProduct.ShowDialog();
                }
            }
        }

        private async void DeleteCate_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                bool? Result = new MessageBoxCustom("Confirm to delete this category? ", MessageType.Confirmation, MessageButtons.YesNo).ShowDialog();
                if (Result == true)
                {
                    var product = button.DataContext as Category;
                    await _categoryResponsitories.DeleteCategory(product.CategoryId);
                }
                LoadCategories();
            }
        }
    }
}

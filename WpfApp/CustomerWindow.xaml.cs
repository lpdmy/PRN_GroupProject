using BusinessLogic;
using MaterialDesignThemes.Wpf;
using Repositories;
using Responsitories;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for CustomerWindow.xaml
    /// </summary>

    public partial class CustomerWindow : Window
    {
        private readonly ICategoryResponsitories _categoryResponsitories;
        private readonly IProductResponsitories _productResponsitories;
        private readonly IOrderResponsitoriescs _orderResponsitoriescs;
        private readonly IOrderProductResponsitories _orderProductResponsitoriescs;
        private readonly ICustomerRepository _customerRepository;

        public Customer CurrentCustomer { get; set; }
        public int customerId { get; set; }
        public double TotalPrice { get; set; } = 0;
        public List<Product> Products { get; set; } = new List<Product>();
        public List<OrderProduct> CurrentOrderList { get; set; } = new List<OrderProduct>();

        public List<Order> HistoryOrders { get; set; } = new List<Order>();

        public CustomerWindow(int CustomerId)
        {
            InitializeComponent();
            customerId = CustomerId;
            _categoryResponsitories = new CategoryResponsitories();
            _productResponsitories = new ProductResponsitories();
            _orderResponsitoriescs = new OrderResponsitories();
            _orderProductResponsitoriescs = new OrderProductResponsitories();
            _customerRepository = new CustomerRepository();
        }
        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Products = await GetProductsFromDatabase();
            LoadProducts();
            LoadCategories();
            LoadTotalPrice();
            LoadHistoryOrder();
            LoadCurrentUser();
        }

        private async void LoadProducts()
        {
            dtgProducts.ItemsSource = Products;
            DataContext = this; 
        }

        private async void LoadCurrentUser()
        {
            CurrentCustomer = await _customerRepository.GetCustomer(customerId);
            string securePass = "";
            for (int i = 0; i < CurrentCustomer.Password.Length; i++) {
                securePass = securePass + "*";
            }
            txtPassword.Text = securePass;

            txtEmail.Text = CurrentCustomer.Email;
            txtUserName.Text = CurrentCustomer.UserName;
            DataContext = this;

        }


        private async void LoadCategories()
        {
            cboCategory.ItemsSource = await _categoryResponsitories.GetCategorys();
            cboCategory.SelectedValuePath = "CategoryId";
            cboCategory.DisplayMemberPath = "CategoryName";
        }

        private async void LoadTotalPrice()
        {
            runTotalPrice.Text = TotalPrice.ToString();
        }
        private void LoadCurrentOrder()
        {
            dtg_currentOrder.ItemsSource = CurrentOrderList.ToList();
        }

        private async void LoadHistoryOrder()
        {
            dtg_historyOrder.ItemsSource = await _orderResponsitoriescs.GetAllOrdersByCustomerId(customerId);
        }


        private async Task<List<Product>> GetProductsFromDatabase()
        {
            return (await _productResponsitories.GetProducts()).ToList();
        }



        private void AddToCart_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                var product = button.DataContext as Product; // Replace YourProductType with your actual product type

                if (product != null)
                {
                    var numericUpDown = FindNumericUpDown(button);
                    if (numericUpDown != null)
                    {
                        int quantity = (int)numericUpDown.Value;
                        var totalPrice = quantity * product.Price;

                        var data = new { Product = product, Quantity = quantity };
                        bool? Result = new MessageBoxCustom("You have add product to cart ", MessageType.Info, MessageButtons.Ok).ShowDialog();

                       var existingOrderProduct = CurrentOrderList.FirstOrDefault(op => op.ProductId == product.ProductId);

                        if (existingOrderProduct != null)
                        {
                            existingOrderProduct.Quantity += quantity;
                            existingOrderProduct.TotalPrice += totalPrice;
                        }
                        else
                        {
                            CurrentOrderList.Add(new OrderProduct
                            {
                                Product = product,
                                Quantity = quantity,
                                ProductId = product.ProductId,
                                TotalPrice = totalPrice
                            });
                            TotalPrice = TotalPrice + totalPrice;
                            LoadTotalPrice();
                        }
                        LoadCurrentOrder();
                        numericUpDown.Value = 1;
                    }
                }
            }
        }


     
        private void DeleteOrderProduct_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                // Access the product from the button's DataContext
                var product = button.DataContext as OrderProduct; // Replace YourProductType with your actual product type
                if (product != null)
                {
                    var orderProduct = CurrentOrderList.FirstOrDefault(x => x.OrderProductId == product.OrderProductId);
                    CurrentOrderList.Remove(orderProduct);
                    TotalPrice = TotalPrice - orderProduct.TotalPrice;
                    LoadTotalPrice();
                }
                LoadCurrentOrder();
            }
        }

        private void CancelOrder_Click(object sender, RoutedEventArgs e)
        {
            ClearOrder();
        }
        private void ClearOrder()
        {
            CurrentOrderList.Clear();
            LoadCurrentOrder();
            TotalPrice = 0;
            LoadTotalPrice();
        }
        private NumericUpDown FindNumericUpDown(Button button)
        {
          
            var parentStackPanel = VisualTreeHelper.GetParent(button) as StackPanel;
            foreach (var child in parentStackPanel.Children)
            {
                if (child is NumericUpDown)
                {
                    return (NumericUpDown)child;
                }
            }
            return null;
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

      
        private async void SearchProduct_Click(object sender, RoutedEventArgs e)
        {
            if (cboCategory.SelectedValue !=null)
            {
                var cateId = (int)cboCategory.SelectedValue;
                var searchInput = txtSearchInput.Text;
                var products = await _productResponsitories.SearchProducts(cateId, searchInput);
                Products = products;
                LoadProducts();
            }
        }
    

        private async void CloseSearchProduct_Click(object sender, RoutedEventArgs e)
        {
            Products = await GetProductsFromDatabase();
            cboCategory.SelectedValue = null;
            LoadProducts();
        }

        private async void ConfirmOrder_Click(object sender, RoutedEventArgs e)
        {

            bool? Result = new MessageBoxCustom("Confirm confirm order ", MessageType.Confirmation, MessageButtons.YesNo).ShowDialog();
            if (Result == true)
            {
                var order = new Order
                {
                    CustomerId = customerId,
                    OrderDate = DateTime.Now,
                    OrderStatus = OrderStatus.Pending,
                    TotalPrice = TotalPrice,
                    
                };

                await _orderResponsitoriescs.InsertOrder(order);
                foreach (var orderProduct in CurrentOrderList)
                {
                   
                        orderProduct.OrderId = order.OrderId;
                    orderProduct.Product = null;
                        await _orderProductResponsitoriescs.InsertOrderProduct(orderProduct);
                   
                    
                }
                LoadHistoryOrder();
                ClearOrder();

            }
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

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mainWindow  = new MainWindow();
            mainWindow.Show();
        }

        private void ChangePassword_Click(object sender, RoutedEventArgs e)
        {

            ChangePasswordWindow changePasswordWindow = new ChangePasswordWindow(customerId);
            changePasswordWindow.Closed += ChangePasswordWindow_Closed; // Đăng ký sự kiện Closed
            changePasswordWindow.ShowDialog();

        }
        private void ChangePasswordWindow_Closed(object sender, EventArgs e)
        {
            LoadCurrentUser();
        }

        private void UpdateInfo_Click(object sender, RoutedEventArgs e)
        {
            UpdateUserInformationWindow updateUserInformation = new UpdateUserInformationWindow(customerId);
            updateUserInformation.Closed += ChangePasswordWindow_Closed; // Đăng ký sự kiện Closed
            updateUserInformation.ShowDialog();
        }
    }
}

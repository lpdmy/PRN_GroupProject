using BusinessLogic;
using Repositories;
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

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string userNameConfig = App.Configuration["Admin:UserName"];
        private string passwordConfig = App.Configuration["Admin:Password"];
        private ICustomerRepository _customerRepository;
        public MainWindow()
        {
            InitializeComponent();
            _customerRepository = new CustomerRepository();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            VisualStateManager.GoToElementState(RightSection, "LoginState", true);
        }

        private void SignUpButton_Click(object sender, RoutedEventArgs e)
        {
            VisualStateManager.GoToElementState(RightSection, "SignUpState", true);
        }

        private async void SignInButtonReal_Click(object sender, RoutedEventArgs e)
        {
            var userName = txtUsernameLogin.Text;
            var password = pwdPasswordLogin.Password;
            if (userName != null && password != null)
            {
                if (userName.Equals(userNameConfig) && password.Equals(passwordConfig))
                {
                    this.Hide();
                    AdminWindow adminWindow = new AdminWindow();
                    adminWindow.Show();
                }
                else
                {
                    try
                    {
                        var customer = await _customerRepository.LogIn(userName, password);
                        if (customer != null)
                        {
                            this.Hide();
                            CustomerWindow customerWindow = new CustomerWindow(customer.CustomerId);
                            customerWindow.Show();
                        }
                    }
                    catch (Exception ex)
                    {
                        bool? Result = new MessageBoxCustom(ex.Message, MessageType.Error, MessageButtons.Ok).ShowDialog();
                        
                    }
                }
            }
        }

        private async void SignUpRealButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtUserNameSignUp.Text) || string.IsNullOrWhiteSpace(txtPasswordSignUp.Password) || string.IsNullOrWhiteSpace(txtConfirmPasswordSignUp.Password) || string.IsNullOrWhiteSpace(txtEmailSignUp.Text))
                {
                    bool? Result = new MessageBoxCustom("Fill all field for signing up", MessageType.Error, MessageButtons.Ok).ShowDialog();
                    return;
                }

                if (!txtPasswordSignUp.Password.Equals(txtConfirmPasswordSignUp.Password))
                {
                    bool? Result = new MessageBoxCustom("Confirm password wrong.", MessageType.Error, MessageButtons.Ok).ShowDialog();
                    return;
                }

                var Customer = new Customer
                {
                    UserName = txtUserNameSignUp.Text,
                    Password = txtPasswordSignUp.Password,
                    Email = txtEmailSignUp.Text,
                    IsDisabled = false,
                };
                var customer = await _customerRepository.SignUp(Customer);
                if (customer != null)
                {
                    this.Hide();
                    CustomerWindow customerWindow = new CustomerWindow(customer.CustomerId);
                    customerWindow.Show();
                }
            }
            catch (Exception ex) { 
                    bool? Result = new MessageBoxCustom(ex.Message, MessageType.Error, MessageButtons.Ok).ShowDialog();

            }

        }
    }
}
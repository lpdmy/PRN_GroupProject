using BusinessLogic;
using Repositories;
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
    public partial class UpdateUserInformationWindow : Window
    {
        private readonly ICustomerRepository _customerRepository;
        private int customerId { get; set; }
        public UpdateUserInformationWindow(int customerId)
        {
            InitializeComponent();
            _customerRepository = new CustomerRepository();
            this.customerId = customerId;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadCustomer();
        }

        private async void LoadCustomer()
        {
            var customer = await _customerRepository.GetCustomer(customerId);
            txtEmail.Text = customer.Email;
            txtUserName.Text = customer.UserName;
        }
        private async void Confirm_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var customer = await _customerRepository.GetCustomer(customerId);
                if (txtEmail.Text.Equals("") || txtUserName.Text.Equals(""))
                {
                    bool? Result = new MessageBoxCustom("Fill all field", MessageType.Error, MessageButtons.Ok).ShowDialog();
                }
                else
                {
                    customer.Email = txtEmail.Text;
                    customer.UserName = txtUserName.Text;
                    await _customerRepository.UpdateCustomer(customer);
                    this.Close();

                    bool? Result = new MessageBoxCustom("Update successfully", MessageType.Info, MessageButtons.Ok).ShowDialog();
                }
            }
            catch (Exception ex) {
                bool? Result = new MessageBoxCustom("Email or username already exist", MessageType.Error, MessageButtons.Ok).ShowDialog();
            }
           
        }
        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

       
    }
}

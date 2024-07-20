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
    public partial class ChangePasswordWindow : Window
    {
        private readonly ICustomerRepository _customerRepository;
        private int customerId {  get; set; }
        public ChangePasswordWindow(int customerId)
        {
            InitializeComponent();
            _customerRepository = new CustomerRepository();
            this.customerId = customerId;
        }
      
        private async void Confirm_Click(object sender, RoutedEventArgs e)
        {
            var customer = await _customerRepository.GetCustomer(customerId);
            if (txtConfirmPassword.Password.Equals("") || txtNewPassword.Password.Equals("") || txtOldPassword.Equals("") )
            {
                bool? Result = new MessageBoxCustom("Fill all field", MessageType.Error, MessageButtons.Ok).ShowDialog();
            }
            else if (!txtConfirmPassword.Password.Equals(txtNewPassword.Password)) {
                bool? Result = new MessageBoxCustom("Confirm password wrong", MessageType.Error, MessageButtons.Ok).ShowDialog();
            }
            else if (!txtOldPassword.Password.Equals(customer.Password))
            {
                bool? Result = new MessageBoxCustom("Old password wrong", MessageType.Error, MessageButtons.Ok).ShowDialog();
            } else
            {
                customer.Password = txtNewPassword.Password;
                await _customerRepository.UpdateCustomer(customer);
                this.Close();

                bool? Result = new MessageBoxCustom("Change password successfully", MessageType.Info, MessageButtons.Ok).ShowDialog();
            }
        }
        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}

using BusinessLogic;
using Microsoft.Win32;
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
    public partial class AddProductWindow : Window
    {
        private readonly IProductResponsitories _productResponsitories;
        private readonly ICategoryResponsitories _categoryResponsitories;
        private int customerId { get; set; }
        public AddProductWindow()
        {
            InitializeComponent();
            _productResponsitories = new ProductResponsitories();
            _categoryResponsitories = new CategoryResponsitories();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadCategory();
        }

        private async void LoadCategory()
        {
            cboCategory.ItemsSource = await _categoryResponsitories.GetCategorys();
            cboCategory.SelectedValuePath = "CategoryId";
            cboCategory.DisplayMemberPath = "CategoryName";
        }


        private async void Confirm_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Product Name cannot be empty.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Description cannot be empty.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (!double.TryParse(txtPrice.Text, out double price) || price <= 0)
            {
                MessageBox.Show("Invalid Price.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtImagePath.Text))
            {
                MessageBox.Show("Please select an Image.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            Product newProduct = new Product
            {
                ProductName = txtProductName.Text,
                Description = txtDescription.Text,
                Price = price,
                CategoryId = (int) cboCategory.SelectedValue, 
                ImagePath = txtImagePath.Text,
                
            };
            await _productResponsitories.InsertProduct(newProduct);
            this.Close();

            bool? result = new MessageBoxCustom("Insert product successfully", MessageType.Info, MessageButtons.Ok).ShowDialog();

        }
        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Browse_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png|All files (*.*)|*.*";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

            if (openFileDialog.ShowDialog() == true)
            {
                txtImagePath.Text = openFileDialog.FileName;
                DisplayImagePreview(openFileDialog.FileName);
            }
        }
        private void DisplayImagePreview(string filePath)
        {
            try
            {
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.CacheOption = BitmapCacheOption.OnLoad;
                bitmap.UriSource = new Uri(filePath);
                bitmap.EndInit();

                imgPreview.Source = bitmap;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}

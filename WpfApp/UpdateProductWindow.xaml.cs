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
    public partial class UpdateProductWindow : Window
    {
        private readonly IProductResponsitories _productResponsitories;
        private readonly ICategoryResponsitories _categoryResponsitories;
        private int productId { get; set; }
        public UpdateProductWindow(int ProductId)
        {
            InitializeComponent();
            productId= ProductId;
            _productResponsitories = new ProductResponsitories();
            _categoryResponsitories = new CategoryResponsitories();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadCategory();
            LoadProduct();
        }

        private async void LoadCategory()
        {
            cboCategory.ItemsSource = await _categoryResponsitories.GetCategorys();
            cboCategory.SelectedValuePath = "CategoryId";
            cboCategory.DisplayMemberPath = "CategoryName";
        }

        private async void LoadProduct() { 
            var product = await _productResponsitories.GetProduct(productId);
            txtDescription.Text = product.Description;
            txtImagePath.Text = product.ImagePath;
            txtPrice.Text = product.Price.ToString();
            txtProductName.Text = product.ProductName;
            cboCategory.SelectedValue = product.CategoryId;
            DisplayImagePreview(txtImagePath.Text);
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
          
            var oldProduct = await _productResponsitories.GetProduct(productId);
            oldProduct.Description = txtDescription.Text;
            oldProduct.Price = price;
            oldProduct.CategoryId = (int) cboCategory.SelectedValue;
            oldProduct.ImagePath = txtImagePath.Text;
            oldProduct.ProductName = txtProductName.Text;
            await _productResponsitories.UpdateProduct(oldProduct);
            this.Close();

            bool? result = new MessageBoxCustom("Update product successfully", MessageType.Info, MessageButtons.Ok).ShowDialog();

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
            Uri imageUri = new Uri(filePath, UriKind.RelativeOrAbsolute);

            try
            {
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.CacheOption = BitmapCacheOption.OnLoad;
                bitmap.UriSource = imageUri;
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

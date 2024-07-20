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
    public partial class UpdateCategoryWindow : Window
    {
        private readonly ICategoryResponsitories _categoryResponsitories;
        private int _categoryId;
        public UpdateCategoryWindow(int categoryId)
        {
            InitializeComponent();
            _categoryId = categoryId;
            _categoryResponsitories = new CategoryResponsitories();
        }
        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var cate = await _categoryResponsitories.GetCategoryById(_categoryId);
            txtCategoryName.Text = cate.CategoryName;
            txtDescription.Text = cate.CategoryDescription;
        }

        private async void Confirm_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCategoryName.Text))
            {
                MessageBox.Show("Category Name cannot be empty.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Description cannot be empty.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            Category newCategory = await _categoryResponsitories.GetCategoryById(_categoryId);
            newCategory.CategoryDescription = txtDescription.Text;
            newCategory.CategoryName = txtCategoryName.Text;
            await _categoryResponsitories.UpdateCategory(newCategory);
            this.Close();

            bool? result = new MessageBoxCustom("Update category successfully", MessageType.Info, MessageButtons.Ok).ShowDialog();

        }
        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


    }
}

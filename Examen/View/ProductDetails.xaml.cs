using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Examen.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductDetails : ContentPage
    {
        public ProductDetails()
        {
            InitializeComponent();
        }

        Models.Products _product;
        public ProductDetails(Models.Products pro)
        {
            InitializeComponent();
            Title = "Update Product";
            _product = pro;
            nameEntry.Text = pro.Name;
            priceEntry.Text = pro.Price;
            desEntry.Text = pro.Description;
            nameEntry.Focus();
        }
        async void ProDetails(object sender, EventArgs e)
        {
            if ((nameEntry.Text ==null) || (priceEntry.Text == null) || (desEntry == null))
            {
                await DisplayAlert("Inavlid", "Please fill the form!", "OK");
            }
            else if (_product != null)
            {
                UpdateProduct();
            }
            else
                AddNewProduct();
        }

        async void UpdateProduct()
        {
            _product.Name = nameEntry.Text;
            _product.Price = priceEntry.Text;
            _product.Description = desEntry.Text;
            await App.MyDatabase.UpdateProduct(_product);
            Navigation.PopModalAsync();
        }

        async void AddNewProduct()
        {
            await App.MyDatabase.CreateProduct(new Models.Products
            {
                Name = nameEntry.Text,
                Price = priceEntry.Text,
                Description = desEntry.Text
            });
            await Navigation.PopModalAsync();
        }
    }
}
using Examen.Models;
using Examen.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Examen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class shop : ContentPage
    {
        public shop()
        {
            InitializeComponent();

        }
        async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ProductDetails());
        }
        protected override async void OnAppearing()
        {
            try
            {
                base.OnAppearing();
                product.ItemsSource = await App.MyDatabase.ReadProduct();
            }
            catch
            {

            }
        }


        async void SwipeItem_Invoked(object sender, EventArgs e)
        {
            var item = sender as SwipeItem;
            var pro = item.CommandParameter as Products;
            await Navigation.PushModalAsync(new ProductDetails(pro));
        }
        async void SwipeItem_Invoked_1(object sender,EventArgs e)
        {
            var item = sender as SwipeItem;
            var pro = item.CommandParameter as Products;
            var res = await DisplayAlert("Delete",$"Delete{pro.Name} from the database","Yes","No");
            if (res)
            {
                await App.MyDatabase.DeleteProduct(pro);
                product.ItemsSource = await App.MyDatabase.ReadProduct();
            }
        }
        async void txtChanged(object sender, TextChangedEventArgs e)
        {
            product.ItemsSource = await App.MyDatabase.Search(e.NewTextValue);
        }
    }

}

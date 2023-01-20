using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Examen
{
   public partial class home : ContentPage
    {
        public home()
        {
            InitializeComponent();
        }

       void cars(System.Object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new cars());
           
        }
        void iset(System.Object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new iset());
        }
        void shop(System.Object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new shop());
        }
    }
}

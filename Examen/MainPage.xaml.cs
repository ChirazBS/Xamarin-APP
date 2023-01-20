using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Examen
{
   public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        void GotoLogin(System.Object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new login());
        }
        void GotoRegister(System.Object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new inscription());
        }


       
    }
}

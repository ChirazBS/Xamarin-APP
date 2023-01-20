using Examen.Data;
using Examen.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Examen
{
    public partial class login : ContentPage
    {
        User user = new User();
        UserDatabase userDB = new UserDatabase();
        public login()
        {
           InitializeComponent();
        }
        public async void home(object sender, System.EventArgs e)
        {
            if(UserName.Text!= null && Password.Text != null)
            {
                User Vdata = await App.Database.GetUser(UserName.Text, Password.Text);

                if (Vdata.password.Equals(Password.Text) && Vdata.username.Equals(UserName.Text))
                {
                    await DisplayAlert("Login valid", "Welcome ^^", "OK");
                    Navigation.PushModalAsync(new home());

                }
                else
                {
                    await DisplayAlert("Login Failed", "Username or Password Incorrect", "OK");
                  
                }
            }
            else
            {
                await DisplayAlert("He He", "Enter User Name and Password Please", "OK");
            }
           
        }
    }
}

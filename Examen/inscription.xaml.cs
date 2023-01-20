using Examen.Data;
using Examen.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Examen.Data;


namespace Examen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class inscription : ContentPage
    {
        User users = new User();
        UserDatabase userDB = new UserDatabase();
        public inscription()
        {
            InitializeComponent();
           
        }
        public async void GotoLogin(Object sender, EventArgs e)
        {
            User user = new User();
            user.username = UserName.Text;
            user.email = Email.Text;
            user.password = Password.Text;
            if (await App.Database.AddUserAsync(user))
            {
                DisplayAlert("Adding user", "User Added", "OK");
                Navigation.PushModalAsync(new login());


            }

        }

    }
    }


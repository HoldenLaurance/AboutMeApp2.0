using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AboutMeApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactPage : ContentPage
    {
        public ContactPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (nameEntry.Text=="" || nameEntry.Text == null)
            {
                await DisplayAlert(title: "Error!", message: "Please enter your name", cancel: "OK");
            }
            if (emailEntry.Text == "" || emailEntry.Text == null)
            {
                await DisplayAlert(title: "Error!", message: "Please enter your email", cancel: "OK");
            }
            if (questionEntry.Text == "" || questionEntry.Text == null)
            {
                await DisplayAlert(title: "Error!", message: "Please enter your question", cancel: "OK");
            }

            await DisplayAlert(title: "Thanks!",message:"Your message was sent", cancel:"OK" );

            await Navigation.PopAsync();
        }
    }
}
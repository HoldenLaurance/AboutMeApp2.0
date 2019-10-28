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
                return;
            }
            if (emailEntry.Text == "" || emailEntry.Text == null)
            {
                await DisplayAlert(title: "Error!", message: "Please enter your email", cancel: "OK");
                return;
            }
            if (questionEntry.Text == "" || questionEntry.Text == null)
            {
                await DisplayAlert(title: "Error!", message: "Please enter your reason", cancel: "OK");
                return;
            }

            await DisplayAlert(title: "Thanks for Submitting!",message:"Your message was sent, I'll get back to you as soon as I can.", cancel:"Close" );

            Navigation.PopAsync();
        }
    }
}
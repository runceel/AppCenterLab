using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Auth;
using Microsoft.AppCenter.Crashes;
using Microsoft.AppCenter.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppCenterLab
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                var user = await Auth.SignInAsync();
                await DisplayAlert("User", $"{user.AccountId}", "Close");
            }
            catch (Exception ex)
            {
            }
        }

        private async void AddButton_Clicked(object sender, EventArgs e)
        {
            var p = new Person
            {
                Name = "sample" + new Random().Next(),
                Birthday = DateTimeOffset.Now,
            };
            await Data.CreateAsync(p.Id.ToString(), p, DefaultPartitions.UserDocuments);
        }

        private async void ReadButton_Clicked(object sender, EventArgs e)
        {
            var r = new List<Person>();
            var result = await Data.ListAsync<Person>(DefaultPartitions.UserDocuments);
            r.AddRange(result.CurrentPage.Items.Select(x => x.DeserializedValue));
            while(result.HasNextPage)
            {
                await result.GetNextPageAsync();
                r.AddRange(result.CurrentPage.Items.Select(x => x.DeserializedValue));
            }

            await DisplayAlert("Result", $"{r.Count} items found, {string.Join(", ", r.Select(x => x.Name))}", "OK");
        }
    }
}

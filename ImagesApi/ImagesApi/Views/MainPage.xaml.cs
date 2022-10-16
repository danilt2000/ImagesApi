using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace ImagesApi
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void TapGestureRecognizer_TappedFacebook(object sender, EventArgs e)
        {
           
            try
            {
                await Browser.OpenAsync(new Uri("https://www.facebook.com/danil.tkacenko.3/"), BrowserLaunchMode.SystemPreferred);
            }
            catch (Exception ex)
            {
                // An unexpected error occured. No browser may be installed on the device.
            }


        } private async void TapGestureRecognizer_TappedGithub(object sender, EventArgs e)
        {
           
            try
            {
                await Browser.OpenAsync(new Uri("https://github.com/danilt2000"), BrowserLaunchMode.SystemPreferred);
            }
            catch (Exception ex)
            {
                // An unexpected error occured. No browser may be installed on the device.
            }


        } private async void TapGestureRecognizer_TappedVk(object sender, EventArgs e)
        {
           
            try
            {
                await Browser.OpenAsync(new Uri("https://vk.com/id199581922"), BrowserLaunchMode.SystemPreferred);
            }
            catch (Exception ex)
            {
                // An unexpected error occured. No browser may be installed on the device.
            }


        }
    }
}

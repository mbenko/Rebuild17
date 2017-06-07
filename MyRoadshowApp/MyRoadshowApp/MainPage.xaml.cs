using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyRoadshowApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var myEvent = e.SelectedItem as Event;

            Navigation.PushModalAsync(new ItemDetail(myEvent));
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}

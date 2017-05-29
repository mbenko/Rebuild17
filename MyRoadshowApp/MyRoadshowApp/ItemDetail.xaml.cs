﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyRoadshowApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ItemDetail : ContentPage
	{
		public ItemDetail ()
		{
			InitializeComponent ();
		}
        public ItemDetail(Event myEvent)
        {
            InitializeComponent();
            BindingContext = myEvent;
        }

        private async Task Button_Clicked(object sender, EventArgs e)
        {
            // Save changes and close 
            await Navigation.PopModalAsync();
        }
    }
}

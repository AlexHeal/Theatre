﻿using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Theatre.View.PerformancePage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DreamPage : ContentPage
    {
        public DreamPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            //(BindingContext as PerformanceListViewModel)?.Init(4);
            //BindingContext = new PerformanceListViewModel(4);
        }
    }
}
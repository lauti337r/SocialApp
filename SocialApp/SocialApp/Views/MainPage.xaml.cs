﻿using Prism.Navigation;
using Xamarin.Forms;

namespace SocialApp.Views
{
    public partial class MainPage : MasterDetailPage
    {
        public static readonly BindableProperty IsPresentedAfterNavigationProperty =
            BindableProperty.Create(nameof(IsPresentedAfterNavigation), typeof(bool), typeof(MainPage), false);
        public MainPage()
        {
            InitializeComponent();
        }

        public bool IsPresentedAfterNavigation
        {
            get => (bool)GetValue(IsPresentedAfterNavigationProperty);
            set => SetValue(IsPresentedAfterNavigationProperty, value);
        }
    }
}
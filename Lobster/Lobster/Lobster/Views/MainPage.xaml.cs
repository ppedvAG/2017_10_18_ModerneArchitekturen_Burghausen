﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lobster.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            DependencyService.Register<ViewModels.MainViewModel>();
            BindingContext = DependencyService.Get<ViewModels.MainViewModel>();
        }
    }
}

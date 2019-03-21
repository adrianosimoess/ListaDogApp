using System;
using System.Collections.Generic;
using ListaDogApp.Model;
using Xamarin.Forms;

namespace ListaDogApp
{
    public partial class ListaDogPage : ContentPage
    {
        public ListaDogPage(List<Dog> lista_dog)
        {
            InitializeComponent();
            listView_dog.ItemsSource = lista_dog;
        }
    }
}

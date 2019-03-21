using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListaDogApp.Model;
using Xamarin.Forms;

namespace ListaDogApp
{
    public partial class MainPage : ContentPage
    {
        List<Dog> lista_dog = new List<Dog>();

        void Adicionar(object sender, System.EventArgs e)
        {
            Dog dog = new Dog();

            dog.nome = nomedog.Text;
            dog.idade = Convert.ToInt32(idadedog.Text);
            dog.raca = racadog.Text;


            lista_dog.Add(dog);

            nomedog.Text = string.Empty;
            idadedog.Text = string.Empty;
            racadog.Text = string.Empty;
        }


        void Checar(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ListaDogPage(lista_dog));
        }

        public MainPage()
        {
            InitializeComponent();
        }

    }
}

using System;
namespace ListaDogApp.Model
{
    public class Dog
    {

        public string nome { get; set; }
        public int idade { get; set; }
        public string raca { get; set; }
        public string nomeIdade
        {
            get { return nome + ", " + idade; }
        }

        public Dog()
        {
        }
    }
}

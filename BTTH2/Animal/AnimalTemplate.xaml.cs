using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BTTH2
{
    public partial class AnimalTemplate : ContentPage
    {
        public AnimalTemplate()
        {
            InitializeComponent();

            CreateAnimal();
        }

        List<Animal> animalList = new List<Animal>();

        void CreateAnimal()
        {
            animalList.Add(new Animal {
                name = "Dog",
                location = "Viet Nam",
                img = "https://static2.yan.vn/YanNews/2167221/201908/4-loai-quoc-khuyen-cua-viet-nam-an-dut-giong-cho-cua-nhat-ban-8b35dcc7.jpg",
            });

            animalList.Add(new Animal
            {
                name = "Fish",
                location = "The United State of America",
                img = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTVkS2RcgnGOtqjcDMFsegLU1-5S71NPGafBg&usqp=CAU",
            });

            animalList.Add(new Animal
            {
                name = "Bird",
                location = "United Kingdom",
                img = "https://media.istockphoto.com/photos/lilac-breasted-roller-in-kenya-africa-picture-id1191223442?b=1&k=20&m=1191223442&s=170667a&w=0&h=QwcAZJp4cbIBT2dNEQV_MH7tVzzBN6SwBIY8e5TzxlA=",
            });

            animalList.Add(new Animal
            {
                name = "Monkey",
                location = "Brazil",
                img = "https://media.cntraveler.com/photos/53e2da95dddaa35c30f604ab/master/pass/toque-macaques-sri-lanka-H-Lansdown-Alamy.jpg",
            });

            ListAnimal.ItemsSource = animalList;
        }

        void ListAnimal_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            if (ListAnimal.SelectedItem != null)
            {
                Animal animal = (Animal)ListAnimal.SelectedItem;

                Navigation.PushAsync(new SpeciesPage(animal));
            }
        }
    }
}

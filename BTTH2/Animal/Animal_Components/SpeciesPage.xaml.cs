using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BTTH2
{
    public partial class SpeciesPage : ContentPage
    {
        public SpeciesPage(Animal animal)
        {
            InitializeComponent();
            Title = animal.name;
            CreateIndividuals(animal);
        }

        List<Individual> individuals = new List<Individual>();

        string[] DogImg = new string[]
        {
            "https://pngimg.com/uploads/husky/husky_PNG38.png",
            "https://wikipet.vn/wp-content/uploads/2018/08/cho-alaska-05.jpg",
            "https://cdn.pixabay.com/photo/2014/09/19/21/47/chihuahua-453063__480.jpg",
        };

        string[] FishImg = new string[]
        {
            "https://images.unsplash.com/photo-1535591273668-578e31182c4f?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxleHBsb3JlLWZlZWR8M3x8fGVufDB8fHx8&w=1000&q=80",
            "https://2pawsupinc.com/wp-content/uploads/2020/07/Goldfish-Care.jpg",
        };

        string[] BirdImg = new string[]
        {
            "https://www.teahub.io/photos/full/74-744553_kingfisher-bird-hd.jpg",
            "https://image.shutterstock.com/image-vector/cute-blue-bird-cartoon-giving-260nw-1513801382.jpg",
            "https://images.pexels.com/photos/349758/hummingbird-bird-birds-349758.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500",
        };

        string[] MonkeyImg = new string[]
        {
            "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQj0-CM8TJ6aypW7z6yrN359cb3p7Hf2g10XMLzY8Z5rxyVBMvGppLi_GTe-PnbFLnnHcY&usqp=CAU",
            "https://post.medicalnewstoday.com/wp-content/uploads/sites/3/2020/08/GettyImages-993621062_thumb.jpg",
        };

        void CreateIndividuals(Animal animal)
        {
            if (animal.name == "Dog")
            {
                individuals.Add(new Individual
                {
                    name = "Husky",
                    img = DogImg[0],
                });

                individuals.Add(new Individual
                {
                    name = "Alaska",
                    img = DogImg[1],
                });

                individuals.Add(new Individual
                {
                    name = "Chihuahua",
                    img = DogImg[2],
                });
            }
            else if (animal.name == "Fish")
            {
                individuals.Add(new Individual
                {
                    name = "ClownFish",
                    img = FishImg[0],
                });

                individuals.Add(new Individual
                {
                    name = "GoldFish",
                    img = FishImg[1],
                });
            }
            else if (animal.name == "Bird")
            {
                individuals.Add(new Individual
                {
                    name = "KingFisher Bird",
                    img = BirdImg[0],
                });

                individuals.Add(new Individual
                {
                    name = "Anime Bird",
                    img = BirdImg[1],
                });

                individuals.Add(new Individual
                {
                    name = "WoodPecker",
                    img = BirdImg[2],
                });
            }
            else if (animal.name == "Monkey")
            {
                individuals.Add(new Individual
                {
                    name = "Lion-maned Monkey",
                    img = MonkeyImg[0],
                });

                individuals.Add(new Individual
                {
                    name = "Macaque monkeys",
                    img = MonkeyImg[1],
                });
            }

            ListSpecies.ItemsSource = individuals;
        }
    }
}

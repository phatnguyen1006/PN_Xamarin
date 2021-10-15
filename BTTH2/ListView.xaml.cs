using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BTTH2
{
    public partial class ListView : ContentPage
    {
        public ListView()
        {
            InitializeComponent();
            string[] subjectList = new string[]
            {
                "IT001",
                "IT002",
                "IT003",
                "IT004",
                "IT005",
                "IT006",
                "IT007",
                "IT008",
                "IT009",
            };

            subjects.ItemsSource = subjectList;
        }
    }
}

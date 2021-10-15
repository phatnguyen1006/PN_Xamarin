using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BTTH2
{
    public partial class Hotels : ContentPage
    {
        public Hotels(City city)
        {
            InitializeComponent();
            Title = city.cityName;
            CreateHotelList(city);
        }

        List<Hotel> hotelList = new List<Hotel>();

        string[] HNImgs = new string[]
        {
            "https://media.expedia.com/hotels/15000000/14930000/14922600/14922560/e891aa32_z.jpg",
            "https://www.ahstatic.com/photos/b4g6_ho_00_p_1024x768.jpg",
            "https://media.expedia.com/hotels/13000000/13000000/12996300/12996300/200212e6_z.jpg",
        };

        string[] DLImgs = new string[]
        {
            "https://media.expedia.com/hotels/10000000/9860000/9851600/9851505/b447e294_z.jpg",
            "https://d2e5ushqwiltxm.cloudfront.net/wp-content/uploads/sites/95/2016/12/07091321/HotelMetropoleHanoi.jpg",
            "http://www.asiawebdirect.com/media/images/hotels/1341/482534.jpg",
        };

        string[] HCMImgs = new string[]
        {
            "https://www.ahstatic.com/photos/1555_ho_00_p_1024x768.jpg",
            "https://www.ahstatic.com/photos/7832_ho_00_p_1024x768.jpg",
            "https://media.expedia.com/hotels/14000000/13460000/13457300/13457246/e4bd40d1_z.jpg",
            "https://ak-d.tripcdn.com/images/220r13000000ucr8uFCB5_Z_550_412_R5_Q70_D.jpg",
        };

        string[] VTImgs = new string[]
        {
            "https://kaotours.com/wp-content/uploads/2020/04/161729_16042517050041783062.jpg",
            "https://bazantravel.com/cdn/medias/uploads/30/30803-khach-san-sammy-vung-tau-1.jpg",
        };

        string descript = "Ideally located in the prime touristic area of Hoan Kiem District, Hotel De L’Opera MGallery Collection promises a relaxing and wonderful visit. The hotel offers guests a range of services and amenities designed to provide comfort and convenience. All the necessary facilities, including free Wi-Fi in all rooms, 24-hour front desk, 24-hour room service, facilities for disabled guests, Wi-Fi in public areas, are at hand. Guestrooms are designed to provide an optimal level of comfort with welcoming decor and some offering convenient amenities like internet access – wireless (complimentary), internet access – wireless, non smoking rooms, air conditioning, mini bar. The hotel offers various recreational opportunities. Convenience and comfort makes Hotel De L’Opera MGallery Collection the perfect choice for your stay in Hanoi.";

        void CreateHotelList(City city)
        {
            if (city.cityId == "HN")
            {
                hotelList.Add(new Hotel
                {
                    hotelCode = city.cityId,
                    hotelName = "La Siesta Hotel",
                    hotelAddress = "12 Nguyen Quang Bich St, Hanoi, Vietnam",
                    hotelDescript = descript,
                    hotelImg = HNImgs[0],
                });

                hotelList.Add(new Hotel
                {
                    hotelCode = city.cityId,
                    hotelName = "Royal Palace Hotel",
                    hotelAddress = "95 Hang Bong Street, Old Quarter, Hanoi, 10000, Vietnam",
                    hotelDescript = descript,
                    hotelImg = HNImgs[1],
                });

                hotelList.Add(new Hotel
                {
                    hotelCode = city.cityId,
                    hotelName = "Marvellous Hotel & Spa",
                    hotelAddress = "95 Hang Bong Street, Old Quarter, Hanoi, 10000, Vietnam",
                    hotelDescript = descript,
                    hotelImg = HNImgs[2],
                });
            }
            else if (city.cityId == "DL")
            {
                hotelList.Add(new Hotel
                {
                    hotelCode = city.cityId,
                    hotelName = "Terracotta Hotel & Resort",
                    hotelAddress = "Zone 7.9,Tuyen Lam Lake, Ward 3, Da Lat, Lam Dong, Vietnam",
                    hotelDescript = descript,
                    hotelImg = DLImgs[0],
                });

                hotelList.Add(new Hotel
                {
                    hotelCode = city.cityId,
                    hotelName = "Iris Hotel",
                    hotelAddress = "Le Lai Street, Ward 5, Da Lat, Lam Dong, Vietnam",
                    hotelDescript = descript,
                    hotelImg = HNImgs[1],
                });

                hotelList.Add(new Hotel
                {
                    hotelCode = city.cityId,
                    hotelName = "Marvellous Hotel & Spa",
                    hotelAddress = "95 Hang Bong Street, Old Quarter, Hanoi, 10000, Vietnam",
                    hotelDescript = descript,
                    hotelImg = HNImgs[2],
                });
            }
            else if (city.cityId == "HCM")
            {
                hotelList.Add(new Hotel
                {
                    hotelCode = city.cityId,
                    hotelName = "Hotel Nikko Saigon",
                    hotelAddress = "235 Nguyen Van Cu Street, District 1, Ho Chi Minh City, Vietnam",
                    hotelDescript = descript,
                    hotelImg = HCMImgs[0],
                });

                hotelList.Add(new Hotel
                {
                    hotelCode = city.cityId,
                    hotelName = "EdenStar Saigon Hotel & Spa",
                    hotelAddress = "38 Bui Thi Xuan Street, Ho Chi Minh City, 848, Vietnam",
                    hotelDescript = descript,
                    hotelImg = HCMImgs[1],
                });

                hotelList.Add(new Hotel
                {
                    hotelCode = city.cityId,
                    hotelName = "Bay Hotel Ho Chi Minh",
                    hotelAddress = "7 Ngo Van Nam Street, District 1, Ho Chi Minh City, Vietnam",
                    hotelDescript = descript,
                    hotelImg = HCMImgs[2],
                });

                hotelList.Add(new Hotel
                {
                    hotelCode = city.cityId,
                    hotelName = "Caravelle Saigon",
                    hotelAddress = "19 - 23 Lam Son Square, District 1, Ho Chi Minh City, Vietnam",
                    hotelDescript = descript,
                    hotelImg = HCMImgs[3],
                });
            }
            else if (city.cityId == "VT")
            {
                hotelList.Add(new Hotel
                {
                    hotelCode = city.cityId,
                    hotelName = "VungTau Resort",
                    hotelAddress = "Vung Tau",
                    hotelDescript = descript,
                    hotelImg = VTImgs[0],
                });

                hotelList.Add(new Hotel
                {
                    hotelCode = city.cityId,
                    hotelName = "Sammy Hotel",
                    hotelAddress = "Vung Tau",
                    hotelDescript = descript,
                    hotelImg = VTImgs[1],
                });
            }

            ListHotes.ItemsSource = hotelList;
        }

        void ListHotes_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            if(ListHotes.SelectedItem != null)
            {
                Hotel hotel = (Hotel)ListHotes.SelectedItem;

                Navigation.PushAsync(new DetailPage(hotel));
            }
        }
    }
}

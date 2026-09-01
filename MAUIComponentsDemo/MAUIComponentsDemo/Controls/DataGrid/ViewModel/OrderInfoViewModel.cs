using System.Collections.ObjectModel;
using System.ComponentModel;

namespace MAUIComponentsDemo
{
    public class OrderInfoViewModel : INotifyPropertyChanged
    {
        private readonly Random random = new();
        private ObservableCollection<OrderInfo>? ordersInfo = new();
        private readonly Dictionary<string, string[]> shipCity = new();

        private readonly string[] names =
        {
            "Kyle","Gina","Irene","Katie","Michael","Oscar","Ralph","Torrey",
            "William","Bill","Daniel","Frank","Brenda","Danielle","Fiona",
            "Howard","Jack","Larry","Holly","Jennifer","Liz","Pete","Steve",
            "Vince","Zeke","Gary","Maciej","Shelley","Linda","Carla","Carol",
            "Shannon","Jauna","Michael","Terry","John","Gail","Mark","Martha",
            "Julie","Janeth","Twanna","Frank","Crowley","Waddell","Irvine",
            "Keefe","Ellis","Gable","Mendoza","Rooney","Lane","Landry","Perry",
            "Perez","Newberry","Betts","Fitzgerald","Adams","Owens","Thomas",
            "Doran","Jefferson","Spencer","Vargas","Grimes","Edwards","Stark",
            "Cruise","Fitz","Chief","Blanc","Stone","Williams","Jobs","Holmes"
        };

        private readonly string[] shipCountry =
        {
            "Argentina",
            "Austria",
            "Belgium",
            "Brazil",
            "Canada",
            "Denmark",
            "Finland",
            "France",
            "Germany",
            "Ireland",
            "Italy",
            "Mexico",
            "Norway",
            "Poland",
            "Portugal",
            "Spain",
            "Sweden",
            "UK",
            "USA"
        };

        public event PropertyChangedEventHandler? PropertyChanged;

        public OrderInfoViewModel()
        {
            OrdersInfo = GetOrderDetails(50);
        }

        public ObservableCollection<OrderInfo>? OrdersInfo
        {
            get => ordersInfo;
            set
            {
                ordersInfo = value;
                RaisePropertyChanged(nameof(OrdersInfo));
            }
        }

        public ObservableCollection<OrderInfo> GetOrderDetails(int count)
        {
            SetShipCity();

            var orderedDates = GetDateBetween(2000, 2014, count);
            var orderDetails = new ObservableCollection<OrderInfo>();

            for (int i = 0; i < count; i++)
            {
                var country = shipCountry[random.Next(5)];
                var cities = shipCity[country];

                orderDetails.Add(new OrderInfo
                {
                    OrderID = i + 10001,
                    CustomerID = i + 2701,
                    Name = (i + 1) > 72 ? names[random.Next(40)] : names[i + 1],
                    ShipCountry = country,
                    ShipCity = cities[random.Next(cities.Length)],
                    ShippingDate = orderedDates[i]
                });
            }

            return orderDetails;
        }

        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private List<DateTime> GetDateBetween(int startYear, int endYear, int count)
        {
            var date = new List<DateTime>();

            Random d = new(1);
            Random m = new(2);
            Random y = new(startYear);

            for (int i = 0; i < count; i++)
            {
                int year = y.Next(startYear, endYear);
                int month = m.Next(3, 13);
                int day = d.Next(1, 31);

                date.Add(new DateTime(year, month, day));
            }

            return date;
        }

        private void SetShipCity()
        {
            if (shipCity.Count > 0)
                return;

            shipCity.Add("Argentina", new[] { "Rosario" });

            shipCity.Add("Austria", new[]
            {
                "Graz",
                "Salzburg"
            });

            shipCity.Add("Belgium", new[]
            {
                "Bruxelles",
                "Charleroi"
            });

            shipCity.Add("Brazil", new[]
            {
                "Campinas",
                "Resende",
                "Recife",
                "Manaus"
            });

            shipCity.Add("Canada", new[]
            {
                "Montréal",
                "Tsawassen",
                "Vancouver"
            });

            shipCity.Add("Denmark", new[]
            {
                "Århus",
                "København"
            });

            shipCity.Add("Finland", new[]
            {
                "Helsinki",
                "Oulu"
            });

            shipCity.Add("France", new[]
            {
                "Lille",
                "Lyon",
                "Marseille",
                "Nantes",
                "Paris",
                "Reims",
                "Strasbourg",
                "Toulouse",
                "Versailles"
            });

            shipCity.Add("Germany", new[]
            {
                "Aachen",
                "Berlin",
                "Brandenburg",
                "Cunewalde",
                "Frankfurt",
                "Köln",
                "Leipzig",
                "Mannheim",
                "München",
                "Münster",
                "Stuttgart"
            });

            shipCity.Add("Ireland", new[] { "Cork" });

            shipCity.Add("Italy", new[]
            {
                "Bergamo",
                "Reggio",
                "Torino"
            });

            shipCity.Add("Mexico", new[] { "México D.F." });
            shipCity.Add("Norway", new[] { "Stavern" });
            shipCity.Add("Poland", new[] { "Warszawa" });
            shipCity.Add("Portugal", new[] { "Lisboa" });

            shipCity.Add("Spain", new[]
            {
                "Barcelona",
                "Madrid",
                "Sevilla"
            });

            shipCity.Add("Sweden", new[]
            {
                "Bräcke",
                "Luleå"
            });

            shipCity.Add("UK", new[]
            {
                "Colchester",
                "Hedge End",
                "London"
            });

            shipCity.Add("USA", new[]
            {
                "Albuquerque",
                "Anchorage",
                "Boise",
                "Butte",
                "Elgin",
                "Eugene",
                "Kirkland",
                "Lander",
                "Portland",
                "San Francisco",
                "Seattle"
            });
        }
    }
}
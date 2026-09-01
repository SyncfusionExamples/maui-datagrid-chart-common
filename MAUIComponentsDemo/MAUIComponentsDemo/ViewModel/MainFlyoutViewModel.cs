using MAUIComponentsDemo.Controls.DataGrid.Sample;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;

namespace MAUIComponentsDemo.ViewModel
{
    public class MenuItem
    {
        public string Title { get; set; }
        public string PageName { get; set; }

        public MenuItem(string title, string pageName)
        {
            Title = title;
            PageName = pageName;
        }
    }

    public class MainFlyoutViewModel
    {
        private readonly MainFlyoutPage _flyoutPage;
        public ObservableCollection<MenuItem> MenuItems { get; set; }
        public ICommand SelectionChangedCommand { get; set; }

        public MainFlyoutViewModel(MainFlyoutPage flyoutPage)
        {
            _flyoutPage = flyoutPage;
            MenuItems = new ObservableCollection<MenuItem>
            {
                new MenuItem("Chart", "chart"),

                new MenuItem("DataGrid", "datagrid"),
            };

            SelectionChangedCommand = new Command<MenuItem>(OnMenuItemSelected);
        }

        private async void OnMenuItemSelected(MenuItem menuItem)
        {
            if (menuItem == null)
                return;

            try
            {
                Page page = null;

                switch (menuItem.PageName.ToLower())
                {
                    case "datagrid":
                        page = new SfDataGridDemo();
                        break;
                    case "chart":
                        // TODO: Create Chart page
                        page = new ContentPage
                        {
                            Title = "Chart",
                            BackgroundColor = Colors.White,
                            Content = new StackLayout
                            {
                                VerticalOptions = LayoutOptions.CenterAndExpand,
                                HorizontalOptions = LayoutOptions.CenterAndExpand,
                                Children =
                                {
                                    new Label
                                    {
                                        Text = "Chart Component",
                                        FontSize = 20,
                                        FontAttributes = FontAttributes.Bold,
                                        TextColor = Colors.Black
                                    },
                                    new Label
                                    {
                                        Text = "Chart page coming soon...",
                                        TextColor = Colors.Gray
                                    }
                                }
                            }
                        };
                        break;
                }

                if (page != null)
                {
                    if (_flyoutPage?.Detail is NavigationPage navPage)
                    {
                        await navPage.PushAsync(page);
                    }
                    _flyoutPage.IsPresented = false;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Navigation error: {ex.Message}");
            }
        }
    }
}

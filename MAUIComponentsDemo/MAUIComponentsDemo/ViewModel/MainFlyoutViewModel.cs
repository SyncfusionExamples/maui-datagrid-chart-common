using MAUIComponentsDemo.Controls.DataGrid.Sample;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;
using MAUIComponentsDemo.Controls.Chart;

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
                        page = new ChartDemo();
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

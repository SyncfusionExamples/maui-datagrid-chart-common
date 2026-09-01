using MAUIComponentsDemo.ViewModel;

namespace MAUIComponentsDemo
{
    public partial class MainFlyoutPage : FlyoutPage
    {
        public MainFlyoutPage()
        {
            InitializeComponent();
            BindingContext = new MainFlyoutViewModel(this);
        }
    }
}

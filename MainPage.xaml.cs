using MauiApp1.ViewModel;

//URI SHELL BASED NAVIGATION

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {

        public MainPage(MainViewModal vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }

      
    }

}

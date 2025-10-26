using neosRPS.Models;
using neosRPS.PageModels;

namespace neosRPS.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}
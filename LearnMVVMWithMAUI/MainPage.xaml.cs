using LearnMVVMWithMAUI.ViewModels;

namespace LearnMVVMWithMAUI
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage(MainPageViewModel viewModel)
        {
            BindingContext = viewModel;
            InitializeComponent();
        }

        
    }
}
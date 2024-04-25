using SwipeView_Error.ViewModel;

namespace SwipeView_Error
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MonkeyViewModel();
        }

       
    }

}

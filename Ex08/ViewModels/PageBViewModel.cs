using Prism.Navigation;

namespace Ex08.ViewModels
{
    public class PageBViewModel : ViewModelBase
    {
        public PageBViewModel(INavigationService navigationService) :
            base(navigationService)
        {
            Title = "Page B";
        }
    }
}

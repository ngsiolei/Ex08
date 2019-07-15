using Prism.Navigation;

namespace Ex08.ViewModels
{
    public class PageAViewModel : ViewModelBase
    {
        public PageAViewModel(INavigationService navigationService) :
            base(navigationService)
        {
            Title = "Page A";
        }
    }
}

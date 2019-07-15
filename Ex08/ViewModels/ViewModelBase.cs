using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;

namespace Ex08.ViewModels
{
    public class ViewModelBase : BindableBase, INavigationAware
    {
        protected INavigationService _navigationService { get; private set; }
        public ViewModelBase(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
        }

        public void OnNavigatingTo(INavigationParameters parameters)
        {
        }

        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private DelegateCommand<string> _navigateCommand;
        public DelegateCommand<string> NavigateCommand
        {
            get
            {
                return _navigateCommand
                       ?? (_navigateCommand = new DelegateCommand<string>(ExecuteNavigateCommand));
            }
        }
        async void ExecuteNavigateCommand(string parameter)
        {
            await _navigationService.NavigateAsync(parameter);
        }

        private DelegateCommand<string> _goBackCommand;
        public DelegateCommand<string> GoBackCommand
        {
            get
            {
                return _goBackCommand
                       ?? (_goBackCommand = new DelegateCommand<string>(ExecuteGoBackCommand));
            }
        }
        async void ExecuteGoBackCommand(string parameter = "")
        {
            await _navigationService.GoBackAsync();
        }
    }
}
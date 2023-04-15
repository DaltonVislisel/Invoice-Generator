using InvoiceGenerator.Core;

namespace InvoiceGenerator.MVM.ViewModel
{
    internal class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }

        public RelayCommand CreateInvoiceViewCommand { get; set; }

        public HomeViewModel HomeVm { get; set; }

        public CreateInvoiceViewModel CreateInvoiceVm { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            HomeVm = new HomeViewModel();
            CreateInvoiceVm = new CreateInvoiceViewModel();

            CurrentView = HomeVm;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVm;
            });

            CreateInvoiceViewCommand = new RelayCommand(o =>
            {
                CurrentView = CreateInvoiceVm;
            });
        }
    }
}

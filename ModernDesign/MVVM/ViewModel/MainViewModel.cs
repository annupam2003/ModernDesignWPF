using ModernDesign.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernDesign.MVVM.ViewModel
{
    internal class MainViewModel : ObsservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand DiscoveryViewCommand { get; set; }

        public HomeViewModel HomeVM { get; set; }
        public DiscoveryVeiwModel DiscoveryVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value; OnPropertyChanged(); }
        }

        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            DiscoveryVM = new DiscoveryVeiwModel();
            CurrentView = HomeVM;

           HomeViewCommand = new RelayCommand(obj => { CurrentView = HomeVM; });
            DiscoveryViewCommand = new RelayCommand(obj => { CurrentView = DiscoveryVM; });
        }
    }
}

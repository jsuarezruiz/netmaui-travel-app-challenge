using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using TravelApp.Models;
using TravelApp.Services;
using Xamarin.Forms;

namespace TravelApp.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        ObservableCollection<Destination> _recommendedDestinations;
        ObservableCollection<Destination> _topDestinations;

        public MainViewModel()
        {
            LoadData();
        }

        public ObservableCollection<Destination> RecommendedDestinations
        {
            get { return _recommendedDestinations; }
            set
            {
                _recommendedDestinations = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Destination> TopDestinations
        {
            get { return _topDestinations; }
            set
            {
                _topDestinations = value;
                OnPropertyChanged();
            }
        }

        public ICommand DetailCommand => new Command<Destination>(OnNavigate);

        void LoadData()
        {
            RecommendedDestinations = new ObservableCollection<Destination>(DestinationService.Instance.RecommendedDestinations);
            TopDestinations = new ObservableCollection<Destination>(DestinationService.Instance.TopDestinations);
        }

        void OnNavigate(Destination parameter)
        {
            NavigationService.Instance.NavigateToAsync<DetailViewModel>(parameter);
        }
    }
}
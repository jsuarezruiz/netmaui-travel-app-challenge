using System.Threading.Tasks;
using System.Windows.Input;
using TravelApp.Models;
using TravelApp.Services;
using Xamarin.Forms;

namespace TravelApp.ViewModels
{
    public class DetailViewModel : ViewModelBase
    {
        Destination _destination;

        public Destination Destination
        {
            get { return _destination; }
            set
            {
                _destination = value;
                OnPropertyChanged();
            }
        }

        public ICommand BackCommand => new Command(OnBack);

        public override Task InitializeAsync(object navigationData)
        {
            if (navigationData is Destination destination)
                Destination = destination;

            return base.InitializeAsync(navigationData);
        }

        void OnBack()
        {
            NavigationService.Instance.NavigateBackAsync();
        }
    }
}
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TravelApp.ViewModels
{
    public class ViewModelBase : BindableObject
    {
        public virtual Task InitializeAsync(object navigationData)
        {
            return Task.FromResult(false);
        }
    }
}

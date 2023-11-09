using Pitasoft.Shell.Services;
using Pitasoft.Shell.Xamarin.ViewModels;
using System.Threading.Tasks;
using Xamarin.Forms;
using CefaleasApp.Entities;

namespace CefaleasApp.ViewModels
{
    public class MainViewModel : MainViewModelBase
    {

        public MainViewModel(IMenuService menuService) : base(menuService) 
        {
           
        }


    }
}

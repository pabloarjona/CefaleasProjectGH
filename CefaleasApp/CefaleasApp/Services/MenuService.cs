using Pitasoft.Shell.Menu;
using System.Collections.Generic;
using System.Threading.Tasks;
using CefaleasApp.Views;
using Pitasoft.Shell.Services;
using CefaleasApp.ViewModels;
using Xamarin.Essentials;

namespace CefaleasApp.Services
{
    public class MenuService : MenuServiceBase
    {
        private MenuBase[] _menu;
        public override IEnumerable<MenuBase> GetMenu() => _menu;
        public override Task<bool> LoadMenuAsync()
        {
            _menu = new MenuBase[] {
                new MenuViewModelInstance("Inicio", typeof(StartView)),
                //new MenuViewModelInstance("Mi Cuenta", typeof(UsuarioView)),
                new MenuViewModelInstance("Pacientes",typeof(PacienteView))
                {
                    Launch = true,

                },
                new MenuViewModelInstance("Acerca de nosotros", typeof(AboutView))
            };
            return base.LoadMenuAsync();
        }

    }
}
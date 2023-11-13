using Pitasoft.Shell.Menu;
using System.Collections.Generic;
using System.Threading.Tasks;
using CefaleasApp.Views;
using Pitasoft.Shell.Services;

namespace CefaleasApp.Services
{
    public class MenuService : MenuServiceBase
    {
        private MenuBase[] _menu;
        public override IEnumerable<MenuBase> GetMenu() => _menu;
        public override Task<bool> LoadMenuAsync()
        {
            _menu = new MenuBase[] {
                new MenuViewModelInstance("Inicio", typeof(StartView))
                {
                    Launch = true
                },
                new MenuViewModelInstance("Pacientes", typeof(PacienteView)),
                new MenuViewModelInstance("Mi cuenta",typeof(UsuarioView)),
                new MenuViewModelInstance("Acerca de nosotros",typeof(AboutView))
            };
            return base.LoadMenuAsync();
        }

    }
}
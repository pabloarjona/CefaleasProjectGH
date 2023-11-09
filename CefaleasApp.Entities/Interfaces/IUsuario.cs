using System;
using System.Collections.Generic;
using System.Text;

namespace CefaleasApp.Entities.Interfaces
{
    public interface IUsuario
    {
        string Nombre { get; set; }
        string Password { get; set; }
        string Correo { get; set; }
        int NColegiado { get; set; }
        int NVerificacion { get; set; }
        char? Verificado { get; set; }
    }
}

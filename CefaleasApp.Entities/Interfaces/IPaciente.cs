using System;
using System.Collections.Generic;
using System.Text;

namespace CefaleasApp.Entities.Interfaces
{
    public interface IPaciente
    {
        string Iniciales { get; set; }
        DateTime FechaConsulta { get; set; }
        short Edad { get; set; }
        char Sexo { get; set; }
    }
}

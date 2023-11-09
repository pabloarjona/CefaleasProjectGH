using System;
using System.Collections.Generic;
using System.Text;
using CefaleasApp.Entities;

namespace CefaleasApp.Models
{
    public interface ICriteriosCefalea 
    {
        bool MigrañaSinAura(Cuestionario cuestionario);
        int ComprobarCefalea(Cuestionario cuestionario);
    }
}

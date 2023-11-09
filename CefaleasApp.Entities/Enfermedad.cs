    using System;
using System.Collections.Generic;
using System.Text;
using CefaleasApp.Entities.Interfaces;

namespace CefaleasApp.Entities
{
    public class Enfermedad : IEnfermedad
    {
        public int IdEnfermedad { get; set; }
        public string Nombre_Enfermedad{get;set; }
        public string Tratamiento { get; set; }
        public ICollection<Cuestionario> Cuestionarios { get; set; }

    }
}

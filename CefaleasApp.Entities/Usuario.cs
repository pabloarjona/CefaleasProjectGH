using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using CefaleasApp.Entities.Interfaces;

namespace CefaleasApp.Entities
{
    public class Usuario : IUsuario
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Password { get; set; }
        public string Correo { get; set; }
        public int NColegiado { get; set; }
        public int NVerificacion { get; set; }
        public char? Verificado { get; set; }
        public ICollection<Paciente> Pacientes { get; set; }


    }
}

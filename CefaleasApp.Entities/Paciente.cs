using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using CefaleasApp.Entities.Interfaces;

namespace CefaleasApp.Entities
{
    public class Paciente : IPaciente
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPaciente { get; set; }
        public string Iniciales { get; set; }
        public DateTime FechaConsulta { get; set; }  
        public short Edad { get; set; }
        public char Sexo { get; set; }
        public int IdUsuario{ get;set;}
        public Usuario Usuario { get; set; }
        public Cuestionario Cuestionario { get; set; }
    }
}

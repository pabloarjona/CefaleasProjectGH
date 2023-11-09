using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using CefaleasApp.Entities.Interfaces;

namespace CefaleasApp.Entities
{
    public class Cuestionario : ICuestionario
    {
        
        public int IdPaciente { get; set; }
        public string Episodios { get; set; }
        public string Duracion { get; set; }
        public string Duracion_episodio { get; set; }
        public string Localizacion { get; set; }
        public string Dolor { get; set; }
        public string Intensidad { get; set; }
        public string Actividad_fisica { get; set; }
        public string Nauseas { get; set; }
        public string Vomitos { get; set; }
        public string Fotofobia { get; set; }
        public string Fonofobia { get; set; }
        public string Aura { get; set; }
        public string Ipsilaterales { get; set; }
        public string Inquietud { get; set; }
        public string Trayectoria_lineal { get; set; }
        public string Inicio_brusco { get; set; }
        public string Indometacina { get; set; }
        public string Triptan_ergotico { get; set; }
        public string Tos { get; set; }
        public string Esfuerzo_brusco { get; set; }
        public string Valsalva { get; set; }
        public string Actividad_sexual { get; set; }
        public string Sueño { get; set; }
        public string Inicio_inconfundible { get; set; }
        public int IdEnfermedad { get; set; }
        public bool Verificado { get; set; }
        public int? IdEnfermedadVerificada { get; set; }
        public Paciente Paciente { get; set; }
        public Enfermedad Enfermedad { get; set; }

    }
}

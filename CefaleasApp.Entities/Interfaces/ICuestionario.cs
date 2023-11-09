using System;
using System.Collections.Generic;
using System.Text;

namespace CefaleasApp.Entities.Interfaces
{
    public interface ICuestionario
    {
        string Episodios { get; set; }
        string Duracion { get; set; }
        string Duracion_episodio { get; set; }
        string Localizacion { get; set; }
        string Dolor { get; set; }
        string Intensidad { get; set; }
        string Actividad_fisica { get; set; }
        string Nauseas { get; set; }
        string Vomitos { get; set; }
        string Fotofobia { get; set; }
        string Fonofobia { get; set; }
        string Aura { get; set; }
        string Ipsilaterales { get; set; }
        string Inquietud { get; set; }
        string Trayectoria_lineal { get; set; }
        string Inicio_brusco { get; set; }
        string Indometacina { get; set; }
        string Triptan_ergotico { get; set; }
        string Tos { get; set; }
        string Esfuerzo_brusco { get; set; }
        string Valsalva { get; set; }
        string Actividad_sexual { get; set; }
        string Sueño { get; set; }
        string Inicio_inconfundible { get; set; }
        bool Verificado { get; set; }

    }
}

using System.Collections.Generic;
using CefaleasApp.Entities;

namespace CefaleasApp.Models
{
    public class CriteriosCefalea : ICriteriosCefalea
    {
        List<string> Episodios = new List<string>();
        List<string> Duracion = new List<string>();
        List<string> Duracion_episodio = new List<string>();

        public int cont { get; set; }
        public CriteriosCefalea()
        {
            Episodios.Add("Menos de 5");
            Episodios.Add("Entre 5 y 9");
            Episodios.Add("Entre 10 y 20");
            Episodios.Add("Más de 20");
            Duracion.Add("Menos de 3 meses");
            Duracion.Add("0-15 días/mes durante más de 3 meses");
            Duracion.Add("Más de 15 días/mes durante más de 3 meses");
            Duracion.Add("Indeterminado");//3
            Duracion_episodio.Add("De 1 a 10 segundos");
            Duracion_episodio.Add("De 10 segundos a 2 minutos");
            Duracion_episodio.Add("De 2 minutos a 10 minutos");
            Duracion_episodio.Add("De 10 minutos a 30 minutos"); //3
            Duracion_episodio.Add("De 30 minutos a 3 horas"); 
            Duracion_episodio.Add("De 3 horas a 4 horas");
            Duracion_episodio.Add("De 4 horas a 72 horas");
            Duracion_episodio.Add("Más de 72 horas"); //7
            Duracion_episodio.Add("Indeterminado");
        }
        public int ComprobarCefalea(Cuestionario cuestionario)
        {
            if (MigrañaSinAura(cuestionario))
                return 1;
            else if (MigrañaCronica(cuestionario))
                return 4;
            else if (MigrañaConAura(cuestionario))
                return 3;
            else if (CefaleaRacimos(cuestionario))
                return 5;
            else if (CefaleaNumular(cuestionario))
                return 16;
            else if (CefaleaTensionEpisodica(cuestionario))
                return 6;
            else if (CefaleaTensionCronica(cuestionario))
                return 7;
            else if (HemicraneaParoxistica(cuestionario))
                return 8;
            else if (SUNCTySUNA(cuestionario))
                return 9;
            else if (HemicraneaContinua(cuestionario))
                return 10;
            else if (TusigenaPrimaria(cuestionario))
                return 11;
            else if (EsfuerzoFisicoPrimaria(cuestionario))
                return 12;
            else if (ActividadSexualPrimaria(cuestionario))
                return 13;
            else if (CefaleaTruenoPrimaria(cuestionario))
                return 14;
            else if (CefaleaPunzantePrimaria(cuestionario))
                return 15;
            else if (CefaleaHipnicaPrimaria(cuestionario))
                return 17;
            else if (CefaleaDiariaPersistente(cuestionario))
                return 18;
            else if (EpicraniaFugax(cuestionario))
                return 19;
            else
                return 2;
        }
        public bool NoObligatoriasMigraña(Cuestionario cuestionario)
        {
            if (cuestionario.Trayectoria_lineal == "Si" || cuestionario.Inicio_brusco == "Si" || cuestionario.Indometacina == "Si" || cuestionario.Tos == "Si" || cuestionario.Esfuerzo_brusco == "Si" || cuestionario.Valsalva == "Si" || cuestionario.Actividad_sexual == "Si" || cuestionario.Sueño == "Si" || cuestionario.Inicio_inconfundible == "Si")
                return true;
            else
                return false;
        }
        public bool NoObligatoriasCefalea(Cuestionario cuestionario)
        {
            if (cuestionario.Trayectoria_lineal == "Si" || cuestionario.Inicio_brusco == "Si" || cuestionario.Indometacina == "Si" || cuestionario.Triptan_ergotico == "Si" || cuestionario.Tos == "Si" || cuestionario.Esfuerzo_brusco == "Si" || cuestionario.Valsalva == "Si" || cuestionario.Actividad_sexual == "Si" || cuestionario.Sueño == "Si" || cuestionario.Inicio_inconfundible == "Si" || cuestionario.Triptan_ergotico=="Si")
                return true;
            else
                return false;
        }
        public bool MigrañaSinAura(Cuestionario cuestionario)
        {
            if (NoObligatoriasMigraña(cuestionario))
                return false;
            cont = 0;
            //A
            if (cuestionario.Episodios != Episodios[0]) //1
                cont++;
            //1.1
            if (cuestionario.Duracion == Duracion[0] || cuestionario.Duracion == Duracion[1]) //1.1
                cont++;
            //B
            if (cuestionario.Duracion_episodio == Duracion_episodio[6]) //2
                cont++;
            //C
            short cont2 = 0;
            if (cuestionario.Localizacion == "Unilateral") //3.1
                cont2++;
            if (cuestionario.Dolor == "Pulsátil") //3.2
                cont2++;
            if (cuestionario.Intensidad == "Moderado" || cuestionario.Intensidad == "Grave") //3.3
                cont2++;
            if (cuestionario.Actividad_fisica == "Si")  //3.4
                cont2++;
            if (cont2 >= 2)
                cont++;
            //D            4.1                      4.2                         4.3                                 4.4.                                   
            if (cuestionario.Nauseas == "Si" || cuestionario.Vomitos == "Si" || (cuestionario.Fotofobia == "Si" && cuestionario.Fonofobia == "Si"))  
                cont++;
            if (cuestionario.Aura == "No")
                cont++;
            //4.6 4.7 y 6.2 todas son validas
            return cont==6;
        }
        public bool MigrañaConAura(Cuestionario cuestionario)
        {
            if (NoObligatoriasMigraña(cuestionario))
                return false;
            cont = 0;
            //A 1
            if (cuestionario.Episodios != Episodios[0]) //1
                cont++;
            //1.1
            if (cuestionario.Duracion == Duracion[0] || cuestionario.Duracion == Duracion[1]) //1.1
                cont++;
            if (cuestionario.Aura == "Si") //4.5
                cont++;
            //4.6 TODAS SON VALIDAS
            //4.7 y 6.2 todas son validas
            return cont == 3;
        }
        public bool MigrañaCronica(Cuestionario cuestionario)
        {
            if (NoObligatoriasMigraña(cuestionario))
                return false;
            cont = 0;
            //1
            if (cuestionario.Episodios == Episodios[3])
                cont++;
            //A y 1.1
            if (cuestionario.Duracion == Duracion[2])
                cont++;
            //B
            if (cuestionario.Duracion_episodio == Duracion_episodio[6]) //2
                cont++;
            //Criterios migraña sin aura (C)
            short cont2 = 0;
            short cont3 = 0;
            if (cuestionario.Localizacion == "Unilateral") //3.1
                cont2++;
            if (cuestionario.Dolor == "Pulsátil") //3.2
                cont2++;
            if (cuestionario.Intensidad == "Moderado" || cuestionario.Intensidad == "Grave") //3.3
                cont2++;
            if (cuestionario.Actividad_fisica == "Si")  //3.4
                cont2++;
            if (cont2 >= 2)
            {
                //D  4.1; 4.2; 4.3; 4.4.
                if (cuestionario.Nauseas == "Si" || cuestionario.Vomitos == "Si" || (cuestionario.Fotofobia == "Si" && cuestionario.Fonofobia == "Si"))
                    cont3++;
            }
            //4.5   
            if (cuestionario.Aura == "Si")
                cont3++;
            //4.6 4.7 y 6.2 todas son validas
            if (cont3 >= 1)
                cont++;
            return cont == 4;
        }
        public bool CefaleaTensionEpisodica(Cuestionario cuestionario)
        {
            if (NoObligatoriasCefalea(cuestionario))
                return false;
            cont = 0;
            //A 1
            if(cuestionario.Episodios==Episodios[2] || cuestionario.Episodios == Episodios[3])
                cont++;
            //1.1
            if (cuestionario.Duracion == Duracion[1] || cuestionario.Duracion == Duracion[0])
                cont++;
            //B 2
            if(cuestionario.Duracion_episodio==Duracion_episodio[4] || cuestionario.Duracion_episodio == Duracion_episodio[5] || cuestionario.Duracion_episodio == Duracion_episodio[6] || cuestionario.Duracion_episodio==Duracion_episodio[7])
                cont++;
            //C 3.1
            short cont2 = 0;
            if (cuestionario.Localizacion == "Bilateral")
                cont2++;
            //3.2
            if(cuestionario.Dolor== "Opresivo")
                cont2++;
            //3.3
            if (cuestionario.Intensidad == "Leve" || cuestionario.Intensidad == "Moderado")
                cont2++;
            //3.4
            if (cuestionario.Actividad_fisica == "No")
                cont2++;
            if (cont2 >= 2)
                cont++;
            //D  4.1; 4.2
            if(cuestionario.Nauseas=="No" && cuestionario.Vomitos == "No")
            {
                //4.3; 4.4
                if (cuestionario.Fonofobia == "Si" && cuestionario.Fonofobia == "Si")
                    return false;
                else
                    if (cuestionario.Aura == "No")
                        cont++;
            }
            return cont == 5;
        }
        public bool CefaleaTensionCronica(Cuestionario cuestionario)
        {
            if (NoObligatoriasCefalea(cuestionario))
                return false;
            cont = 0;
            //A 1.
            if (cuestionario.Episodios == Episodios[3])
                cont++;
            //A 1.1
            if (cuestionario.Duracion == Duracion[2])
                cont++;
            //B 2
            if (cuestionario.Duracion_episodio == Duracion_episodio[4] || cuestionario.Duracion_episodio == Duracion_episodio[5] || cuestionario.Duracion_episodio == Duracion_episodio[6] || cuestionario.Duracion_episodio == Duracion_episodio[7])
                cont++;
            //C 3.1
            short cont2 = 0;
            if (cuestionario.Localizacion == "Bilateral")
                cont2++;
            //3.2
            if (cuestionario.Dolor == "Opresivo")
                cont2++;
            //3.3
            if (cuestionario.Intensidad == "Leve" || cuestionario.Intensidad == "Moderado")
                cont2++;
            //3.4
            if (cuestionario.Actividad_fisica == "No")
                cont2++;
            if (cont2 >= 2)
                cont++;
            //D 4.2
            if (cuestionario.Vomitos == "No")
                cont++;
            short cont3 = 0;
            //4.1;
            if (cuestionario.Nauseas == "Si")
                cont3++;
            //4.3
            if (cuestionario.Fotofobia == "Si")
                cont3++;
            //4.4
            if (cuestionario.Fonofobia == "Si")
                cont3++;
            if (cont3 <= 1)
                cont++;
            return cont == 6;   
        }
        public bool CefaleaRacimos(Cuestionario cuestionario)       
        {
            if (NoObligatoriasMigraña(cuestionario))
                return false;
            cont = 0;
            //A
            if (cuestionario.Episodios != Episodios[0]) //1
                cont++;
            //1.1 TODAS SON VALIDAS
            //B
            if (cuestionario.Duracion_episodio == Duracion_episodio[3] || cuestionario.Duracion_episodio == Duracion_episodio[4]) //2
                cont++;
            short cont2 = 0;
            if (cuestionario.Localizacion == "Unilateral") //3.1
                cont2++;
            //3.2 todas son válidas
            if (cuestionario.Intensidad == "Grave") //3.3
                cont2++;
            if (cuestionario.Actividad_fisica == "No")  //3.4
                cont2++;
            if (cont2 == 3)
                cont++;
            //    4.5   resto obligatorias todas son validas 
            if (cuestionario.Aura == "No")
                cont++;
            //  4.6 y 4.7 6.2 TRIPTAN TODAS VALIDAS
            if (cuestionario.Ipsilaterales == "Si" || cuestionario.Inquietud == "Si")
                cont++;
            return cont == 5;
        }
        public bool HemicraneaParoxistica(Cuestionario cuestionario)
        {
            if (cuestionario.Trayectoria_lineal == "Si" || cuestionario.Inicio_brusco == "Si" || cuestionario.Triptan_ergotico == "Si" || cuestionario.Tos == "Si" || cuestionario.Esfuerzo_brusco == "Si" || cuestionario.Valsalva == "Si" || cuestionario.Actividad_sexual == "Si" || cuestionario.Sueño == "Si" || cuestionario.Inicio_inconfundible == "Si" || cuestionario.Triptan_ergotico == "Si")
                return false;
            cont = 0;
            //A
            if (cuestionario.Episodios == Episodios[3]) //1
                cont++;
            //1.1 todas son validas
            //B
            if (cuestionario.Duracion_episodio == Duracion_episodio[2] || cuestionario.Duracion_episodio == Duracion_episodio[3]) //2
                cont++;
            short cont2 = 0;
            if (cuestionario.Localizacion == "Unilateral") //3.1
                cont2++;
            //3.2 todas son validas
            if (cuestionario.Intensidad == "Grave" ||cuestionario.Intensidad=="Moderada") //3.3
                cont2++;
            //3.4  todas son validas
            if (cont2 == 2)
                cont++;
            //  4.5   las demas todas son validas
            if (cuestionario.Aura == "No")
                cont++;
            //C  4.6; 4.7           
            if (cuestionario.Ipsilaterales == "Si" || cuestionario.Inquietud == "Si")
                cont++;
            //E  6.1
            if (cuestionario.Indometacina == "Si")
                cont++;
            return cont == 6;
        }
        public bool SUNCTySUNA(Cuestionario cuestionario)
        {
            if (cuestionario.Trayectoria_lineal == "Si" || cuestionario.Inicio_brusco == "Si" || cuestionario.Indometacina == "Si" || cuestionario.Triptan_ergotico == "Si" || cuestionario.Tos == "Si" || cuestionario.Esfuerzo_brusco == "Si" || cuestionario.Valsalva == "Si" || cuestionario.Actividad_sexual == "Si" || cuestionario.Inicio_inconfundible == "Si" || cuestionario.Triptan_ergotico == "Si"  || cuestionario.Sueño == "Si")
                return false;
            cont = 0;
            //A
            if (cuestionario.Episodios == Episodios[3]) //1
                cont++;
            //1.1 todas son validas
            //B
            if (cuestionario.Duracion_episodio == Duracion_episodio[0] || cuestionario.Duracion_episodio == Duracion_episodio[1] || cuestionario.Duracion_episodio == Duracion_episodio[2]) //2
                cont++;
            //demas obligatorias todas son validas
            short cont2 = 0;
            if (cuestionario.Localizacion == "Unilateral") //3.1
                cont2++;
            if (cuestionario.Intensidad == "Grave" || cuestionario.Intensidad=="Moderado") //3.3
                cont2++;
            if (cont2 == 2)
                cont++;
            //  4.5   
            if (cuestionario.Aura == "No")
                cont++;
            //D  4.6; 4.7 todas son validas 
            if (cuestionario.Ipsilaterales == "Si")
                cont++;
            return cont == 5;
        }
        public bool HemicraneaContinua(Cuestionario cuestionario)
        {
            if (cuestionario.Trayectoria_lineal == "Si" || cuestionario.Inicio_brusco == "Si"  || cuestionario.Triptan_ergotico == "Si" || cuestionario.Tos == "Si" || cuestionario.Esfuerzo_brusco == "Si" || cuestionario.Valsalva == "Si" || cuestionario.Actividad_sexual == "Si"  || cuestionario.Triptan_ergotico == "Si"  || cuestionario.Sueño == "Si")
                return false;
            cont = 0;
            //A todas son validas
            //1.1
            if (cuestionario.Duracion == Duracion[2]) //1.1
                cont++;
            //B
            if (cuestionario.Duracion_episodio == Duracion_episodio[5] || cuestionario.Duracion_episodio == Duracion_episodio[6] || cuestionario.Duracion_episodio == Duracion_episodio[7]) //2
                cont++;
            //B
            if (cuestionario.Localizacion == "Unilateral") //3.1
                cont++;
            //  4.5   
            if (cuestionario.Aura == "No")
                cont++;
            //D  4.6; 4.7           
            if(cuestionario.Ipsilaterales=="Si" || cuestionario.Inquietud=="Si" )   //D
                 cont++;
            //E 6.1 7.6 inicio incond todas validas
            if (cuestionario.Indometacina == "Si")
                cont++;
            return cont == 6;
        }
        public bool TusigenaPrimaria(Cuestionario cuestionario)
        {
            if (cuestionario.Trayectoria_lineal == "Si" || cuestionario.Inicio_brusco == "Si" || cuestionario.Triptan_ergotico == "Si" || cuestionario.Actividad_sexual == "Si" || cuestionario.Inicio_inconfundible == "Si" || cuestionario.Triptan_ergotico == "Si" || cuestionario.Ipsilaterales == "Si"  || cuestionario.Sueño == "Si")
                return false;
            cont = 0;
            //A 1
            if (cuestionario.Episodios != Episodios[0])
                cont++;
            //1.1 validas todas
            //D 2 
            if (cuestionario.Duracion_episodio == Duracion_episodio[0] || cuestionario.Duracion_episodio == Duracion_episodio[1] || cuestionario.Duracion_episodio == Duracion_episodio[2] || cuestionario.Duracion_episodio == Duracion_episodio[3] || cuestionario.Duracion_episodio == Duracion_episodio[4])
                cont++;
            //todas son validas
            //  4.5   
            if (cuestionario.Aura == "No")
                cont++;
            // 4.7inquietud 6.1 indometacina todas son validas
            //B 7.1; 7.2(todas son validas); 7.3
            if (cuestionario.Tos=="Si"  || cuestionario.Valsalva == "Si")
                cont++;
            return cont == 4;
        }
        public bool EsfuerzoFisicoPrimaria(Cuestionario cuestionario)
        {
            if (cuestionario.Trayectoria_lineal == "Si" || cuestionario.Inicio_brusco == "Si"  || cuestionario.Triptan_ergotico == "Si" || cuestionario.Tos == "Si" || cuestionario.Valsalva == "Si" || cuestionario.Actividad_sexual == "Si" || cuestionario.Inicio_inconfundible == "Si" || cuestionario.Triptan_ergotico == "Si" || cuestionario.Ipsilaterales == "Si" ||  cuestionario.Sueño == "Si")
                return false;
                cont = 0;
            //A 1
            if (cuestionario.Episodios != Episodios[0])
                cont++;
            //1.1 todas validas
            //D 2 
            if (cuestionario.Duracion_episodio!=Duracion_episodio[0] && cuestionario.Duracion_episodio != Duracion_episodio[7] && cuestionario.Duracion_episodio != Duracion_episodio[8])
                cont++;
            //resto obligatorias todas son validas
            //  4.5   
            if (cuestionario.Aura == "No")
                cont++;
            //4.7 y 6.1 todas son validas
            //B  7.2;
            if (cuestionario.Esfuerzo_brusco == "Si" )
                cont++;           
            return cont == 4;
        }
        public bool ActividadSexualPrimaria(Cuestionario cuestionario)
        {
            cont = 0;
            if (cuestionario.Trayectoria_lineal == "Si" || cuestionario.Inicio_brusco == "Si" || cuestionario.Indometacina == "Si" || cuestionario.Triptan_ergotico == "Si" || cuestionario.Tos == "Si" || cuestionario.Esfuerzo_brusco == "Si" || cuestionario.Valsalva == "Si" || cuestionario.Inicio_inconfundible == "Si" || cuestionario.Triptan_ergotico == "Si" || cuestionario.Ipsilaterales == "Si"  || cuestionario.Sueño == "Si")
                return false;
            //A 1
            if (cuestionario.Episodios != Episodios[0])
                cont++;
            //1.1 todas son validas 
            //D 2 
            if (cuestionario.Duracion_episodio != Duracion_episodio[0] && cuestionario.Duracion_episodio != Duracion_episodio[7] && cuestionario.Duracion_episodio != Duracion_episodio[8])
                cont++;
            //demas obligatorias todas son validas
            //  4.5 
            if (cuestionario.Aura == "No")
                cont++;
            //4.7 todas son validas   
            //B  7.4;
            if (cuestionario.Actividad_sexual == "Si")
                cont++;
            return cont == 4;
        }
        public bool CefaleaTruenoPrimaria(Cuestionario cuestionario)
        {
            if (cuestionario.Indometacina == "Si" || cuestionario.Triptan_ergotico == "Si" || cuestionario.Tos == "Si" || cuestionario.Esfuerzo_brusco == "Si" || cuestionario.Valsalva == "Si" || cuestionario.Actividad_sexual == "Si" || cuestionario.Inicio_inconfundible == "Si" || cuestionario.Triptan_ergotico == "Si" || cuestionario.Sueño == "Si")
                return false;
            cont = 0;
            //A 1
            if (cuestionario.Episodios != Episodios[0])
                cont++;
            //1.1 todas son validas
            //D 2 
            if (cuestionario.Duracion_episodio != Duracion_episodio[0] && cuestionario.Duracion_episodio != Duracion_episodio[1] && cuestionario.Duracion_episodio != Duracion_episodio[8])
                cont++;
            //B todas las demas obligatorias son validas
            if (cuestionario.Intensidad == "Grave") //3.3
                cont++;
            //  4.5   
            if (cuestionario.Aura == "No")
                cont++;
            //4.6 4.7 4.8 todas son validas
            //B 5
            if (cuestionario.Inicio_brusco == "Si")
                cont++;
            return cont == 5;
        }
        public bool CefaleaPunzantePrimaria(Cuestionario cuestionario)
        {
            if (cuestionario.Trayectoria_lineal == "Si" || cuestionario.Inicio_brusco == "Si" || cuestionario.Triptan_ergotico == "Si" || cuestionario.Tos == "Si" || cuestionario.Esfuerzo_brusco == "Si" || cuestionario.Valsalva == "Si" || cuestionario.Actividad_sexual == "Si" || cuestionario.Inicio_inconfundible == "Si" || cuestionario.Triptan_ergotico == "Si" || cuestionario.Ipsilaterales == "Si" || cuestionario.Inquietud == "Si" || cuestionario.Sueño == "Si")
                return false;
            cont = 0;
            //A 1
            if (cuestionario.Episodios == Episodios[3])
                cont++;
            //1.1 todas son validas
            //D 2 
            if (cuestionario.Duracion_episodio == Duracion_episodio[0])
                cont++;
            //las demas obligatorias todas son validas
            if (cuestionario.Dolor == "Otro") //3.2 C
                cont++;
            //   4.5   
            if (cuestionario.Aura == "No")
                cont++;
            //6.1 todas son validas
            return cont == 4;
        }
        public bool CefaleaNumular(Cuestionario cuestionario)
        {
            if (cuestionario.Trayectoria_lineal == "Si" || cuestionario.Inicio_brusco == "Si" || cuestionario.Indometacina == "Si" || cuestionario.Triptan_ergotico == "Si" || cuestionario.Tos == "Si" || cuestionario.Esfuerzo_brusco == "Si" || cuestionario.Valsalva == "Si" || cuestionario.Actividad_sexual == "Si" || cuestionario.Inicio_inconfundible == "Si" || cuestionario.Triptan_ergotico == "Si" || cuestionario.Ipsilaterales == "Si" || cuestionario.Inquietud == "Si" || cuestionario.Sueño=="Si")
                return false;
            cont = 0;
            //A 1 y 1.1 todas son validas
            //D 2 
            if (cuestionario.Duracion_episodio != Duracion_episodio[8] && cuestionario.Duracion_episodio != Duracion_episodio[0])
                cont++;
            //B
            if (cuestionario.Localizacion == "En área de cuero cabelludo") //3.1
                cont++;
            //   4.5   resto obligatorias todas son validas
            if (cuestionario.Aura == "No")
                cont++;
            return cont == 3;
        }
        public bool CefaleaHipnicaPrimaria(Cuestionario cuestionario)
        {
            if (cuestionario.Trayectoria_lineal == "Si" || cuestionario.Inicio_brusco == "Si" || cuestionario.Indometacina == "Si" || cuestionario.Triptan_ergotico == "Si" || cuestionario.Tos == "Si" || cuestionario.Esfuerzo_brusco == "Si" || cuestionario.Valsalva == "Si" || cuestionario.Actividad_sexual == "Si" || cuestionario.Inicio_inconfundible == "Si" || cuestionario.Triptan_ergotico == "Si" || cuestionario.Ipsilaterales == "Si" || cuestionario.Inquietud == "Si")
                return false;
            cont = 0;
            //A 1
            if (cuestionario.Episodios == Episodios[3])
                cont++;
            //1.1
            if (cuestionario.Duracion == Duracion[1] || cuestionario.Duracion == Duracion[2]) //1.1
                cont++;
            //D 2 
            if (cuestionario.Duracion_episodio == Duracion_episodio[3] || cuestionario.Duracion_episodio == Duracion_episodio[4] || cuestionario.Duracion_episodio == Duracion_episodio[5])
                cont++;
            //resto obligatorias todas son validas
            //B 7.5
            if (cuestionario.Sueño == "Si")
                cont++;
            return cont == 4;
        }
        public bool CefaleaDiariaPersistente(Cuestionario cuestionario)
        {
            if (cuestionario.Trayectoria_lineal == "Si" || cuestionario.Inicio_brusco == "Si" || cuestionario.Indometacina == "Si" || cuestionario.Triptan_ergotico == "Si" || cuestionario.Tos == "Si" || cuestionario.Esfuerzo_brusco == "Si" || cuestionario.Valsalva == "Si" || cuestionario.Actividad_sexual == "Si" || cuestionario.Sueño == "Si" || cuestionario.Triptan_ergotico == "Si" || cuestionario.Ipsilaterales == "Si" || cuestionario.Inquietud == "Si")
                return false;
                cont = 0;
            //A 1 todas son validas
            //1.1
            if (cuestionario.Duracion == Duracion[2]) //1.1
                cont++;
            //D 2 
            if (cuestionario.Duracion_episodio == Duracion_episodio[6] || cuestionario.Duracion_episodio == Duracion_episodio[7])
                cont++;
            //demás obligatorias todas son validas
            //C 7.6
            if (cuestionario.Inicio_inconfundible =="Si")
                cont++;

            return cont == 3;
        }
        public bool EpicraniaFugax(Cuestionario cuestionario)
        {
            if (cuestionario.Inicio_brusco == "Si" || cuestionario.Indometacina == "Si" || cuestionario.Tos == "Si" || cuestionario.Esfuerzo_brusco == "Si" || cuestionario.Valsalva == "Si" || cuestionario.Actividad_sexual == "Si" || cuestionario.Sueño == "Si" || cuestionario.Inicio_inconfundible == "Si" || cuestionario.Triptan_ergotico == "Si")
                return false;
                cont = 0;
            //1
            if (cuestionario.Episodios != Episodios[0])
                cont++;
            //1.1. todas son validas
            if (cuestionario.Duracion_episodio == Duracion_episodio[0])
                cont++;
            //3.1
            if(cuestionario.Localizacion== "En área de cuero cabelludo")
            //A 3.2
            if (cuestionario.Dolor == "Otro")
                cont++;
            //4.5  las demas todas validas
            if (cuestionario.Aura == "No")
                cont++;
            //4.7 todas son validas
            //4.8
            if (cuestionario.Trayectoria_lineal == "Si")
                cont++;
            return cont == 5;
        }

    }
}

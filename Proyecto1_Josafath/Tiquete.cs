using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_Josafath.Usuario
{
   class Tiquete
    {
        public int numeroTiquete;
        public DateTime fechaViaje;
        public int numeroAsiento;
        public DateTime holaSalida;
        public String lugarSalida;
        public String destino;
        public bool equipaje;
        public int numeroEquipaje;

        public String nombrepasajero;
        public int pasaporte;
        public DateTime vigencia;
        public DateTime fecharegreso;
        public String motivoviaje;

        public Tiquete(int numeroTiquete,DateTime fechaViaje, int numeroAsiento, DateTime horaSalida, String lugarSalida, String destino,bool equipaje,int numeroEquipaje,String nombrepasajero, int pasaporte ,DateTime vigencia, DateTime fecharegreso, string motivoviaje)
        {
            numeroTiquete = numeroTiquete;
            fechaViaje = fechaViaje;
            numeroAsiento = numeroAsiento;
            holaSalida = horaSalida;
            lugarSalida = lugarSalida;
            destino = destino;
            equipaje = equipaje;
            numeroEquipaje = numeroEquipaje;

            nombrepasajero = nombrepasajero;
            pasaporte = pasaporte;
            vigencia = vigencia;
            fecharegreso = fecharegreso;
            motivoviaje = motivoviaje;

        }


        public void setNumeroTiquete(int numeroTiquete)
        {
            numeroTiquete = numeroTiquete;
        }
        public void setfechaViaje(DateTime fechaViaje)
        {
            fechaViaje = fechaViaje;
        }
        public void setnumeroAsiento(int numeroAsiento)
        {
            numeroAsiento = numeroAsiento;
        }
        public void sethoraSalida(DateTime horaSalida)
        {
            holaSalida = horaSalida;
        }
        public void setlugarSalida(string lugarSalida)
        {
            lugarSalida = lugarSalida;
        }
        public void setdestino(string destino)
        {
            destino = destino;
        }
        public void setequipaje(bool equipaje)
        {
            equipaje = equipaje;
        }
        public void setNumeroEquipaje(int numeroEquipaje)
        {
            numeroEquipaje = numeroEquipaje;
        }

        public int getNumeroTiquete()
        {
            return numeroTiquete ;
        }
        public DateTime getfechaViaje()
        {
            return fechaViaje ;
        }
        public int getnumeroAsiento()
        {
            return numeroAsiento ;
        }
        public DateTime gethoraSalida()
        {
            return holaSalida;
        }
        public string getlugarSalida()
        {
            return lugarSalida;
        }
        public string getdestino()
        {
            return destino;
        }
        public bool getequipaje()
        {
            return equipaje;
        }
        public int getNumeroEquipaje()
        {
            return numeroEquipaje;
        }

        public static Tiquete leerUnidad(List<Tiquete> tiquetes, int id)
        {
            for (int i = 0; i < tiquetes.Count; i++)
            {
                if (tiquetes[i].getNumeroTiquete() == id)
                {
                    return tiquetes[i];
                }
            }
            return null;

        }

        public static void modificarUnidad(List<Tiquete> tiquetes, int numeroTiquete, DateTime fechaViaje, int numeroAsiento,
            DateTime horaSalida, String lugarSalida, String destino, bool equipaje, int numeroEquipaje)
        {
            for (int i = 0; i < tiquetes.Count; i++)
            {
                if (tiquetes[i].getNumeroTiquete() == numeroTiquete)
                {
                    tiquetes[i].setNumeroTiquete(numeroTiquete);
                    tiquetes[i].setfechaViaje(fechaViaje);
                    tiquetes[i].setnumeroAsiento(numeroAsiento);
                    tiquetes[i].sethoraSalida(horaSalida);
                    tiquetes[i].setlugarSalida(lugarSalida);
                    tiquetes[i].setdestino(destino);
                    tiquetes[i].setequipaje(equipaje);
                    tiquetes[i].setNumeroEquipaje(numeroEquipaje);
                    Console.WriteLine("se modifico el tiquete");
                }
            }
        }

        public static void eliminarUnidad(List<Tiquete> tiquetes, int id)
        {
            for (int i = 0; i < tiquetes.Count; i++)
            {
                if (tiquetes[i].getNumeroTiquete() == id)
                {
                    tiquetes.Remove(tiquetes[i]);
                    Console.WriteLine("se elimino el tiquete ");
                }
            }

        }








    }
}

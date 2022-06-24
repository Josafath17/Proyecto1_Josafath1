using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_Josafath.Administrador
{
   class Horario
    {
        private int identificadorHorario;
        private int identificadorRuta;
        private int identificadorTeminal;
        private DateTime dia;
        private DateTime horaSalida;
        private DateTime horaLlegada;

        public Horario(int identificadorHorario, int identificadorRuta, int identificadorTeminal, DateOnly dia, DateTime horaSalida, DateTime horaLlegada)
        {
            identificadorHorario = identificadorHorario;
            identificadorRuta = identificadorRuta;
            identificadorTeminal = identificadorTeminal;
            dia = dia;
            horaSalida = horaSalida;
            horaLlegada = horaLlegada;
        }

        public void setidentificadorHorario(int identificadorHorario)
        {
            identificadorHorario = identificadorHorario;
        }
        public void setidentificadorRuta(int identificadorRuta)
        {
            identificadorRuta = identificadorRuta;
        }
        public void setidentificadorTeminal(int identificadorTeminal)
        {
            identificadorTeminal = identificadorTeminal;
        }
        public void setDia(DateTime dia)
        {
            dia = dia;
        }
        public void setHoraSalida(DateTime horaSalida)
        {
            horaSalida = horaSalida;
        }
        public void setHoraLlegada(DateTime horaLlegada)
        {
            horaLlegada = horaLlegada;
        }
        public int getidentificadorHorario()
        {
            return identificadorHorario;
        }
        public int getidentificadorRuta()
        {
            return identificadorRuta;
        }
        public int getidentificadorTeminal()
        {
            return identificadorTeminal;
        }
        public DateTime getDia()
        {
            return dia;
        }
        public DateTime getHoraSalida()
        {
            return horaSalida;
        }
        public DateTime getHoraLlegada()
        {
            return horaLlegada;
        }

        public static void crearHorario(int identificadorHorario, int identificadorRuta, int identificadorTeminal, DateOnly dia, DateTime horaSalida, DateTime horaLlegada)
        {
            StreamWriter newUnidad = File.AppendText("Horario.txt");
            newUnidad.WriteLine(identificadorHorario.ToString() + "," + identificadorRuta.ToString() + "," + identificadorTeminal.ToString() +
            "," + dia.ToString() + "," + horaSalida.ToString() + "," + horaLlegada.ToString());
            newUnidad.Close();

        }

        public static Horario leerHorario(List<Horario> horarios, int id)
        {
            for (int i = 0; i < horarios.Count; i++)
            {
                if (horarios[i].getidentificadorHorario() == id)
                {
                    return horarios[i];
                }
            }
            return null;

        }

        public static void modificarHorario(List<Horario> horarios, int id, int idRuta,int idTermi,DateTime dia, DateTime leave,DateTime arrive)
        {
            for (int i = 0; i < horarios.Count; i++)
            {
                if (horarios[i].getidentificadorHorario() == id)
                {
                    horarios[i].setidentificadorHorario(id);
                    horarios[i].setidentificadorRuta(idRuta);
                    horarios[i].setidentificadorTeminal(idTermi);
                    horarios[i].setDia(dia);  
                    horarios[i].setHoraSalida(leave);
                    horarios[i].setHoraLlegada(arrive);
                    Console.WriteLine("se modifico el horario");
                }
            }
        }

        public static void eliminarHorario(List<Horario> horarios, int id)
        {
            for (int i = 0; i < horarios.Count; i++)
            {
                if (horarios[i].getidentificadorHorario() == id)
                {
                    horarios.Remove( horarios[i]);
                    Console.WriteLine("se elimino el horario");
                }
            }
        }
    }
}

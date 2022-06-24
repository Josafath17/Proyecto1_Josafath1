using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_Josafath.Administrador
{
  class Unidad
    {

        public int codigoUnidad;
        public int numeroPlaca;
        public int numeroMotor;
        public int Modelo;
        public int Capacidad;
        public string Color;
        public int rutaAsignada;
        public int numeroPermisoTransito;
        public DateTime fechaVigencia;
        
        public Unidad(int codigoUnidad, int numeroPlaca, int numeroMotor,
            int Modelo, int Capacidad, string Color, int rutaAsignada, int numeroPermisoTransito, DateTime fechaVigencia)
        {
            codigoUnidad = codigoUnidad;
            numeroPlaca = numeroPlaca;
            numeroMotor = numeroMotor;
            Modelo = Modelo;
            Capacidad = Capacidad;
            Color = Color;
            rutaAsignada = rutaAsignada;
            numeroPermisoTransito = numeroPermisoTransito;
            fechaVigencia = fechaVigencia;
        }

        public void setCodigoUnidad(int id)
        {
            codigoUnidad = codigoUnidad;
        }
        public void setNumeroPlaca(int numPlaca)
        {
            numeroPlaca = numeroPlaca;
        }
        public void setNumeroMotor(int numMotor)
        {
            numeroMotor = numMotor;
        }
        public void setModelo(int model)
        {
            Modelo = model;
        }
        public void setCapacidad(int cap)
        {
            Capacidad = cap;
        }
        public void setColor(string color)
        {
            Color = color;
        }

        public void setRutaAsignada(int rutita)
        {
            rutaAsignada = rutita;
        }

        public void setNumeroPermisoTraansito(int numPermiso)
        {
            numeroPermisoTransito = numPermiso;
        }
        public void setFechaVigencia(DateTime fechaV)
        {
            fechaVigencia = fechaV;
        }
        public int getCodigoUnidad()
        {
            return codigoUnidad;
        }
        public int getNumeroPlaca()
        {
            return numeroPlaca;
        }
        public int getNumeroMotor()
        {
           return numeroMotor;
        }
        public int getModelo(int model)
        {
            return Modelo ;
        }
        public int getCapacidad(int cap)
        {
            return Capacidad;
        }
        public string getColor(string color)
        {
            return Color;
        }
        public int getRutaAsignada()
        {
            return rutaAsignada;
        }
        public int getNumeroPermisoTraansito()
        {
            return numeroPermisoTransito ;
        }
        public DateTime getFechaVigencia()
        {
            return fechaVigencia; 
        }



        public static void crearUnidad(int codigoUnidad,int numeroPlaca,int numeroMotor,
            int Modelo, int Capacidad,string Color, int rutaAsignada, int numeroPermisoTransito, DateTime fechaVigencia)
        {
            StreamWriter newUnidad = File.AppendText("Unidades.txt");
            newUnidad.WriteLine(codigoUnidad.ToString() + "," + numeroPlaca.ToString() + "," + numeroMotor.ToString() + "," + Modelo.ToString()
             + "," + Capacidad.ToString() + "," + Color.ToString() + "," + rutaAsignada.ToString() + "," + numeroPermisoTransito.ToString() + "," + fechaVigencia.ToString() );
            newUnidad.Close();

        }



        public static Unidad leerUnidad(List<Unidad> unidades, int id)
        {
            for (int i = 0; i < unidades.Count; i++)
            {
                if (unidades[i].getCodigoUnidad() == id)
                {
                    return unidades[i];
                }
            }
            return null;

        }

        public static void modificarUnidad(List<Unidad> unidades, int id, int numPlac, int numMotor, int modelo,int capacidad, string color, int rutaAsig,int numPermi, DateTime fechav)
        {
            for (int i = 0; i < unidades.Count; i++)
            {
                if (unidades[i].getCodigoUnidad() == id)
                {
                    unidades[i].setCodigoUnidad(id);
                    unidades[i].setNumeroPlaca(numPlac);
                    unidades[i].setNumeroMotor(numMotor);
                    unidades[i].setModelo(modelo);
                    unidades[i].setCapacidad(capacidad);
                    unidades[i].setColor(color);
                    unidades[i].setRutaAsignada(rutaAsig);
                    unidades[i].setNumeroPermisoTraansito(numPermi);
                    unidades[i].setFechaVigencia(fechav);
                    Console.WriteLine("se modifico la unidad");
                }
            }
        }
     
        public static void eliminarUnidad(List<Unidad> unidades, int id)
        {
            for (int i = 0; i < unidades.Count; i++)
            {
                if (unidades[i].getCodigoUnidad() == id)
                {
                    unidades.Remove( unidades[i]);
                    Console.WriteLine("se elimino la unidad ");
                }
            }

        }
    }
}

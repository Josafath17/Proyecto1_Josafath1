using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_Josafath.Administrador
{
  class Terminal
    {
        public int codigoTerminal;
        public String nombreTerminal;
        public String ubicacionTerminal;

        public Terminal(int codigoTerminal, string nombreTerminal, string ubicacionTerminal)
        {
            this.codigoTerminal = codigoTerminal;
            this.nombreTerminal = nombreTerminal;
            this.ubicacionTerminal = ubicacionTerminal;
        }

        public void setCodigoTerminal(int codigoTerminal)
        {
            codigoTerminal = codigoTerminal;
        }
        public void setNombreTerminal(string nombreTerminal)
        {
            nombreTerminal = nombreTerminal;
        }
        public void setubicacionTerminal(string ubicacionTerminal)
        {
            ubicacionTerminal = ubicacionTerminal;
        }

        public int getCodigoTerminal()
        {
            return codigoTerminal;
        }
        public string getNombreTerminal()
        {
            return nombreTerminal;
        }
        public string getubicacionTerminal()
        {
            return ubicacionTerminal;
        }



        public static void crearTerminal(int codigoTerminal, string nombreTerminal, string ubicacionTerminal)
        {
            StreamWriter newTerminal = File.AppendText("Terminales.txt");
            newTerminal.WriteLine(codigoTerminal.ToString() + "," + nombreTerminal.ToString() + "," + ubicacionTerminal.ToString());
            newTerminal.Close();

        }

        public static Terminal leerTerminal(List<Terminal> terminales, int id)
        {
            for (int i = 0; i < terminales.Count; i++)
            {
                if (terminales[i].getCodigoTerminal() == id)
                {
                    return terminales[i];
                }
            }
            return null;
        }

        public static void modificarTerminal(List<Terminal> terminales, int id,string nombre, string ubicacion)
        {
            for (int i = 0; i < terminales.Count; i++)
            {
                if (terminales[i].getCodigoTerminal() == id)
                {
                    terminales[i].setCodigoTerminal(id);
                    terminales[i].setNombreTerminal(nombre);
                    terminales[i].setubicacionTerminal(ubicacion);
                    Console.WriteLine("se modifico la terminal");
                }
            }
        }

        public static void eliminarTerminal(List<Terminal> terminales, int id)
        {
            for (int i = 0; i < terminales.Count; i++)
            {
                if (terminales[i].getCodigoTerminal() == id)
                {
                   terminales.Remove(terminales[i]);
                    Console.WriteLine("se elimino la terminal");
                }
            }
        }
    }
}

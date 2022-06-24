using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_Josafath.Administrador
{
    /*
     * la clase Ruta tiene los atributos pertenecientes a una ruta y sus respectivos metodos get y set
     */
    class Ruta
    {
        private int identificador;
        private String nombre;
        private String descripcion;
        private String tipo;

        public Ruta(int id, string tipo, string nombre, string desc)
        { 
            identificador = id;
            tipo = tipo;
            nombre = nombre;
            descripcion = desc;
        }

        public void setIdentificador(int id)
        {
            identificador = id;
        }
        public void setTipo(string tipo)
        {
            tipo = tipo;
        }
        public void setNombre(string nombre)
        {
            nombre = nombre;
        }

        public void setDescripcion(string descri)
        { 
            descripcion= descri;
        }

        public int getIdentificador()
        {
            return identificador;
        }
        public string getTipo()
        {
            return tipo;
        }
        public string getNombre()
        {
            return nombre;
        }

        public string getDescripcion()
        {
            return descripcion;
        }

        /*
         * guarda los datos directos en el archivo de rutas
         */
        public static void crearRuta(int id, string tipo, string nombre, string desc)
        {
            StreamWriter newRuta = File.AppendText("Rutas.txt");
            newRuta.WriteLine(id.ToString() + "," + tipo.ToString() + "," + nombre.ToString() + "," + desc.ToString());
            newRuta.Close();
        }

        /*
         * lee los datos directamente del archivo de rutas
         */
        public static void leerRuta()
        {
            TextReader leer = new StreamReader("Rutas.txt");
            string[] lines = leer.ReadToEnd().Split('\n');
            leer.Dispose();
            for(int i = 0; i < lines.Length; i++)
            {
                Console.WriteLine(lines[i]);   
            }
            leer.Close();
        }
        /*
         * recorre la lista de rutas y mediante el id de la ruta encuentra y devuelve la ruta
         */
        public static Ruta getRuta(List<Ruta> rutas, int id)
        {
            for (int i = 0; i < rutas.Count; i++)
            {
                if (rutas[i].getIdentificador() == id)
                {
                    return rutas[i];
                }
            }

            return null ;
        }
        /*
         * recorre la lista de ruta y con el id busca la ruta en especifico y la edita
         */
        public static void modificarRuta(List<Ruta> rutas,int id,string tipo, string name,string descri )
        {
            for (int i = 0; i < rutas.Count; i++)
            {
                if (rutas[i].getIdentificador() == id)
                {
                    rutas[i].setIdentificador(id);
                    rutas[i].setTipo(tipo);
                    rutas[i].setNombre(name);
                    rutas[i].setDescripcion(descri);
                    Console.WriteLine("se modifico la ruta");
                }
            }
        }
        /*
         * elimina la ruta a la que le pertenece la ruta
         */
        public static void eliminarRuta(List<Ruta> rutas, int id)
        {
            for (int i = 0; i < rutas.Count; i++)
            {
                if (rutas[i].getIdentificador() == id)
                {
                    rutas.Remove(rutas[i]);
                    Console.WriteLine("se elimino la ruta");
                }
            }

        }
        
    }
}

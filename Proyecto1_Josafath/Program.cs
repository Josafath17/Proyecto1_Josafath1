using Proyecto1_Josafath.Administrador;
using System.Collections;


namespace Ejemplo_menu
{
    class Program
    {
        public static List<Ruta> rutas = new List<Ruta>();
        public static List<Terminal> terminales = new List<Terminal>();
        public static List<Unidad> unidades = new List<Unidad>();
        public static List<Horario> horarios = new List<Horario>();


        //List<Usuario> usuarios = new ArrayList();

        public static void cargarArchivos()
        {
            TextReader rutaTxt = new StreamReader("Rutas.txt");
            rutaTxt.Close();
            int id = 0;
            string tipo = "";
            string nombre = "";
            string desc = "";
            Ruta rutita = new Ruta(id, tipo, nombre, desc);





            TextReader ruta = new StreamReader("Rutas.txt");
           // rutas.Add(ruta.ReadToEnd('\n'));
            // = ruta.ReadToEnd().Split();
           // leer.Dispose();

        }

        static void Main(string[] args)
        {
            

        //menuUnidades();
        menuRutas();

            

            Console.ReadLine();

        }
        public static void menuPrincipal()
        {
            bool salir = false;

            while (!salir)
            {

                try
                {

                    Console.WriteLine("1. Opción 1: Usuario Regular");
                    Console.WriteLine("2. Opción 2: Usuario Administrador");
                    Console.WriteLine("3. Salir");
                    Console.WriteLine("Elige una de las opciones");
                    int opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Has elegido la opción 1");
                            menuUsuario();
                            break;

                        case 2:
                            Console.WriteLine("Has elegido la opción 2");
                            menuAdministrador();
                            break;
                        case 3:
                            Console.WriteLine("Has elegido salir de la aplicación");
                            salir = true;
                            break;
                        default:
                            Console.WriteLine("Elige una opcion entre 1 y 3");
                            break;
                    }

                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

        }
        public static void menuAdministrador()
        {
            Console.WriteLine("menu administrador ");
            int opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("1.Ruta");
                    menuRutas();
                    break;

                case 2:
                    Console.WriteLine("2.Terminal");
                    menuTerminales();
                    break;
                case 3:
                    Console.WriteLine("3.Unidad");
                    menuUnidades();
                    break;
                case 4:
                    Console.WriteLine("4.Horario");
                    menuHorarios();
                    break;
                default:
                    Console.WriteLine("Elige una opcion entre 1 y 4");
                    break;
            }

            
        }

        public static void menuUsuario()
        {
            Console.WriteLine("menu usuario");

        }
        public static void menuRutas()
        {
            Console.WriteLine("1. Opción 1: Crear Ruta");
            Console.WriteLine("2. Opción 2: Leer Rutas");
            Console.WriteLine("3. Opción 2: Modificar Rutas");
            Console.WriteLine("4. Opción 2: Eliminar Rutas");
            Console.WriteLine("5. Salir");
            Console.WriteLine("Elige una de las opciones");
            int opcion = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite el codigo de la ruta");
            int buscarCodigoRuta = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    int ident = 1;
                    string tipo = "1";
                    string nombre = "San Jose - Paso Canoas";
                    string desc = "San José - Quepos - Paso Canoas(Viceversa)";

                   
                    Ruta.crearRuta(ident, tipo, nombre,desc);
                    Ruta ruta = new Ruta(ident, tipo, nombre, desc);
                    menuRutas();
                    break;

                case 2:
                    Ruta.getRuta(rutas, buscarCodigoRuta);
                    menuRutas();
                    break;
                case 3:
                    string id;
                    //Ruta.modificarRuta(rutas,id, tipo, nombre, desc);
                    menuRutas();
                    break;
                case 4:
                    Ruta.eliminarRuta(rutas,buscarCodigoRuta);
                    menuRutas();
                    break;
                default:
                    Console.WriteLine("Elige una opcion entre 1 y 4");
                    break;
            }

        }

        public static void menuTerminales()
        {
            Console.WriteLine("1. Opción 1: Crear Terminal");
            Console.WriteLine("2. Opción 2: Leer Terminal");
            Console.WriteLine("3. Opción 3: Modificar Terminal");
            Console.WriteLine("4. Opción 4: Eliminar Terminal");
            Console.WriteLine("5. Salir");
            Console.WriteLine("Elige una de las opciones");
            int opcion = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite el codigo de la Unidad");
            int buscarCodigoTerminal = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    //Terminal.crearTerminal(id,nombre,ubicacion);
                    //Terminal terminal = new Terminal(id, nombre, ubicacion);
                    menuTerminales();
                    break;

                case 2:
                    Terminal.leerTerminal(terminales,buscarCodigoTerminal) ;
                    menuTerminales();
                    break;
                case 3:
                    //Terminal.modificarTerminal(terminales,id,nombre,ubicacion);
                    menuTerminales();
                    break;
                case 4:
                    Terminal.eliminarTerminal(terminales, buscarCodigoTerminal);
                    menuTerminales();
                    break;
                default:
                    Console.WriteLine("Elige una opcion entre 1 y 4");
                    break;
            }
        }

        public static void menuUnidades()
        {
            Console.WriteLine("1. Opción 1: Crear Unidades");
            Console.WriteLine("2. Opción 2: Leer Unidades");
            Console.WriteLine("3. Opción 3: Modificar Unidades");
            Console.WriteLine("4. Opción 4: Eliminar Unidades");
            Console.WriteLine("5. Salir");
            Console.WriteLine("Elige una de las opciones");
            int opcion = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite el codigo de la Unidad");
            int buscarCodigoUnidad = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    //int codigoUnidad=1;
                    //int numeroPlaca=1;
                    //int numeroMotor=1;
                    //int Modelo=97;
                    //int Capacidad=5;
                    //string Color="verde";
                    //int rutaAsignada=1;
                    //int numeroPermisoTransito=1;
                    //DateTime fechaVigencia = DateTime.Now;

                    Console.WriteLine("Digite el codigo de la Unidad");
                    int codigoUnidad = int.Parse(Console.ReadLine());
                    Console.WriteLine("Numero de placa del Autobus");
                    int numeroPlaca = int.Parse(Console.ReadLine());
                    Console.WriteLine("Numero del motor del Autobus");
                    int numeroMotor = int.Parse(Console.ReadLine());
                    Console.WriteLine("Modelo del autobus");
                    int Modelo = int.Parse(Console.ReadLine());

                    Console.WriteLine("Capacidad de pasajeros");
                    int Capacidad = int.Parse(Console.ReadLine());
                    Console.WriteLine("Color del Autobus");
                    string Color = (Console.ReadLine());
                    Console.WriteLine("Ruta Asignada");
                    int rutaAsignada = int.Parse(Console.ReadLine());
                    Console.WriteLine("Numero de permiso de transito");
                    int numeroPermisoTransito = int.Parse(Console.ReadLine());
                    Console.WriteLine("Fecha de vigencia");
                    DateTime fechaVigencia = DateTime.Parse(Console.ReadLine());

                    Unidad.crearUnidad(codigoUnidad,numeroPlaca,numeroMotor,Modelo,Capacidad,Color,rutaAsignada,numeroPermisoTransito,fechaVigencia);
                    Unidad uni = new Unidad(codigoUnidad, numeroPlaca, numeroMotor, Modelo, Capacidad, Color, rutaAsignada, numeroPermisoTransito, fechaVigencia);
                    menuUnidades();

                    break;

                case 2:
                    Unidad.leerUnidad(unidades, buscarCodigoUnidad);
                    menuUnidades();
                    break;
                case 3:
                    Console.WriteLine("Digite el codigo de la Unidad");
                    int codigoUnidadM = int.Parse(Console.ReadLine());
                    Console.WriteLine("Numero de placa del Autobus");
                    int numeroPlacaM = int.Parse(Console.ReadLine());
                    Console.WriteLine("Numero del motor del Autobus");
                    int numeroMotorM = int.Parse(Console.ReadLine());
                    Console.WriteLine("Modelo del autobus");
                    int ModeloM = int.Parse(Console.ReadLine());

                    Console.WriteLine("Capacidad de pasajeros");
                    int CapacidadM = int.Parse(Console.ReadLine());
                    Console.WriteLine("Color del Autobus");
                    string ColorM = (Console.ReadLine());
                    Console.WriteLine("Ruta Asignada");
                    int rutaAsignadaM = int.Parse(Console.ReadLine());
                    Console.WriteLine("Numero de permiso de transito");
                    int numeroPermisoTransitoM = int.Parse(Console.ReadLine());
                    Console.WriteLine("Fecha de vigencia");
                    DateTime fechaVigenciaM = DateTime.Parse(Console.ReadLine());
                    Unidad.modificarUnidad(unidades,codigoUnidadM, numeroPlacaM, numeroMotorM, ModeloM, CapacidadM, ColorM,
                        rutaAsignadaM, numeroPermisoTransitoM, fechaVigenciaM);
                    menuUnidades();
                    break;
                case 4:
                    Unidad.eliminarUnidad(unidades,buscarCodigoUnidad);
                    menuUnidades();
                    break;
                default:
                    Console.WriteLine("Elige una opcion entre 1 y 4");
                    break;
            }
        }

        public static void menuHorarios()
        {
            Console.WriteLine("1. Opción 1: Crear Horarios");
            Console.WriteLine("2. Opción 2: Leer Horarios");
            Console.WriteLine("3. Opción 3: Modificar Horarios");
            Console.WriteLine("4. Opción 4: Eliminar Horarios");
            Console.WriteLine("5. Salir");
            Console.WriteLine("Elige una de las opciones");
            int opcion = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite el codigo de la terminal");
            int buscarCodigohorario = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    //Horario.crearHorario(id, idRuta, idTermi, dia, leave, arrive);
                   // Horario horario = new Horario(id, idRuta, idTermi, dia, leave, arrive);
                    menuHorarios();
                    break;
                case 2:
                    Horario.leerHorario(horarios, buscarCodigohorario);
                    menuHorarios();
                    break;
                case 3:
                    //Horario.modificarHorario(horarios,id,idRuta,idTermi,dia,leave,arrive);
                    menuHorarios();
                    break;
                case 4:
                    Horario.eliminarHorario(horarios, buscarCodigohorario);
                    menuHorarios();
                    break;
                default:
                    Console.WriteLine("Elige una opcion entre 1 y 4");
                    break;
            }

        }
        
    }
}

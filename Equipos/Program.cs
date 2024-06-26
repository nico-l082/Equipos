using Equipos.Models;
using Equipos.Models.Consultas;
using System;

class Program
{
    static void Main(string[] args)
    {
        int opcion = 0, opcion2 = 0;

        do
        {
            Console.WriteLine("\x1b[35m1 - Resolver partido");
            Console.WriteLine("2 - Base de datos");
            Console.WriteLine("\n\x1b[31m0 - Salir\x1B[37m\n");

            Int32.TryParse(Console.ReadLine(), out opcion);
            
            switch (opcion)
            {
                case 1:

                    //Creación de equipos
                    EquipoLocal equipoLocal = new EquipoLocal("Cabras", "Gimenez");
                    EquipoVisitante equipoVisitante = new EquipoVisitante("Leones", "Pepito");

                    //Agregación de los jugadores dentro de los equipos
                    //Equipo local
                    equipoLocal.AgregarJugador("Jugador 1");
                    equipoLocal.AgregarJugador("Jugador 2");
                    //Equipo visitante
                    equipoVisitante.AgregarJugador("Jugador 3");
                    equipoVisitante.AgregarJugador("Jugador 4");

                    string resultado = equipoLocal.SimularPartido(equipoLocal, equipoVisitante);
                    Console.WriteLine($"\n\x1b[32mResultado del partido: {resultado}\n");
                    break;

                case 2:

                    do
                    {
                        Console.WriteLine("\u001b[35m1 - Ver equipos");
                        Console.WriteLine("2 - Ver jugadores");
                        Console.WriteLine("3 - Ver entrenadores");
                        Console.WriteLine("\n\u001b[31m0 - Salir\x1B[37m\n");

                        Int32.TryParse(Console.ReadLine(), out opcion2);

                        switch (opcion2)
                        {
                            case 1:    
                                Console.WriteLine("\n");
                                List<string> equipos = EquipoBDD.getEquipo();
                                foreach (string equipo in equipos)
                                {
                                    Console.WriteLine($"\u001b[32m{equipo}");
                                }
                                Console.WriteLine("\n");
                                break;

                            case 2:

                                List<string> jugadores = EquipoBDD.getJugadores();
                                foreach (string j in jugadores)
                                {
                                    Console.WriteLine($"\u001b[32m{j}");                                    
                                }                                
                                break; 

                            case 3:

                                List<string> entrenadores = EquipoBDD.getEntrenador();
                                foreach (string entrenador in entrenadores)
                                {
                                    Console.WriteLine($"\u001b[32m{entrenador}");
                                }
                                break;

                            
                        }
                    } while ( opcion2 != 0 );
                    break;

                case 0:
                    Console.WriteLine("Saliendo del programa");
                    break;

                default:
                    Console.WriteLine("\u001b[31mintente nuevamente.\n");
                    break;
            }      
            
        }while( opcion != 0 );
    } 
}

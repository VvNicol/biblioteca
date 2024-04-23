using GestionBilioteca.Dtos;
using GestionBilioteca.Servicios;

namespace GestionBilioteca.Controlador
{
    internal class Program
    {


        static List<BibliotecaDto> listaBibliotecas = new List<BibliotecaDto>();
        static List<ClienteDtos> listaClientes = new List<ClienteDtos>();
        static List<LibroDtos> listaLibro = new List<LibroDtos>();
        static List<PrestamoDtos> listaPrestamo = new List<PrestamoDtos>();
        static string fichero = "listaBubliotecas.txt";
        static void Main(string[] args)
        {
            MenuInterface mi = new MenuImplementacion();
            OperativaInterface oi = new OperativaImplementacion();

            int opcion;
            bool esCerrado = false;

         

            try
            {
                do
                {
                    opcion = mi.MenuBiblioteca();
                    switch (opcion)
                    {
                        case 0:
                            Console.WriteLine("¿Desea guardar los cambios? (s/n)");
                            char sn = Convert.ToChar(Console.ReadLine());

                            if (sn == 's')
                            {
                                // Obtener el contenido que deseas guardar en el archivo
                                string contenidoAGuardar = listaBibliotecas.ToString(); // Por ejemplo, tu método ToString() de los objetos

                                // Guardar los cambios en el archivo
                                if (!File.Exists(fichero))
                                {
                                    // Si el archivo no existe, crearlo y escribir el contenido
                                    File.WriteAllText(fichero, contenidoAGuardar);
                                    Console.WriteLine("Archivo creado y cambios guardados correctamente.");
                                }
                                else
                                {
                                    // Si el archivo ya existe, agregar o sobrescribir el contenido según sea necesario
                                    // Aquí puedes usar File.WriteAllText() o File.AppendAllText() dependiendo de tu necesidad
                                    // Por ejemplo, File.WriteAllText(fichero, contenidoAGuardar); para sobrescribir completamente el archivo
                                    File.AppendAllText(fichero, contenidoAGuardar); // Para agregar contenido al final del archivo
                                    Console.WriteLine("Cambios guardados correctamente en el archivo.");
                                }
                            }
                            else
                            {
                                // No guardar los cambios si el usuario responde "n"
                                Console.WriteLine("Cambios no guardados.");
                            }

                            esCerrado = true;
                            break;
                        case 1:
                            oi.AltaBiblioteca(listaBibliotecas);
                            break;
                        case 2:
                            oi.AltaCliente(listaClientes, listaBibliotecas);
                            break;
                        case 3:
                            oi.AltaLibro(listaLibro, listaBibliotecas);
                            break;
                        case 4:
                            //oi.AltaPrestamos();
                            break;
                        default: Console.WriteLine("La opcion no existe");
                            break;

                    }

                } while (!esCerrado);
            }
            catch (IOException e)
            {
                Console.WriteLine("No se pudo leer/escribir: " + e.Message);
            }
        }
    }
}

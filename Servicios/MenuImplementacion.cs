namespace GestionBilioteca.Servicios
{
    internal class MenuImplementacion : MenuInterface
    {
        public int MenuBiblioteca()
        {
            Console.WriteLine("-----------");
            Console.WriteLine("Menu principal gestion de bibliotecas");
            Console.WriteLine("0.Cerrar menu");
            Console.WriteLine("1.Alta biblioteca");
            Console.WriteLine("2.Alta cliente");
            Console.WriteLine("3.Alta libro");
            Console.WriteLine("4.Alta prestamo de libro");
            int opcionEscogida = Convert.ToInt32(Console.ReadLine());
            return opcionEscogida;
        }
    }
}
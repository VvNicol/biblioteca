using GestionBilioteca.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBilioteca.Utilidades
{
    internal class Utils
    {
        public static long calcularId(List<BibliotecaDto> listaB)
        {
            long idCalcular;
            int tamanioLista = listaB.Count;

            if (tamanioLista > 0)
            {
                idCalcular = listaB.Count() + 1;
            }else
            {
                idCalcular = 1;
            }
            return idCalcular;
        }

        public static long calcularIdCliente(List<ClienteDtos> listaC)
        {
            long idCalcular;
            int tamanioLista = listaC.Count;

            if (tamanioLista > 0)
            {
                idCalcular = listaC.Count() + 1;
            }
            else
            {
                idCalcular = 1;
            }
            return idCalcular;
        }
        public static long calcularIdLibro(List<LibroDtos> listaL)
        {
            long idCalcular;
            int tamanioLista = listaL.Count;

            if (tamanioLista > 0)
            {
                idCalcular = listaL.Count() + 1;
            }
            else
            {
                idCalcular = 1;
            }
            return idCalcular;
        }

        public static void mostrarBibliotecas(List<BibliotecaDto> listaBiblioteca)
        {            
            Console.WriteLine("Bibliotecas: ");
            Console.WriteLine("------------");

            foreach (BibliotecaDto bibli in listaBiblioteca)
            {
                Console.WriteLine(bibli.ToString());
            }
        }

        public static void mostrarClientes(List<ClienteDtos> listaClientes)
        {
            Console.WriteLine("Clientes: ");
            Console.WriteLine("------------");

            foreach (ClienteDtos cliente in listaClientes)
            {
                Console.WriteLine(cliente.ToString());
            }
        }

    }
}

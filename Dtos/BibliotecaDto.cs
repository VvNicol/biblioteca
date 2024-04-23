using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBilioteca.Dtos
{
    internal class BibliotecaDto
    {
        long id;
        string nombreBiblioteca = "aaaaa";
        string direccionBiliblioteca = "aaaaa";

        override
        public string ToString()
        {
            string infoString =
                $"id: {id} \n" +
                $"Biblioteca: {nombreBiblioteca}\n" +
                $"------------------------------";

            return infoString;
        }
        public BibliotecaDto()
        {
        }

        public BibliotecaDto(long id, string nombreBiblioteca, string direccionBiliblioteca)
        {
            this.id = id;
            this.nombreBiblioteca = nombreBiblioteca;
            this.direccionBiliblioteca = direccionBiliblioteca;
        }

        public long Id { get => id; set => id = value; }
        public string NombreBiblioteca { get => nombreBiblioteca; set => nombreBiblioteca = value; }
        public string DireccionBiliblioteca { get => direccionBiliblioteca; set => direccionBiliblioteca = value; }
    }
}

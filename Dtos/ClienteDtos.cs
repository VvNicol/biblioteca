using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GestionBilioteca.Dtos
{
    internal class ClienteDtos
    {
        long id;
        long idBiblioteca = 11111;
        string nombreCompletoCliente = "aaaaa";
        string nombreCliente = "aaaaa";
        string apellido1Cliente = "aaaaa";
        string apellido2Cliente = "aaaaa";
        string apellidosCliente = "aaaaa";
        DateTime fchaNacimientoCliente = new DateTime(9999,12,31);
        int dniNumCliente = 11111;
        char letraCliente = 'a';
        string dniCompletoCliente = "aaaaa";
        string correoCliente = "aaaaa";
        DateTime fchaInicioSuspensión = new DateTime(9999, 12, 31);
        DateTime fechaFinSuspensión = new DateTime(9999, 12, 31);


        public ClienteDtos()
        {
        }

        public ClienteDtos(long id, long idBiblioteca,string nombreCompletoCliente, 
            DateTime fchaNacimientoCliente, int dniNumCliente, char letraCliente, string correoCliente)
        {
            this.id = id;
            this.id = idBiblioteca;
            string[] nombreCompCl = nombreCompletoCliente.Split(' ');
            this.NombreCliente = nombreCompCl[0];
            this.Apellido1Cliente = nombreCompCl[1];
            this.Apellido2Cliente = nombreCompCl[2];
            this.apellidosCliente = apellido1Cliente + apellido2Cliente;
            this.fchaNacimientoCliente = fchaNacimientoCliente;
            this.dniNumCliente = dniNumCliente;
            this.letraCliente = letraCliente;
            this.dniCompletoCliente = dniNumCliente.ToString() + letraCliente;
            this.correoCliente = correoCliente;
        }

        public long Id { get => id; set => id = value; }
        public string NombreCliente { get => nombreCompletoCliente; set => nombreCompletoCliente = value; }
        public string ApellidosCliente { get => apellidosCliente; set => apellidosCliente = value; }
        public DateTime FchaNacimientoCliente { get => fchaNacimientoCliente; set => fchaNacimientoCliente = value; }
        public string CorreoCliente { get => correoCliente; set => correoCliente = value; }
        public DateTime FchaInicioSuspensión { get => fchaInicioSuspensión; set => fchaInicioSuspensión = value; }
        public DateTime FechaFinSuspensión { get => fechaFinSuspensión; set => fechaFinSuspensión = value; }
        public long IdBiblioteca { get => idBiblioteca; set => idBiblioteca = value; }
        public string NombreCliente1 { get => nombreCliente; set => nombreCliente = value; }
        public string Apellido1Cliente { get => apellido1Cliente; set => apellido1Cliente = value; }
        public string Apellido2Cliente { get => apellido2Cliente; set => apellido2Cliente = value; }
        public int DniNumCliente { get => dniNumCliente; set => dniNumCliente = value; }
        public char LetraCliente { get => letraCliente; set => letraCliente = value; }
        public string DniCompletoCliente { get => dniCompletoCliente; set => dniCompletoCliente = value; }
    }
}

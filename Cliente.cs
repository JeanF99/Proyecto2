using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    namespace Proyecto.Personas
    {
        public class Cliente : Persona
        {
            private int idCliente;
            private int presupuesto;
            private List<Cliente> clientes = new List<Cliente>();
            public int IdCliente { get => idCliente; set => idCliente = value; }
            public int Presupuesto { get => presupuesto; set => presupuesto = value; }
            public List<Cliente> Clientes { get => clientes; set => clientes = value; }

            public Cliente()
            {

            }
            public Cliente(int idCliente, int presupuesto, int rut, int verificador, string nombre,
                string apellidoPaterno,string apellidoMaterno, int telefono, DateTime fechaNacimiento ) : base (rut, verificador, nombre ,apellidoPaterno, apellidoMaterno, telefono, fechaNacimiento)
            {
                this.idCliente = idCliente;
                this.presupuesto = presupuesto;
                Clientes = new List<Cliente>();
            }
            public void MostrarDetalles(int IdCliente)
            {
                var cliente = Clientes.FirstOrDefault(e => e.IdCliente == IdCliente);
                if (cliente != null)
                {
                    Console.WriteLine($"Nombre: {cliente.Nombre}. Apellido: {cliente.ApellidoPaterno}. Rut: {cliente.Rut} - {cliente.Verificador}. Presupuesto: {cliente.presupuesto}");
                }
                else
                {
                    Console.WriteLine("Cliente no encontrado.");
                }
            }
        }
    }

}

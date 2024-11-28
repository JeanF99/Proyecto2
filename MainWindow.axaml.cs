using Avalonia.Controls;
using Avalonia.Interactivity;
using System;
using Proyecto.Proyecto.Personas;

namespace Proyecto
{
    public partial class MainWindow : Window
    {
        private Cliente miCliente = new Cliente();
        private Trabajador miTrabajador = new Trabajador();
        
        public MainWindow()
        {
            InitializeComponent();
        }
        public void Ingresar_Click(object sender, RoutedEventArgs args)
        {
            int aux = 0;
            miCliente.IdCliente = aux + 1;
            miCliente.Presupuesto = Convert.ToInt32(this.tbPresupuesto.Text);
            miCliente.Rut = Convert.ToInt32(this.tbRut.Text);
            miCliente.Verificador = Convert.ToInt32(this.tbVerificador.Text);
            miCliente.Nombre = this.tbNombre.Text;
            miCliente.ApellidoPaterno = this.tbApellidoPaterno.Text;
            miCliente.ApellidoMaterno = this.tbApellidoMaterno.Text;
            miCliente.Telefono = Convert.ToInt32(this.tbTelefono.Text);
            string[] array = fechaNacimiento.Text.Split("-");
            miCliente.FechaNacimiento = new DateTime
            (
                int.Parse(array[2]),
                int.Parse(array[1]),
                int.Parse(array[0])
            );
            
        }
        public void Eliminar_Click(object sender, RoutedEventArgs args)
        { 
            this.tbkNombre.Text = miCliente.Nombre + " Eliminado";
            this.tbkPresupuesto.IsVisible = false;
            this.tbkRut.IsVisible = false;
            this.tbkVerificador.IsVisible = false;
            this.tbkNombre.IsVisible = true;
            this.tbkApellidoPaterno.IsVisible = false;
            this.tbkApellidoMaterno.IsVisible = false;
            this.tbkTelefono.IsVisible = false;
            this.tbkNacimiento.IsVisible = false;

        }
        public void Mostrar_Click(object sender, RoutedEventArgs args)
        {
            this.tbkPresupuesto.Text = "Presupuesto: " + miCliente.Presupuesto;
            this.tbkRut.Text = "Rut: " + miCliente.Rut + "-" + miCliente.Verificador;
            this.tbkNombre.Text = "Nombre: " + miCliente.Nombre + " " + miCliente.ApellidoPaterno + " " + miCliente.ApellidoMaterno;
            this.tbkTelefono.Text = "Telefono: " + miCliente.Telefono;
            this.tbkNacimiento.Text = "Fecha de Nacimiento: " + " " + miCliente.FechaNacimiento.Day.ToString() + "-" + miCliente.FechaNacimiento.Month.ToString() + "-" + miCliente.FechaNacimiento.Year.ToString();
            this.tbkPresupuesto.IsVisible = true;
            this.tbkRut.IsVisible = true;
            this.tbkVerificador.IsVisible = true;
            this.tbkNombre.IsVisible = true;
            this.tbkApellidoPaterno.IsVisible = true;
            this.tbkApellidoMaterno.IsVisible = true;
            this.tbkTelefono.IsVisible = true;
            this.tbkNacimiento.IsVisible = true;
        }
        public void CheckBox_Checked(object sender, RoutedEventArgs e )
        {
            this.tbkNotificacion.Text = "CheckBox seleccionado! ";
            this.tbkNotificacion.IsVisible = true;
            this.tbkNotificacionn.IsVisible = false;
        }
        public void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            this.tbkNotificacionn.Text = "CheckBox deseleccionado! ";
            this.tbkNotificacion.IsVisible = false;
            this.tbkNotificacionn.IsVisible = true;
        }
        public void Ingresart_Click(object sender, RoutedEventArgs args)
        {
            int aux = 0;
            miTrabajador.IdTrabajador = aux + 1;
            miTrabajador.Rut = Convert.ToInt32(this.tbRutt.Text);
            miTrabajador.Verificador = Convert.ToInt32(this.tbVerificadort.Text);
            miTrabajador.Nombre = this.tbNombret.Text;
            miTrabajador.ApellidoPaterno = this.tbApellidoPaternot.Text;
            miTrabajador.ApellidoMaterno = this.tbApellidoMaternot.Text;
            miTrabajador.Telefono = Convert.ToInt32(this.tbTelefonot.Text);
            string[] array = fechaNacimientot.Text.Split("-");
            miTrabajador.FechaNacimiento = new DateTime
            (
                int.Parse(array[2]),
                int.Parse(array[1]),
                int.Parse(array[0])
            );

            miTrabajador.Afp = this.tbAfp.Text;
            miTrabajador.SueldoBruto = Convert.ToDouble(this.tbSB.Text);
            miTrabajador.Colacion = Convert.ToDouble(this.tbColacion.Text);
            miTrabajador.Pasaje = Convert.ToDouble(this.tbPasaje.Text);
            miTrabajador.DescuentoAfp = Convert.ToDouble(this.tbDescuentoAfp.Text);
            miTrabajador.Salud = Convert.ToDouble(this.tbDescuentoSalud.Text);
        }
        public void Eliminart_Click(object sender, RoutedEventArgs args)
        {
                this.tbkNombre.Text = miTrabajador.Nombre + " Eliminado";
                this.tbkRut.IsVisible = false;
                this.tbkVerificador.IsVisible = false;
                this.tbkNombre.IsVisible = true;
                this.tbkApellidoPaterno.IsVisible = false;
                this.tbkApellidoMaterno.IsVisible = false;
                this.tbkTelefono.IsVisible = false;
                this.tbkNacimiento.IsVisible = false;
        }
        public void Mostrart_Click(object sender, RoutedEventArgs args)
        { 
            this.tbkRutt.Text = "Rut: " + miTrabajador.Rut + "-" + miTrabajador.Verificador;
            this.tbkNombret.Text = "Nombre: " + miTrabajador.Nombre + " " + miTrabajador.ApellidoPaterno + " " + miTrabajador.ApellidoMaterno;
            this.tbkTelefonot.Text = "Telefono: " + miTrabajador.Telefono;
            this.tbkNacimientot.Text = "Fecha de Nacimiento: " + " " + miTrabajador.FechaNacimiento.Day.ToString() + "-" + miTrabajador.FechaNacimiento.Month.ToString() + "-" + miTrabajador.FechaNacimiento.Year.ToString();
            this.tbkRutt.IsVisible = true;
            this.tbkVerificadort.IsVisible = true;
            this.tbkNombret.IsVisible = true;
            this.tbkApellidoPaternot.IsVisible = true;
            this.tbkApellidoMaternot.IsVisible = true;
            this.tbkTelefonot.IsVisible = true;
            this.tbkNacimientot.IsVisible = true;
        }

    }
}

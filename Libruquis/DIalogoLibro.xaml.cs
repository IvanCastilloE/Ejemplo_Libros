using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Libruquis
{
    /// <summary>
    /// Lógica de interacción para DIalogoLibro.xaml
    /// </summary>
    public partial class DIalogoLibro : Window
    {
        private LogicaNegocio logicaNegocio; //Acceso privado a la variable logicaNegocio de la clase logica
        public Libro libro; //Variable publica de tipo Libro para acceder a la clase libro
        private int posicion;
        private Boolean modificar;

        public DIalogoLibro(LogicaNegocio logicaNegocio) //Pasar como parametro de la funcion logicaNegocio
        {
            InitializeComponent();
            this.logicaNegocio = logicaNegocio; //Creo la instancia de la clase
            libro = new Libro(); // Crear un objeto de tipo libro
            this.DataContext = libro; //Defino el contexto de los datos - de donde vienen las propiedades
            modificar = false;
        }
        public DIalogoLibro(LogicaNegocio logicaNegocio, Libro libroModificar, int posicion) //
        {
            InitializeComponent();
            this.logicaNegocio = logicaNegocio; 
            this.libro = libroModificar;
            this.posicion = posicion;
            this.DataContext = libro;
            modificar = true;
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnNombre_Click(object sender, RoutedEventArgs e)
        {
            if (modificar)
                logicaNegocio.ModificarLibro(libro, posicion);
            else
                logicaNegocio.agregarLibro(libro);
            this.Close();
        }
    }
}

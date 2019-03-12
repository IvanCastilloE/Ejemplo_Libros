using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Libruquis
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private LogicaNegocio logicaNegocio;
        public MainWindow()
        {
            InitializeComponent();
            logicaNegocio = new LogicaNegocio();
            this.DataContext = this;
            GridLibros.DataContext = logicaNegocio;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NuevoItem_Click(object sender, RoutedEventArgs e)
        {
            DIalogoLibro dialogoLibro = new DIalogoLibro(logicaNegocio); //Crear instancia de elementos
            dialogoLibro.Show();
        }

        private void SalirItem_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
        }
    }
}

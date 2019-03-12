using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libruquis
{
    public partial class LogicaNegocio
    {
        public ObservableCollection<Libro> ListaLibros { get; set; }

        public LogicaNegocio()
        {
            ListaLibros = new ObservableCollection<Libro>();
            ListaLibros.Add(new Libro("Titulo", "Autor", DateTime.Now)); //Verifica que el binding este hecho de manera correcta

        }
        public void agregarLibro(Libro libro)
        {
            ListaLibros.Add(libro);
        }
    }
}

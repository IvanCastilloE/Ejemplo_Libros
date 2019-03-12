using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libruquis
{
    public class Libro: INotifyPropertyChanged
    {

        private String titulo;
        public String Titulo
        {
            get { return titulo;  }
            set
            {
                titulo = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Titulo"));
            }
        }
        private String autor;
        public String Autor
        {
            get { return autor; }
            set
            {
                autor = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Autor"));
            }
        }
        private DateTime fechaEntrada;
        public DateTime FechaEntrada
        {
            get { return fechaEntrada; }
            set
            {
                fechaEntrada = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("FechaEntrada"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public Libro()//Crear un constructor vacio que modifiqué la fecha
        {
            this.fechaEntrada = DateTime.Now;
        }

        public Libro(string titulo, string autor, DateTime fechaEntrada)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.fechaEntrada = fechaEntrada;
        }
    }
}

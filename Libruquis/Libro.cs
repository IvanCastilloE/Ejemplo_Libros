using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libruquis
{
    class Libro: INotifyPropertyChanged
    {
        private string titulo;
        public string Titulo
        {
            get { return titulo;  }
            set
            {
                this.titulo = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Titulo"));
            }
        }
        private string autor;
        public string Autor
        {
            get { return autor; }
            set
            {
                this.autor = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Autor"));
            }
        }
        private string fechaEntrada;
        public string FechaEntrada
        {
            get { return fechaEntrada; }
            set
            {
                this.fechaEntrada = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("FechaEntrada"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}

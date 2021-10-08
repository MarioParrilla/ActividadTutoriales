using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_UT1_Actividad1._1
{
    public class Tema
    {
        private int id_tema;
        private String nombre, imagen;

        public Tema() { }
        public Tema(int id_tema, string nombre, string imagen)
        {
            this.id_tema = id_tema;
            this.nombre = nombre;
            this.imagen = imagen;
        }

        public override String ToString()
        {
            return nombre;
        }

        public int Id_tema { get => id_tema; set => id_tema = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Imagen { get => imagen; set => imagen = value; }
    }
}

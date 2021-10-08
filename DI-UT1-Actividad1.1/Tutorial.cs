using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_UT1_Actividad1._1
{
    public class Tutorial
    {
        private int id_tutorial, id_tema;
        private String titulo, categoria, fecha, imagen, video;

        public Tutorial() { }
        public Tutorial(int id_tutorial, int id_tema, string titulo, string categoria, string fecha, string imagen, string video)
        {
            this.id_tutorial = id_tutorial;
            this.id_tema = id_tema;
            this.titulo = titulo;
            this.categoria = categoria;
            this.fecha = fecha;
            this.imagen = imagen;
            this.video = video;
        }

        public override String ToString()
        {
            return titulo;
        }

        public int Id_tutorial { get => id_tutorial; set => id_tutorial = value; }
        public int Id_tema { get => id_tema; set => id_tema = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Imagen { get => imagen; set => imagen = value; }
        public string Video { get => video; set => video = value; }
    }
}

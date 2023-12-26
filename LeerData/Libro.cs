using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace LeerData
{
    public class Libro
    {
        public int LibroId { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public System.DateTime FechaPublicacion { get; set; }
        public Precio PrecioPromocion { get; set; }
        public ICollection<Comentario> ComentarioLista { get; set; }
        public ICollection<LibroAutor> AutorLink { get; set; }

    }
}
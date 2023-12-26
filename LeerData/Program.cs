using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.Linq;

namespace LeerData
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new AppVentaLibroContext())
            {
                // var libros = db.Libro.Include(x => x.AutorLink).ThenInclude(xi => xi.Autor);
                // foreach (var libro in libros)
                // {
                //     Console.WriteLine(libro.Titulo);
                //     foreach (var autLink in libro.AutorLink)
                //     {
                //         Console.WriteLine(" ---- " + autLink.Autor.Nombre + " " + autLink.Autor.Apellidos);
                //     }
                // }

                // var nuevoAutor1 = new Autor
                // {
                //     Nombre = "Lorenzo",
                //     Apellidos = "Lopez",
                //     Grado = "Master"
                // };
                // db.Add(nuevoAutor1);
                // var nuevoAutor2 = new Autor
                // {
                //     Nombre = "Pedro",
                //     Apellidos = "Paredes",
                //     Grado = "Master"
                // };
                // db.Add(nuevoAutor2);
                // var nuevoAutor3 = new Autor
                // {
                //     Nombre = "Paola",
                //     Apellidos = "Martinez",
                //     Grado = "Master"
                // };
                // db.Add(nuevoAutor3);
                // var estadoTransaccion = db.SaveChanges();
                // Console.WriteLine("Estado de transaccion ===> " + estadoTransaccion);

                // var autor = db.Autor.Single(x => x.Nombre == "Paola");
                // if (autor != null)
                // {
                //     autor.Apellidos = "Mendez";
                //     autor.Grado = "Biologo";
                //     db.SaveChanges();
                //     var estadoTransaccion = db.SaveChanges();
                //     Console.WriteLine("Estado de transaccion ===> " + estadoTransaccion);
                // }

                var autor = db.Autor.Single(x => x.AutorId == 6);
                if (autor != null)
                {
                    db.Remove(autor);
                    var estadoTransaccion = db.SaveChanges();
                    Console.WriteLine("Estado de transaccion ===> " + estadoTransaccion);
                }
            }
        }
    }
}

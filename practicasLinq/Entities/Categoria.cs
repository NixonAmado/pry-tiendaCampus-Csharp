using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tiendaCampus.Entities;

    public class Categoria
    {
        public int Id {get; set;}
        public string Descripcion {get; set;}
 
    public void RegistrarCategoria()
    {
        Console.Clear();
        Categoria nuevaCategoria = new();
        Console.WriteLine("**********************************");
        Console.WriteLine("{0, -20}", "REGISTRAR CATEGORIAS");
        Console.WriteLine("**********************************");
        
        Console.WriteLine("\nIngresar id de la categoria:");
        nuevaCategoria.Id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingresar descripcion de la categoria:");
        nuevaCategoria.Descripcion = Console.ReadLine();
        Env.TiendaCampus1.Categorias.Add(nuevaCategoria);
       
    }

    public  IEnumerable<Categoria> ListarCategorias()
    {
            return from cat in Env.TiendaCampus1.Categorias
                select cat;

            // int anchoColumna = 20;
            // int anchoTabla = 10 + (2 * anchoColumna);
            // Console.WriteLine("".PadRight(anchoTabla,'-'));
            // Console.WriteLine("{0,10}","LISTADO DE CATEGORIAS");
            // Console.WriteLine("".PadRight(anchoTabla,'-'));
            // Console.WriteLine("{0,-20}","{1,10}","| id categoria |","| nombre categoria ");
            // foreach (Categoria categoria in categorias)
            // {
            //     Console.WriteLine("{0,-20}","{1,10}",$"{categoria.Id}", $"{categoria.Descripcion}");
            // }
            // Console.ReadKey();

    }
}

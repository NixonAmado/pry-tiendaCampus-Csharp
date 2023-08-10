using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tiendaCampus;

    public class Categoria
    {
        public int Id {get; set;}
        public string Descripcion {get; set;}

        public Categoria(){}
        public Categoria(int id, string descripcion)
        {
            this.Id = id;
            this.Descripcion = descripcion;
        }

        
    public void RegistrarCategoria(List <Categoria> categorias){
                    Console.Clear();
            Console.WriteLine("**********************************");
            Console.WriteLine("{0, -20}", "REGISTRAR CATEGORIAS");
            Console.WriteLine("**********************************");
            
            Console.WriteLine("\nIngresar id de la categoria:");
            int idCategoria = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresar descripcion de la categoria:");
            string DesCategoria = Console.ReadLine();
            
            Categoria nuevaCategoria = new(idCategoria,DesCategoria);
            categorias.Add(nuevaCategoria);
        }

    // public void ListarCategorias(List <Categoria> categorias)
    // {
    //     Console.Clear();
    //     if (categorias.Count = !0 )
    //     {   
    //         int anchoColumna = 20;
    //         int anchoTabla = 10 + (2 * anchoColumna);
    //         Console.WriteLine("".PadRight(anchoTabla,"-"));
    //         Console.WriteLine("{0,10}","LISTADO DE CATEGORIAS");
    //         Console.WriteLine("".PadRight(anchoTabla,"-"));
    //         Console.WriteLine("{0,20}","| id categoria |","| nombre categoria ");
    //         foreach (Categoria categoria in categorias)
    //         {
    //             Console.WriteLine("{0,20}",$"{categoria.Id}", categoria.Descripcion);
    //         }
    //     return true;
    //     }
    //     else{ return false;}
    // }
}

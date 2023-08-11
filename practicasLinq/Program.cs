using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;
using tiendaCampus.Entities;
using tiendaCampus;
		
    internal class Program
    {
    	public static void Main()
    	{


            int opMenuPrincipal = 0;
            if(!Env.ValidarFile(Env.FileName))
            {
                File.WriteAllText(Env.FileName, "");
            }
            else
            {
                Env.LoadData(Env.FileName);                
            }
            
            Env.ImprimirData("Categorias", Env.TiendaCampus1.Categorias);

            do
            {
                Console.Clear();
                Console.WriteLine("**********************************");
                Console.WriteLine("{0, 25}", "SUPER TIENDA AB3");
                Console.WriteLine("**********************************");
                Console.WriteLine("1.Registrar producto");
                Console.WriteLine("2.Registrar categoria");
                Console.WriteLine("3.Listar categorias");
                Console.WriteLine("4.Listar productos");
                Console.WriteLine("5.Costo total del inventario");
                Console.WriteLine("6.Salir");
                Console.WriteLine("**********************************");
                Console.Write("Elija una opcion: ");

                if(!int.TryParse(Console.ReadLine(), out opMenuPrincipal))
                {
                    Console.WriteLine("Por favor, ingresa un valor valido");
                    opMenuPrincipal = 0;
                }

                switch (opMenuPrincipal)
                {
                    case 0:
                        continue;
                    case 1:

                        Producto producto = new();
                        // Guid idG = Guid.NewGuid();
                        // producto.CodProducto;
                        producto.RegistrarProducto();
                        Env.DumpToJson();
                        break;

                    case 2:
                        Categoria categoria = new();
                        categoria.RegistrarCategoria();
                        Env.DumpToJson();
                        break;

                    case 3:
                        Categoria listarCategoria = new();
                        var IterableCategorias = listarCategoria.ListarCategorias(); 

                        if(IterableCategorias.Count() != 0)
                        {
                            Console.WriteLine("No existen categorias, asegurate de haber registrado por lo menos una");
                            Console.ReadKey();
                        }
                        else
                        {
                            Env.ImprimirData("CATEGORIAS", IterableCategorias);
                        }
                        break;

                    case 4:
                        Producto listarProducto = new();
                        var IterableProductos = listarProducto.listarProductos(); 

                        if(IterableProductos.Count() != 0)
                        {
                            Console.WriteLine("No existen productos, asegurate de haber registrado por lo menos una");
                            Console.ReadKey();
                        }
                        else
                        {
                            Env.ImprimirData("PRODUCTOS", IterableProductos);
                        }

                        break;
                    default:
                    break;
                }


            } while (opMenuPrincipal != 6);
    
    	}
    
    }

    // public class Student{

    // 	public int StudentID { get; set; }
    // 	public string StudentName { get; set; }
// 	public int Age { get; set; }
// 	public int StandardID { get; set; }
// }

// public class Standard{

// 	public int StandardID { get; set; }
// 	public string StandardName { get; set; }
// }
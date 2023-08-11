using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json; // Para trabajar con JSON


namespace tiendaCampus;

    public class Producto
    {
        public int CodProducto {get; set;}
        public string Nombre {get; set;}
        public int Stock {get; set;}
        public int StockMinimo {get; set;}
        public int StockMaximo {get; set;}
        public int PrecioVenta {get; set;}
        public int PrecioCompra {get; set;}
        public int IdCategoria {get; set;}

    public Producto()
    {
        if (!File.Exists(Env.FileName))
        {
            File.WriteAllText(Env.FileName,"");
        }
    }

    public Producto(int codProducto, string nombre, int stock, int stockMinimo, int stockMaximo, int precioVenta, int precioCompra, int idCategoria)
    {

        this.CodProducto = codProducto;
        this.Nombre = nombre;
        this.Stock = stock;
        this.StockMinimo = stockMinimo;
        this.StockMaximo = stockMaximo;
        this.PrecioVenta = precioVenta;
        this.PrecioCompra = precioCompra;
        this.IdCategoria = idCategoria;

    }

        public void RegistrarProducto(List <Producto> productos)
        {
            Console.Clear();
            Console.WriteLine("**********************************");
            Console.WriteLine("{0, -20}", "REGISTRAR PRODUCTO");
            Console.WriteLine("**********************************");
            
            Console.WriteLine("\nIngresar codigo del producto:");
            int codProducto = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresar nombre del producto:");
            
            string nombreProducto = Console.ReadLine();
            Console.WriteLine("Ingresar stock del producto:");
            int stockProducto = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresar stock minimo del producto:");
            int stockMinProducto = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresar stock maximo del producto:");
            int stockMaxProducto = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresar precio de venta del producto:");
            int precioVentaProducto = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresar precio de compra del producto:");
            int precioCompraProducto = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresar id de la categoria a la que pertenece el producto:");
            int idCategoriaProducto = Convert.ToInt32(Console.ReadLine());

            Producto nuevoProducto = new Producto(codProducto,nombreProducto, stockProducto, stockMinProducto, stockMaxProducto, precioVentaProducto, precioCompraProducto, idCategoriaProducto);

            Env.Productos.Add (nuevoProducto);

            string json = JsonConvert.SerializeObject(Env.Productos, Formatting.Indented);
            Console.WriteLine("Se ha añadido con exito");
            Console.ReadKey();

        }
    }

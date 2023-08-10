using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using practicasLinq.Clases;

namespace tiendaCampus;
    public class Env
    {
        private static string fileName = "productos.json";
        private static List<Producto> productos = new List<Producto>();
        //private static List<Categoria> categorias = new List<Categoria>();       

        public static string FileName { get => fileName; set => fileName = value; }
        public static List<Producto> Productos { get => productos; set => productos = value; }
    }

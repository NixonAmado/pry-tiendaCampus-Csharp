using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq;
namespace tiendaCampus;
    public static class Env
    {
        private static string fileName = "productos.json";
        private static List<Producto> productos = new List<Producto>();
        private static List<Categoria> categorias = new List<Categoria>();       

        public static string FileName { get => fileName; set => fileName = value; }
        public static List<Producto> Productos { get => productos; set => productos = value; }
        public static List<Categoria> Categorias { get => categorias; set => Categorias = value; }
    

    public static void LoadData<T> (string nombreArchivo, List<T> list)
    {
        List<T> lista = new List<T>();
        using(StreamReader reader = new StreamReader(nombreArchivo))
        {
            string json = reader.ReadToEnd();
            lista = System.Text.Json.JsonSerializer.Deserialize<List<T>>(json, new System.Text.Json.JsonSerializerOptions()
            {PropertyNameCaseInsensitive = true}) ?? new List<T>();
        }
        if (lista)
        {
            
        }
    }
}

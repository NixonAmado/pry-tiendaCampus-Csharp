using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq;
using Newtonsoft.Json; // Para trabajar con JSON
using tiendaCampus.Entities;


namespace tiendaCampus;
    public static class Env
    {
        private static string fileName = "tiendaCampus.json";
        private static TiendaCampus tiendaCampus = new();

        public static string FileName { get => fileName; set => fileName = value; }

        public static TiendaCampus TiendaCampus1 {get => tiendaCampus; set => tiendaCampus = value; }
        //public static List<Producto> Productos { get => productos; set => productos = value; }
        //public static List<Categoria> Categorias { get => categorias; set => Categorias = value; }
    

    public static void LoadData (string nombreArchivo)
    {
        using(StreamReader reader = new StreamReader(nombreArchivo))
        {
            string json = reader.ReadToEnd();
            if(string.IsNullOrWhiteSpace(json))
            {
                new TiendaCampus();
                return;
            }
            Env.TiendaCampus1 = System.Text.Json.JsonSerializer.Deserialize<TiendaCampus>(json, new System.Text.Json.JsonSerializerOptions()
            {PropertyNameCaseInsensitive = true}) ?? new TiendaCampus();
        }
    }

    public static bool ValidarFile(string fileName)
    {
        if(!File.Exists(fileName))
        {
            return false;
        }
        return true;
    }

    public static void ImprimirData<T>(string titulo, IEnumerable<T> lista)
    {   
        Console.WriteLine("*******************************");
        Console.WriteLine("{0,-30}", titulo);
        Console.WriteLine("*******************************");

        foreach (var elemento in lista)
        {
            Type tipoClase = elemento.GetType();
            var propiedades = tipoClase.GetProperties();
            foreach (var propiedad in propiedades)
            {
                Console.Write($"  {propiedad.Name}: {propiedad.GetValue(elemento)}");   
            }     
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        Console.ReadKey();

        /* typo = objeto.GEtType() 
            propiedades = typo.GetProperties();
            iterar po cada propiedad
        */
    }

    public static void DumpToJson(){
        string json = JsonConvert.SerializeObject(Env.TiendaCampus1, Formatting.Indented);
        File.WriteAllText(Env.FileName,json);
    }
}

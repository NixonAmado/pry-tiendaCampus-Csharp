using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json; // Para trabajar con JSON


namespace tiendaCampus.Entities;

    public class TiendaCampus
    {
        private List<Producto> productos= new List<Producto>();
        private List<Categoria> categorias = new List<Categoria>();


        public List<Producto> Productos
        {
            get { return productos; }
            set { productos = value; }
        }
                
        public List<Categoria> Categorias
        {
            get { return categorias; }
            set { categorias = value; }
        }
                
        
        public TiendaCampus(){}
    }

﻿using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulo
    {
        
        public int IDArticulo { get; set; } 
        public string CodigoArticulo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string UrlImagen { get; set; }
        public Marca Marca { get; set; }
        public Categoria Categoria{ get; set; }
        public float Precio { get; set; }


        public Articulo()
        {
            UrlImagen = "https://production.listennotes.com/podcasts/el-podcast-m%C3%A1s-random-del-mundo-L6I3Ep9lRTB-xB_PCg0EDch.1400x1400.jpg";
        }
    }

}

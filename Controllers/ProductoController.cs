using System;
using System.Collections.Generic;
using System.Linq;
// using System.Reflection.Metadata.Ecma335; // No necesario, se puede quitar
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
// using Microsoft.VisualBasic; // No necesario, se puede quitar
using MiPrimerAppMVC.Models;

namespace MiPrimerAppMVC.Controllers
{
    public class ProductoController : Controller
    {
        public IActionResult Index()
        {
            // Llama a GetData() para obtener la lista de productos
            var productos = GetData();
            // Pasa la lista de productos a la vista
            return View(productos);
        }

        // ¡ELIMINA ESTA LÍNEA! No es necesaria y causa problemas.
        // public required List<Producto> Productos; 

        public IActionResult Inicio()
        {
            return View();
        }

        public List<Producto> GetData()
        {
            // Declara e inicializa la lista local de productos
            List<Producto> productos = new List<Producto>();

            // Añade productos a la lista LOCAL 'productos'
            productos.Add(new Producto {Id=1, Nombre="Cafe", Descripcion="Café molido premium", Precio=50.00m, Activo=true, FechaDeAlta=DateTime.Now.AddDays(-1)});
            productos.Add(new Producto {Id=2, Nombre="Leche", Descripcion="Leche deslactosada", Precio=15.00m, Activo=true, FechaDeAlta=DateTime.Now.AddDays(-1)});
            productos.Add(new Producto {Id=3, Nombre="Cocacola", Descripcion="Cocacola en vidrio", Precio=6.00m, Activo=true, FechaDeAlta=DateTime.Now.AddDays(-1)});
            productos.Add(new Producto {Id=4, Nombre="Chocolate", Descripcion="Chocolate amargo", Precio=22.50m, Activo=true, FechaDeAlta=DateTime.Now.AddDays(-1)});
            productos.Add(new Producto {Id=5, Nombre="Agua pura", Descripcion="Botella de agua pura", Precio=5.00m, Activo=true, FechaDeAlta=DateTime.Now.AddDays(-1)});
            productos.Add(new Producto {Id=6, Nombre="Chocolate", Descripcion="Chocolate con leche", Precio=30.00m, Activo=true, FechaDeAlta=DateTime.Now.AddDays(-1)});
            
            // Retorna la lista LOCAL 'productos'
            return productos;
        }
    }
}
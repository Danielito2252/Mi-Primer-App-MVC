using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiPrimerAppMVC.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public required string  Nombre { get; set; }
        public required string Correo { get; set; }
        public required string Password { get; set; }
        public DateTime FechaDeAlta { get; set; }
        public bool Activo { get; set; }
        
        public required byte[] PasswordHash { get; set; }
        public required byte[] PasswordSalt { get; set; }
        
    }
}
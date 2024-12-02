﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceAPI.Infraestructura.Database.Entities.Cliente
{
    [Table("Cliente")]
    public class ClienteEntity
    {
        [Key]
        public long Cedula { get; set; }
        public long id_Cliente { get; set; }
        public string Nombre_Completo { get; set; }
        public string Correo { get; set; }
        public string Password { get; set; }
        public decimal? Celular { get; set; }
        public string? Direccion { get; set; }
    }
}